using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IReceiptDistribution
{
    public interface IReceiptDistribution
    {
        Task<DataTableResponse> ReceiptDistributionFetchData(DataTableVm model);
    }
    public class ReceiptDistribution : IReceiptDistribution
    {
        private readonly IMISDbContext _db;
        public ReceiptDistribution(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ReceiptDistributionFetchData(DataTableVm model)
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

                var accMasters = (from ib in _db.Issuedbills
                                  select new
                                  {
                                      ib.Billnofrom,
                                      ib.Billnoto,
                                      ib.Counterid,
                                      ib.Dateissued,
                                      ib.Sn,
                                      ib.Specialnotes,
                                      ib.Thelino,
                                      ib.Userid
                                  });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();

                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Counterid).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data =finallist
                };


            }
            catch (Exception ex)
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
    }
}
