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

namespace IMIS_Service.Setup.IProjectSetup
{
    public interface IProjectSetup
    {
        Task<DataTableResponse> ProjectSetupFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditProjectSetup(ProjectSetupVM model);
        Task<(string message, int Id)> DeleteProjectSetup(int ProjectSetupid);
        Task<ProjectSetupVM> ViewEdit(decimal Id);
    }
    public class ProjectSetup : IProjectSetup
    {
        private readonly IMISDbContext _db;
        public ProjectSetup(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ProjectSetupFetchData(DataTableVm model)
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

                var accMasters =  (from ip in _db.InvProject
                                   where ip.IsActive == true
                                   select new
                                        {
                                            ip.InvRequisitionMast,
                                             ip.IsActive,
                                             ip.Code,
                                            ip.NameEn,
                                            ip.NameNp, 
                                            ip.ProjectId 
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

                var finallist = await accMasters.OrderByDescending(x => x.ProjectId).Skip(skip).ToListAsync();

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

        public async Task<(string message, int id)> AddEditProjectSetup(ProjectSetupVM model)
        {
            try
            {
                var item = new InvProject()
                {
                    ProjectId = model.ProjectId,
                    Code=model.Code,
                    IsActive=model.IsActive,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp
                };
                if (model.ProjectId == 0)
                {
                    int id = await _db.InvProject.CountAsync();
                    item.ProjectId = id + 1;
                    _db.InvProject.AddRange(item);
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
        public async Task<ProjectSetupVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvProject.Where(x => x.ProjectId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new ProjectSetupVM()
                    {
                        ProjectId = response.ProjectId,
                        Code=response.Code,
                        IsActive=response.IsActive,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,

                    });
                }
                else
                {
                    return new ProjectSetupVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteProjectSetup(int ProjectSetupid)
        {
            try
            {
                var data = _db.InvProject.Where(x => x.ProjectId == ProjectSetupid).FirstOrDefault();
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
