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

namespace IMIS_Service.Setup.IPurchaseOrderType
{
    public interface IPurchaseOrderType
    {
        Task<DataTableResponse> PurchaseOrderTypeFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditPurchaseOrderType(PurchaseOrderTypeVM model);
        Task<(string message, int Id)> DeletePurchaseOrderType(int PurchaseOrderTypeid);
        Task<PurchaseOrderTypeVM> ViewEdit(decimal Id);
    }
    public class PurchaseOrderType : IPurchaseOrderType
    {
        private readonly IMISDbContext _db; 
        public PurchaseOrderType(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> PurchaseOrderTypeFetchData(DataTableVm model)
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

                var accMasters =  (from tka in _db.TblKharidaAadash
                                        select new
                                        {
                                            tka.EngName,
                                            tka.Id,
                                            tka.NpName 
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.NpName == searchBy || x.EngName == searchBy);
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
        public async Task<(string message, int id)> AddEditPurchaseOrderType(PurchaseOrderTypeVM model)
        {
            try
            {
                var item = new TblKharidaAadash()
                {
                    Id = model.Id,
                    EngName = model.EngName,
                    NpName = model.NpName
                };
                if (model.Id == 0)
                {
                    int id = await _db.TblKharidaAadash.CountAsync();
                    item.Id = id + 1;
                    _db.TblKharidaAadash.AddRange(item);
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
        public async Task<PurchaseOrderTypeVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.TblKharidaAadash.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new PurchaseOrderTypeVM()
                    {
                        Id = response.Id,
                        EngName = response.EngName,
                        NpName = response.NpName,

                    });
                }
                else
                {
                    return new PurchaseOrderTypeVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeletePurchaseOrderType(int PurchaseOrderTypeid)
        {
            try
            {
                var data = _db.TblKharidaAadash.Where(x => x.Id == PurchaseOrderTypeid).FirstOrDefault();
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
