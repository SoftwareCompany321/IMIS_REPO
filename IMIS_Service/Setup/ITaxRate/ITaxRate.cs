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

namespace IMIS_Service.Setup.ITaxRate
{
    public interface ITaxRate
    {
        Task<DataTableResponse> TaxRateFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditTaxRate(TaxRateVM model);
        Task<(string message, int Id)> DeleteTaxRate(int UnitId);
        Task<TaxRateVM> ViewEdit(decimal Id);
    }
    public class TaxRate : ITaxRate
    {
        private readonly IMISDbContext _db;
        public TaxRate(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> TaxRateFetchData(DataTableVm model)
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

                var accMasters =  (from taxRate in _db.InvTaxRate
                                        select new
                                        {
                                            taxRate.TaxRateId,
                                            taxRate.TaxRate,
                                            taxRate.NameEn,
                                            taxRate.NameNp 
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

                var finallist = await accMasters.OrderByDescending(x => x.TaxRateId).Skip(skip).ToListAsync();

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

        public async Task<(string message, int id)> AddEditTaxRate(TaxRateVM model)
        {
            try
            {
                var item = new InvTaxRate()
                {
                    TaxRateId = model.TaxRateId,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp,
                    TaxRate=model.TaxRate
                };
                if (model.TaxRateId == 0)
                {
                    int id = await _db.InvTaxRate.CountAsync();
                    item.TaxRateId = id + 1;
                    _db.InvTaxRate.AddRange(item);
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
        public async Task<TaxRateVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvTaxRate.Where(x => x.TaxRateId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new TaxRateVM()
                    {
                        TaxRateId = response.TaxRateId,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,
                        TaxRate=response.TaxRate

                    });
                }
                else
                {
                    return new TaxRateVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteTaxRate(int taxrateid)
        {
            try
            {
                var data = _db.InvTaxRate.Where(x => x.TaxRateId == taxrateid).FirstOrDefault();
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
