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

namespace IMIS_Service.Setup.IBankDtl
{
    public interface IBankDtl
    {
        Task<DataTableResponse> BankDtlFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditBankDtl(BankDtlVM model);
        Task<(string message, int Id)> DeleteBankDtl(int UnitId);
        Task<BankDtlVM> ViewEdit(decimal Id);
        Task<string> DeleteById(int id);
    }
    public class BankDtl : IBankDtl
    {
        private readonly IMISDbContext _db;
        public BankDtl(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> BankDtlFetchData(DataTableVm model)
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

                var accMasters = (from bm in _db.Bankmaster
                                  select new
                                  {
                                      bm.Code,
                                      bm.Bankid,
                                      bm.Nepname,
                                      bm.Engname
                                  });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters = accMasters.Where(x => x.Nepname == searchBy || x.Engname == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Bankid).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = finallist
                };


            }
            catch (Exception)
            {
                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = 0
                };
                //add to do for the error log save in db
            }
        }

        public async Task<(string message, int id)> AddEditBankDtl(BankDtlVM model)
        {
            try
            {
                var item = new Bankmaster()
                {
                    Bankid = model.Bankid,
                    Nepname = model.Nepname,
                    Engname = model.Engname
                };
                if (model.Bankid == 0)
                {
                    int id = await _db.Bankmaster.CountAsync();
                    item.Bankid = id + 1;
                    _db.Bankmaster.AddRange(item);
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
        public async Task<BankDtlVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.Bankmaster.Where(x => x.Bankid == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new BankDtlVM()
                    {
                        Bankid = response.Bankid,
                        Engname = response.Engname,
                        Nepname = response.Nepname,

                    });
                }
                else
                {
                    return new BankDtlVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteBankDtl(int BankDtlid)
        {
            try
            {
                var data = _db.Bankmaster.Where(x => x.Bankid == BankDtlid).FirstOrDefault();
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

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var data = await _db.Bankmaster.Where(x => x.Bankid == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    _db.Bankmaster.Remove(data);
                    _db.SaveChanges(true);
                    return "success";
                }
                return "fail";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
