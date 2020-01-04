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

namespace IMIS_Service.Setup.IItemPurMasterPlan
{
    public interface IItemPurMasterPlan
    {
        Task<DataTableResponse> ItemPurMasterPlanFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditItemPurMasterPlan(ItemPurMasterPlanVM model);
        Task<(string message, int Id)> DeleteItemPurMasterPlan(int ItemPurMasterPlanid);
        Task<ItemPurMasterPlanVM> ViewEdit(decimal Id);
    }
    public class ItemPurMasterPlan : IItemPurMasterPlan
    {
        private readonly IMISDbContext _db;
        public ItemPurMasterPlan(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ItemPurMasterPlanFetchData(DataTableVm model)
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

                var accMasters =  (from ipmp in _db.InvPurMastPlan
                                   where ipmp.IsActive == true
                                   select new
                                        {
                                            ipmp.Id,
                                            ipmp.NameEn,
                                            ipmp.NameNp,
                                            ipmp.Code,
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
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
        public async Task<(string message, int id)> AddEditItemPurMasterPlan(ItemPurMasterPlanVM model)
        {
            try
            {
                var item = new InvPurMastPlan()
                {
                    Id = model.Id,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp 
                };
                if (model.Id == 0)
                {
                    int id = await _db.InvPurMastPlan.CountAsync();
                    item.Id = id + 1;
                    _db.InvPurMastPlan.AddRange(item);
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
        public async Task<ItemPurMasterPlanVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvPurMastPlan.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new ItemPurMasterPlanVM()
                    {
                        Id = response.Id,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp 

                    });
                }
                else
                {
                    return new ItemPurMasterPlanVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<(string message, int Id)> DeleteItemPurMasterPlan(int ItemPurMasterPlanid)
        {
            try
            {
                var data = _db.InvPurMastPlan.Where(x => x.Id == ItemPurMasterPlanid).FirstOrDefault();
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
