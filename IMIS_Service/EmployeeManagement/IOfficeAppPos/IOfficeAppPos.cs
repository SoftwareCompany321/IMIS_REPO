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

namespace IMIS_Service.EmployeeManagement.IOfficeAppPos
{
    public interface IOfficeAppPos
    {
        Task<DataTableResponse> OfficeAppPosFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditOfficeAppPos(OfficeAppPosVM model);

        Task<OfficeAppPosVM> ViewEdit(decimal Id);
    }
    public class OfficeAppPos : IOfficeAppPos
    {
        private readonly IMISDbContext _db;
        public OfficeAppPos(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> OfficeAppPosFetchData(DataTableVm model)
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

                var accMasters =  (from bm in _db.PisLocalPostMaster
                                        select new
                                        {
                                            bm.LocalPostId,
                                            bm.LocalPostName,
                                            bm.LocalPostNameEn 
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.LocalPostName == searchBy || x.LocalPostNameEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.LocalPostId).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data =finallist
                };


            }
            catch (Exception)
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

        public async Task<(string message, int id)> AddEditOfficeAppPos(OfficeAppPosVM model)
        {
            try
            {
                var item = new PisLocalPostMaster()
                {
                    LocalPostId = model.LocalPostId,
                    LocalPostName = model.LocalPostName,
                    LocalPostNameEn = model.LocalPostNameEn
                };
                if (model.LocalPostId == 0)
                {
                    int id = await _db.PisLocalPostMaster.CountAsync();
                    item.LocalPostId = id + 1;
                    _db.PisLocalPostMaster.AddRange(item);
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
        public async Task<OfficeAppPosVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.PisLocalPostMaster.Where(x => x.LocalPostId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new OfficeAppPosVM()
                    {
                        LocalPostId = response.LocalPostId,
                        LocalPostNameEn = response.LocalPostNameEn,
                        LocalPostName = response.LocalPostName,

                    });
                }
                else
                {
                    return new OfficeAppPosVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
