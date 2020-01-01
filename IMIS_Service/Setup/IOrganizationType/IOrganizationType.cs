using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIS_Service.ViewModel;
using IMIS_DataEntity.EntityClass;
using ExceptionHandler;

namespace IMIS_Service.Setup.IOrganizationType
{
    public interface IOrganizationType
    {
        Task<DataTableResponse> OrganizationTypeFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditSave(OrganizationTypeVM model);
        Task<(string message, int Id)> DeleteOrganizationType(int OrganizationTypeid);
        Task<OrganizationTypeVM> ViewEdit(int id);
    }
    public class OrganizationType : IOrganizationType
    {
        private readonly IMISDbContext _db;
        public OrganizationType(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> OrganizationTypeFetchData(DataTableVm model)
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

                var accMasters =  (from iot in _db.InvOrgType
                                   where iot.IsActive == true
                                   select new
                                        {
                                            iot.Id,
                                            iot.Code,
                                            iot.IsActive,
                                            iot.NameEn,
                                            iot.NameNp 
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

        public async Task<(string message, int id)> AddEditSave(OrganizationTypeVM model)
        {
            try
            {
                var item = new InvOrgType()
                {
                    Id = model.Id,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp ,
                    Code=model.Code,
                    IsActive=model.IsActive
                };
                if (model.Id == 0)
                {
                    int count = await _db.InvOrgType.CountAsync();
                    item.Id = count + 1;
                    await _db.AddAsync(item);
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

        public async Task<OrganizationTypeVM> ViewEdit(int id)
        {
            try
            {
                var response = await _db.InvOrgType.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (response != null)
                {
                    return (new OrganizationTypeVM()
                    {
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,
                        Code = response.Code,
                        IsActive = response.IsActive,
                        Id=response.Id
                    });
                }
                else
                {
                    return new OrganizationTypeVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteOrganizationType(int OrganizationTypeid)
        {
            try
            {
                var data = _db.InvOrgType.Where(x => x.Id == OrganizationTypeid).FirstOrDefault();
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
