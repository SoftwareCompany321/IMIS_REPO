using ExceptionHandler;
using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IItemSpecification
{
    public interface IItemSpecification
    {
        Task<DataTableResponse> ItemSpecificationFetchData(DataTableVm model);
        Task<(string message, int Id)> AddEdit(ItemSpecificationVM Model);
        Task<(string message, int Id)> DeleteItemSpecification(int ItemSpecificationid);
        Task<ItemSpecificationVM> ViewOrEditData(int Id);
    }
    public class ItemSpecification : IItemSpecification
    {
        private readonly IMISDbContext _db;
        public ItemSpecification(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ItemSpecificationFetchData(DataTableVm model)
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

                var accMasters =  (from iis in _db.InvItemSpec
                                   where iis.IsActive == true
                                   select new
                                        {
                                            iis.SpecId,
                                            iis.Code,
                                            iis.NameEn,
                                            iis.NameNp 
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters = accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.SpecId).Skip(skip).ToListAsync();

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

        public async Task<(string message, int Id)> AddEdit(ItemSpecificationVM Model)
        {
            try
            {
                var AddEdit = new InvItemSpec()
                {
                    SpecId = Model.SpecId,
                    Code = Model.Code,
                    NameEn = Model.NameEn,
                    NameNp = Model.NameNp, 
                    IsActive=Model.IsActive

                };

                if (Model.SpecId == 0)
                {
                    int countrow = await _db.InvItemSpec.CountAsync();
                    AddEdit.SpecId = countrow + 1;
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

        public async Task<ItemSpecificationVM> ViewOrEditData(int SpecificationId)
        {
            try
            {
                var data = await _db.InvItemSpec.Where(x => x.SpecId == SpecificationId).FirstOrDefaultAsync();
                if (data != null)
                {
                    return new ItemSpecificationVM()
                    {
                        SpecId = data.SpecId,
                        Code = data.Code,
                        NameNp = data.NameNp,
                        NameEn = data.NameEn, 
                        IsActive = data.IsActive
                    };
                }
                else
                {
                    return new ItemSpecificationVM();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteItemSpecification(int ItemSpecificationid)
        {
            try
            {
                var data = _db.InvItemSpec.Where(x => x.SpecId == ItemSpecificationid).FirstOrDefault();
                if (data != null)
                {
                    data.IsActive = false;
                    _db.Entry(data).State = EntityState.Modified;

                }
                await _db.SaveChangesAsync(true);
                return ("success", 0);
            }
            catch (Exception ex)
            {
                ExceptionManager.AppendLog(ex);
                throw;
            }

        }
    }
}
