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

namespace IMIS_Service.Setup.ISupplierListingDesc
{
    public interface ISupplierListingDesc
    {
        Task<DataTableResponse> SupplierListingDescFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditSupplierListingDescType(SupplierListingDescVM model);

        Task<SupplierListingDescVM> ViewEdit(decimal Id);
    }
    public class SupplierListingDesc : ISupplierListingDesc
    {
        private readonly IMISDbContext _db;
        public SupplierListingDesc(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> SupplierListingDescFetchData(DataTableVm model)
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

                var accMasters =  (from sfc in _db.InvSupplierFiscalyear
                                        select new
                                        {
                                            sfc.Id,
                                            sfc.SupId,
                                            sfc.FiscalYear 
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

        public async Task<(string message, int id)> AddEditSupplierListingDescType(SupplierListingDescVM model)
        {
            try
            {
                var item = new InvSupplierFiscalyear()
                {
                    Id = model.Id 
                };
                if (model.Id == 0)
                {
                    int id = await _db.InvSupplierFiscalyear.CountAsync();
                    item.Id = id + 1;
                    _db.InvSupplierFiscalyear.AddRange(item);
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
        public async Task<SupplierListingDescVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvSupplierFiscalyear.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new SupplierListingDescVM()
                    {
                        Id = response.Id, 

                    });
                }
                else
                {
                    return new SupplierListingDescVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
