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

namespace IMIS_Service.EmployeeManagement.ICivilServices
{
    public interface ICivilServices
    {
        Task<DataTableResponse> CivilServicesFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditCivilServices(CivilServicesVM model);

        Task<CivilServicesVM> ViewEdit(decimal Id);
    }
    public class CivilServices : ICivilServices
    {
        private readonly IMISDbContext _db;
        public CivilServices(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> CivilServicesFetchData(DataTableVm model)
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

                var accMasters =  (from bm in _db.PisNijamatiSewaSamuha
                                        select new
                                        {
                                            bm.Id,
                                            bm.NameNp,
                                            bm.NameEn 
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

        public async Task<(string message, int id)> AddEditCivilServices(CivilServicesVM model)
        {
            try
            {
                var item = new PisNijamatiSewaSamuha()
                {
                    Id = model.Id,
                    NameNp = model.NameNp,
                    NameEn = model.NameEn
                };
                if (model.Id == 0)
                {
                    int id = await _db.PisNijamatiSewaSamuha.CountAsync();
                    item.Id = id + 1;
                    _db.PisNijamatiSewaSamuha.AddRange(item);
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
        public async Task<CivilServicesVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.PisNijamatiSewaSamuha.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new CivilServicesVM()
                    {
                        Id = response.Id,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,

                    });
                }
                else
                {
                    return new CivilServicesVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
