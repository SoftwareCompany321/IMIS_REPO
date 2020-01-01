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

namespace IMIS_Service.Setup.IDepartment
{
    public interface IDepartment
    {
        Task<DataTableResponse> DepartmentFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditDepartment(DepartmentVM model);
        Task<(string message, int Id)> DeleteDepartment(int UnitId);
        Task<DepartmentVM> ViewEdit(decimal Id);
    }
    public class Department : IDepartment
    {
        private readonly IMISDbContext _db;
        public Department(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> DepartmentFetchData(DataTableVm model)
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

                var accMasters =  (from ids in _db.InvDept
                                   where ids.IsActive==true
                                        select new
                                        {
                                            ids.DeptId,
                                            ids.Code,
                                            ids.NameEn,
                                            ids.NameNp ,
                                            ids.IsActive
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

                var finallist = await accMasters.OrderByDescending(x => x.DeptId).Skip(skip).ToListAsync();

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
        public async Task<(string message, int id)> AddEditDepartment(DepartmentVM model)
        {
            try
            {
                var item = new InvDept()
                {
                    DeptId = model.DeptId,
                    Code=model.Code,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp ,
                    IsActive=model.IsActive
                };
                if (model.DeptId == 0)
                {
                    int id = await _db.InvDept.CountAsync();
                    item.DeptId = id + 1;
                    _db.InvDept.AddRange(item);
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
        public async Task<DepartmentVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvDept.Where(x => x.DeptId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new DepartmentVM()
                    {
                        DeptId = response.DeptId ,
                        Code=response.Code,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,
                        IsActive=response.IsActive,
                    });
                }
                else
                {
                    return new DepartmentVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteDepartment(int Departmentid)
        {
            try
            {
                var data = _db.InvDept.Where(x => x.DeptId == Departmentid).FirstOrDefault();
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
