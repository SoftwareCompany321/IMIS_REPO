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

namespace IMIS_Service.Setup.IItemOtherSetupType
{
    public interface IItemOtherSetupType
    {
        Task<DataTableResponse> ItemOtherSetupTypeFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditItemOtherSetupType(ItemOtherSetupTypeVM model);
        Task<(string message, int Id)> DeleteItemOtherSetupType(int UnitId);
        Task<ItemOtherSetupTypeVM> ViewEdit(decimal Id);

    }
    public class ItemOtherSetupType : IItemOtherSetupType
    {
        private readonly IMISDbContext _db;
        public ItemOtherSetupType(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ItemOtherSetupTypeFetchData(DataTableVm model)
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

                var accMasters =  (from its in _db.InvTypeSetup
                                        select new
                                        {
                                            its.Id,
                                            its.DescEn,
                                            its.DescNp 
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.DescNp == searchBy || x.DescEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Id).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data =finallist
                };


            }
            catch (Exception )
            {
                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data =0
                };
                //add to do for the error log save in db
            }
        }


        public async Task<(string message, int id)> AddEditItemOtherSetupType(ItemOtherSetupTypeVM model)
        {
            try
            {
                var item = new InvTypeSetup()
                {
                    Id = model.Id,
                    DescEn = model.DescEn,
                    DescNp = model.DescNp
                };
                if (model.Id == 0)
                {
                    int id = await _db.InvTypeSetup.CountAsync();
                    item.Id = id + 1;
                    _db.InvTypeSetup.AddRange(item);
                }
                else
                {
                    _db.Entry(item).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);

                return ("success", 0);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ItemOtherSetupTypeVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvTypeSetup.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new ItemOtherSetupTypeVM()
                    {
                        Id = response.Id,
                        DescEn = response.DescEn,
                        DescNp = response.DescNp 

                    });
                }
                else
                {
                    return new ItemOtherSetupTypeVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteItemOtherSetupType(int ItemOtherSetupTypeid)
        {
            try
            {
                var data = _db.InvTypeSetup.Where(x => x.Id == ItemOtherSetupTypeid).FirstOrDefault();
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
