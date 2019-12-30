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

namespace IMIS_Service.Setup.IIncomeRecordKeeping
{
    public interface IIncomeRecordKeeping
    {
        Task<DataTableResponse> IncomeRecordKeepingFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditIncomeRecordKeeping(IncomeRecordKeepingVM model);

        Task<IncomeRecordKeepingVM> ViewEdit(decimal Id);
    }
    public class IncomeRecordKeeping : IIncomeRecordKeeping
    {
        private readonly IMISDbContext _db;
        public IncomeRecordKeeping(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> IncomeRecordKeepingFetchData(DataTableVm model)
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

                var accMasters =  (from sb in _db.Storedbills
                                        select new
                                        {
                                            sb.Code,
                                            sb.Billtype,
                                            sb.Sn,
                                            sb.Billnoto
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Code).Skip(skip).ToListAsync();

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

        public async Task<(string message, int id)> AddEditIncomeRecordKeeping(IncomeRecordKeepingVM model)
        {
            try
            {
                var item = new Storedbills()
                {
                    Sn = model.Sn 
                };
                if (model.Sn == 0)
                {
                    int id = await _db.Storedbills.CountAsync();
                    item.Sn = id + 1;
                    _db.Storedbills.AddRange(item);
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
        public async Task<IncomeRecordKeepingVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.Storedbills.Where(x => x.Sn == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new IncomeRecordKeepingVM()
                    {
                        Sn = response.Sn 

                    });
                }
                else
                {
                    return new IncomeRecordKeepingVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
