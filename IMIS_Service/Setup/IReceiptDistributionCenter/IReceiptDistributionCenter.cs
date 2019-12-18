using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IReceiptDistributionCenter
{
    public interface IReceiptDistributionCenter
    {
        Task<DataTableResponse> ReceiptDistributionCenterFetchData(DataTableVm model);
    }
    public class ReceiptDistributionCenter : IReceiptDistributionCenter
    {
        private readonly IMISDbContext _db;
        public ReceiptDistributionCenter(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ReceiptDistributionCenterFetchData(DataTableVm model)
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

                var accMasters =  (from cc in _db.Collectioncounters
                                        select new
                                        {
                                            cc.Location,
                                            cc.Macaddress,
                                            cc.Nepname,
                                            cc.Specialnotes,
                                            cc.TaxThliIssuedCntr,
                                            cc.Wardno,
                                            cc.Counterid,
                                            cc.CmptrName,
                                            cc.Counterheadid
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
    }
}
