using IMIS_CORE.Core;
using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IItemUnit
{
    public interface IItemUnit
    {
        Task<DataTableResponse> ItemUnitFetchData(DataTableVm model);

        Task<(string message, int Id)> AddEdit(ItemUnitVM Model);

        Task<ItemUnitVM> ViewOrEditData(int Id);

        IEnumerable<SelectListItem> GetItemUnitList();
    }
    public class ItemUnit : IItemUnit
    {
        private readonly IMISDbContext _db;
        public ItemUnit(IMISDbContext db)
        {
            _db = db;
        }

        public async Task<(string message, int Id)> AddEdit(ItemUnitVM Model)
        {
            try
            {
                var AddEdit = new InvUnit()
                {
                    UnitId = Model.UnitId,
                    DescEn = Model.DescEn,
                    DescNp = Model.DescNp,
                    NoOfUnits = Model.NoOfUnits

                };

                if (Model.UnitId == 0)
                {
                    int countrow = await _db.InvUnit.CountAsync();
                    AddEdit.UnitId = countrow + 1;
                    await _db.AddAsync(AddEdit);
                }
                else
                {
                    _db.Entry(AddEdit).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);
                return ("success", 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DataTableResponse> ItemUnitFetchData(DataTableVm model)
        {
            string searchBy = string.Empty;
            int skip = 0;
            int take = 10;
            int totalResultsCount = 0;
            int filteredResultsCount = 0;
            int draw = 0;

            try
            {

                if (model != null)
                {
                    searchBy = searchBy = !string.IsNullOrEmpty(model.search) ? model.search.Trim() : "";
                    take = model.length;
                    skip = model.start;
                    draw = model.draw;
                }

                var accMasters = (from iu in _db.InvUnit
                                  select new
                                  {
                                      iu.UnitId,
                                      iu.DescEn,
                                      iu.DescNp,
                                      iu.NoOfUnits
                                  });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.UnitId).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = finallist
                };


            }
            catch (Exception)
            {
                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = 0
                };
                //add to do for the error log save in db
            }
        }

        public async Task<ItemUnitVM> ViewOrEditData(int UnitId)
        {
            try
            {
                var data = await _db.InvUnit.Where(x => x.UnitId == UnitId).FirstOrDefaultAsync();
                if (data != null)
                {
                    return new ItemUnitVM()
                    {
                        UnitId = data.UnitId,
                        DescNp = data.DescNp,
                        DescEn = data.DescEn,
                        NoOfUnits = data.NoOfUnits
                    };
                }
                else
                {
                    return new ItemUnitVM();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<SelectListItem> GetItemUnitList()
        {
            return new SelectList(_db.InvUnit.Where(x => x.UnitId == x.UnitId), "UnitId", Utils.ToggleLanguage("DescEn", "DescNp"));

        }
        ///Delete ItemUnit
        ///
        ///

        public async Task<(string message, int Id)> DeleteItemUnit(ItemUnitVM Model)
        {
            try
            {
                var AddEdit = new InvUnit()
                {
                    //IsActive = false

                };

                if (Model.UnitId != 0)
                {
                    _db.Entry(AddEdit).State = EntityState.Modified;
                }

                await _db.SaveChangesAsync(true);
                return ("success", 0);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
