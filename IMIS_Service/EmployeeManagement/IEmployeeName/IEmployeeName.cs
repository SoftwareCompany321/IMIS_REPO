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

namespace IMIS_Service.EmployeeManagement.IEmployeeName
{
    public interface IEmployeeName
    {
        Task<DataTableResponse> EmployeeNameFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditEmployeeName(EmployeeNameVM model);
        IEnumerable<SelectListItem> GetPostLevel();
        IEnumerable<SelectListItem> GetLocalPost();
        IEnumerable<SelectListItem> GetServiceStatus();
        IEnumerable<SelectListItem> GetRoomNo();
        Task<EmployeeNameVM> ViewEdit(decimal Id);
    }
    public class EmployeeName : IEmployeeName
    {
        private readonly IMISDbContext _db;
        public EmployeeName(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> EmployeeNameFetchData(DataTableVm model)
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

                var accMasters =  (from bm in _db.PisEmployeeMaster
                                  
                                        select new
                                        {
                                            bm.EmpId,
                                            bm.Code,
                                            bm.FirstNameNp,
                                            bm.FirstNameEn ,
                                            bm.LastNameEn,
                                            bm.LastNameNp,
                                            bm.LocalPostId,
                                            bm.PostId,
                                            bm.RoomId,
                                            bm.ServiceStatus
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.FirstNameNp == searchBy || x.FirstNameEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.EmpId).Skip(skip).ToListAsync();

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

        public async Task<(string message, int id)> AddEditEmployeeName(EmployeeNameVM model)
        {
            try
            {
                var item = new PisEmployeeMaster()
                {
                    EmpId = model.EmpId,
                    Code = model.Code,
                    FirstNameNp = model.FirstNameNp,
                    FirstNameEn = model.FirstNameEn,
                    LastNameEn=model.LastNameEn,
                    LastNameNp=model.LastNameNp,
                    PostId=model.PostId,
                    LocalPostId=model.LocalPostId,
                    ServiceStatus=model.ServiceStatus,
                    RoomId=model.RoomId
                };
                if (model.EmpId == 0)
                {
                    int id = await _db.PisEmployeeMaster.CountAsync();
                    item.EmpId = id + 1;
                    _db.PisEmployeeMaster.AddRange(item);
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
        public async Task<EmployeeNameVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.PisEmployeeMaster.Where(x => x.EmpId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new EmployeeNameVM()
                    {
                        EmpId = response.EmpId,
                        Code = response.Code,
                        FirstNameEn = response.FirstNameEn,
                        FirstNameNp = response.FirstNameNp,
                        LastNameEn = response.LastNameEn,
                        LastNameNp = response.LastNameNp,
                        PostId = response.PostId,
                        LocalPostId = response.LocalPostId,
                        ServiceStatus = response.ServiceStatus,
                        RoomId = response.RoomId
                    });
                }
                else
                {
                    return new EmployeeNameVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<SelectListItem> GetPostLevel()
        {
            return new SelectList(_db.PisPostMaster.Where(x => x.PostId == x.PostId), "PostId", Utils.ToggleLanguage("GeneralPost", "GeneralPostShort"));

        }
        public IEnumerable<SelectListItem> GetLocalPost()
        {
            return new SelectList(_db.PisLocalPostMaster.Where(x => x.LocalPostId == x.LocalPostId), "LocalPostId", Utils.ToggleLanguage("LocalPostNameEn", "LocalPostName"));

        }
        public IEnumerable<SelectListItem> GetServiceStatus()
        {
            return new SelectList(_db.PisServiceStatus.Where(x => x.Id == x.Id), "Id", Utils.ToggleLanguage("NameEn", "NameNp"));

        }
        public IEnumerable<SelectListItem> GetRoomNo()
        {
            return new SelectList(_db.InvRoomMst.Where(x => x.RoomId == x.RoomId), "RoomId", Utils.ToggleLanguage("DescEn", "DescNp"));

        }

    }
}
