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

namespace IMIS_Service.EmployeeManagement.IOfficeOrgStructure
{
    public interface IOfficeOrgStructure
    {
        Task<DataTableResponse> OfficeOrgStructureFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditOfficeOrgStructure(OfficeOrgStructureVM model);

        Task<OfficeOrgStructureVM> ViewEdit(decimal Id);
    }
    public class OfficeOrgStructure : IOfficeOrgStructure
    {
        private readonly IMISDbContext _db;
        public OfficeOrgStructure(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> OfficeOrgStructureFetchData(DataTableVm model)
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

                var accMasters =  (from bm in _db.OrganizationTree
                                        select new
                                        {
                                            bm.Id 
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                     
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

        public async Task<(string message, int id)> AddEditOfficeOrgStructure(OfficeOrgStructureVM model)
        {
            try
            {
                var item = new OrganizationTree()
                {
                    Id = model.Id 
                };
                if (model.Id == 0)
                {
                    int id = await _db.OrganizationTree.CountAsync();
                    item.Id = id + 1;
                    _db.OrganizationTree.AddRange(item);
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
        public async Task<OfficeOrgStructureVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.OrganizationTree.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new OfficeOrgStructureVM()
                    {
                        Id = response.Id, 

                    });
                }
                else
                {
                    return new OfficeOrgStructureVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
