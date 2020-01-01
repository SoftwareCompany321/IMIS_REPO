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

namespace IMIS_Service.Setup.ICountryDtl
{
    public interface ICountryDtl
    {
        Task<DataTableResponse> CountryDtlFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditCountryDtl(CountryDtlVM model);

        Task<CountryDtlVM> ViewEdit(decimal Id);
        Task<string> Delete(int Id);
    }
    public class CountryDtl : ICountryDtl
    {
        private readonly IMISDbContext _db;
        public CountryDtl(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> CountryDtlFetchData(DataTableVm model)
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

                var accMasters =  (from nt in _db.Nationalities
                                        select new
                                        {
                                            nt.Nationalityid,
                                            nt.Nepname,
                                            nt.Engname 
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.Nepname == searchBy || x.Engname == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Nationalityid).Skip(skip).ToListAsync();

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
        public async Task<(string message, int id)> AddEditCountryDtl(CountryDtlVM model)
        {
            try
            {
                var item = new Nationalities()
                {
                    Nationalityid = model.Nationalityid,
                    Nepname = model.Nepname,
                    Engname = model.Engname
                };
                if (model.Nationalityid == 0)
                {
                    int id = await _db.Nationalities.CountAsync();
                    item.Nationalityid = id + 1;
                    _db.Nationalities.AddRange(item);
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
        public async Task<CountryDtlVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.Nationalities.Where(x => x.Nationalityid == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new CountryDtlVM()
                    {
                        Nationalityid = response.Nationalityid,
                        Engname = response.Engname,
                        Nepname = response.Nepname,

                    });
                }
                else
                {
                    return new CountryDtlVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> Delete(int Id)
        {
            try
            {
                var response = await _db.Nationalities.Where(x => x.Nationalityid == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    _db.Nationalities.Remove(response);
                    _db.SaveChanges(true);
                    return "success";
                }
                else
                {
                    return "fail";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
