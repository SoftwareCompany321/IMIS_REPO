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

namespace IMIS_Service.EmployeeManagement.IEmployeePosition
{
    public interface IEmployeePosition
    {
        Task<DataTableResponse> EmployeePositionFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditEmployeePosition(EmployeePositionVM model);

        Task<EmployeePositionVM> ViewEdit(decimal Id);
    }
    public class EmployeePosition : IEmployeePosition
    {
        private readonly IMISDbContext _db;
        public EmployeePosition(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> EmployeePositionFetchData(DataTableVm model)
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

                var accMasters =  (from bm in _db.PisPostMaster
                                   select new
                                        {
                                            bm.PostId ,
                                            bm.GeneralPost,
                                            bm.GeneralPostShort
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.GeneralPost == searchBy || x.GeneralPostShort == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.PostId).Skip(skip).ToListAsync();

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

        public async Task<(string message, int id)> AddEditEmployeePosition(EmployeePositionVM model)
        {
            try
            {
                var item = new PisPostMaster()
                {
                    PostId = model.PostId,
                    GeneralPost = model.GeneralPost,
                    GeneralPostShort = model.GeneralPostShort
                };
                if (model.PostId == 0)
                {
                    int id = await _db.PisPostMaster.CountAsync();
                    item.PostId = id + 1;
                    _db.PisPostMaster.AddRange(item);
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
        public async Task<EmployeePositionVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.PisPostMaster.Where(x => x.PostId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new EmployeePositionVM()
                    {
                        PostId = response.PostId,
                        GeneralPost = response.GeneralPost,
                        GeneralPostShort = response.GeneralPostShort,

                    });
                }
                else
                {
                    return new EmployeePositionVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
