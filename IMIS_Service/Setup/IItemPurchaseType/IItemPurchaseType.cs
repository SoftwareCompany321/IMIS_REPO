using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IItemPurchaseType
{
    public interface IItemPurchaseType
    {
        Task<DataTableResponse> ItemPurchaseTypeFetchData(DataTableVm model);
    }
    public class IBankDtl : IItemPurchaseType
    {
        private readonly IMISDbContext _db;
        public IBankDtl(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ItemPurchaseTypeFetchData(DataTableVm model)
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

                var accMasters =  (from accountH in _db.AccAccMaster
                                        select new
                                        {
                                            accountH.AccId,
                                            accountH.AccCode,
                                            accountH.Code,
                                            accountH.EngName,
                                            accountH.NepName,
                                            accountH.FiscalYear,
                                            accountH.IsTransactable,
                                            accountH.IsBudgetable
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.NepName == searchBy || x.EngName==searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.AccCode).Skip(skip).ToListAsync();

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
