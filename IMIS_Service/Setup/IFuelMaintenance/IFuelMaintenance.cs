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

namespace IMIS_Service.Setup.IFuelMaintenance
{
    public interface IFuelMaintenance
    {
        Task<DataTableResponse> FuelMaintenanceFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditFuelMaintenance(FuelMaintenanceVM model);
        Task<(string message, int Id)> DeleteFuelMaintenance(int FuelMaintenanceid);
        Task<FuelMaintenanceVM> ViewEdit(decimal Id);
    }
    public class FuelMaintenance : IFuelMaintenance
    {
        private readonly IMISDbContext _db;
        public FuelMaintenance(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> FuelMaintenanceFetchData(DataTableVm model)
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

                var accMasters =  (from tvp in _db.TblVehicleParts
                                        select new
                                        {
                                            tvp.Sn,
                                            tvp.NpName,
                                            tvp.EngName 
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

                var finallist = await accMasters.OrderByDescending(x => x.Sn).Skip(skip).ToListAsync();

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
        public async Task<(string message, int id)> AddEditFuelMaintenance(FuelMaintenanceVM model)
        {
            try
            {
                var item = new TblVehicleParts()
                {
                    Sn = model.Sn,
                    EngName =model.EngName,
                    NpName=model.NpName
                };
                if (model.Sn == 0)
                {
                    int id = await _db.TblVehicleParts.CountAsync();
                    item.Sn = id + 1;
                    _db.TblVehicleParts.AddRange(item);
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
        public async Task<FuelMaintenanceVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.TblVehicleParts.Where(x => x.Sn == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new FuelMaintenanceVM()
                    {
                        Sn = response.Sn,
                        EngName = response.EngName,
                        NpName = response.NpName,
                    });
                }
                else
                {
                    return new FuelMaintenanceVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteFuelMaintenance(int FuelMaintenanceid)
        {
            try
            {
                var data = _db.TblVehicleParts.Where(x => x.Sn == FuelMaintenanceid).FirstOrDefault();
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
