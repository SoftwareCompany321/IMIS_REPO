using AutoMapper;
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

namespace IMIS_Service.Setup.IReceiptDistributionCenter
{
    public interface IReceiptDistributionCenter
    {
        Task<DataTableResponse> ReceiptDistributionCenterFetchData(DataTableVm model);

        Task<(string message, int Id)> AddEditSave(ReceiptDistributionCenterVM model);
        Task<(string message, int Id)> DeleteReceiptDistributionCenter(int ReceiptDistributionCenterid);
        Task<ReceiptDistributionCenterVM> ViewEdit(int id);
    }
    public class ReceiptDistributionCenter : IReceiptDistributionCenter
    {
        private readonly IMISDbContext _db;
        private readonly IMapper _mapper;
        public ReceiptDistributionCenter(IMISDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<(string message, int Id)> AddEditSave(ReceiptDistributionCenterVM model)
        {

            try
            {
                var response = _mapper.Map<Collectioncounters>(model);

                if (model.Counterid == 0)
                {
                    int count =await _db.Collectioncounters.CountAsync();
                    response.Counterid = count + 1;
                    _db.Entry(response).State = EntityState.Added;
                }
                else
                {
                    _db.Entry(response).State = EntityState.Modified;
                }

                await _db.SaveChangesAsync(true);

                return ("success", 0);
            }
            catch (Exception ex)
            {

                throw ex;
            }


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
                                   where cc.IsActive == true
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

        public async Task<ReceiptDistributionCenterVM> ViewEdit(int id)
        {
            try
            { 
                var response = await _db.Collectioncounters.Where(x => x.Counterid == id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (_mapper.Map<ReceiptDistributionCenterVM>(response));
                }
                return new ReceiptDistributionCenterVM();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteReceiptDistributionCenter(int ReceiptDistributionCenterid)
        {
            try
            {
                var data = _db.Collectioncounters.Where(x => x.Counterid == ReceiptDistributionCenterid).FirstOrDefault();
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
