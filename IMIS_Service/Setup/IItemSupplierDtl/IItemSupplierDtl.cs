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

namespace IMIS_Service.Setup.IItemSupplierDtl
{
    public interface IItemSupplierDtl
    {
        Task<DataTableResponse> ItemSupplierDtlFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditItemSupplierDtl(ItemSupplierDtlVM model);
        Task<(string message, int Id)> DeleteItemSupplierDtl(int UnitId);
        Task<ItemSupplierDtlVM> ViewEdit(int Id);
    }
    public class ItemSupplierDtl : IItemSupplierDtl
    {
        private readonly IMISDbContext _db;
        private readonly IMapper _mapper;
        public ItemSupplierDtl(IMISDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;

        }
        public async Task<DataTableResponse> ItemSupplierDtlFetchData(DataTableVm model)
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

                var accMasters = (from invs in _db.InvSupplier
                                  select new
                                  {
                                      invs.SupId,
                                      invs.NameEn,
                                      invs.NameNp,
                                      invs.Address,
                                      invs.Email,
                                      invs.RegNo,
                                      invs.OrgType,
                                      invs.SupType,
                                      invs.TpinPanNo,

                                  });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters = accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }
                var finallist = await accMasters.OrderByDescending(x => x.SupId).Skip(skip).ToListAsync();
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

        public async Task<(string message, int id)> AddEditItemSupplierDtl(ItemSupplierDtlVM model)
        {
            try
            {
                if (model.SubT == true)
                {
                    model.SupType = "Y";
                }
                else
                {
                    model.SupType = "N";
                }

                var item = _mapper.Map<InvSupplier>(model);
                if (model.SupId == 0)
                {
                    item.DateVs = null;
                    item.DateAd = DateTime.Now;
                    int id = await _db.InvSupplier.CountAsync();
                    item.SupId = id + 1;
                    _db.Entry(item).State = EntityState.Added;
                }
                else
                {
                    _db.Entry(item).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);
                return ("success", 0);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<ItemSupplierDtlVM> ViewEdit(int Id)
        {
            try
            {
                var response = await _db.InvSupplier.Where(x => x.SupId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    // var data = _mapper.Map<ItemSupplierDtlVM>(response);

                    return new ItemSupplierDtlVM()
                    {
                        Address = response.Address,
                        NameNp = response.NameNp,
                        Email = response.Email,
                        TpinPanNo = response.TpinPanNo,
                        PhoneNo = response.PhoneNo,
                        OrgId = response.OrgId,
                        SubT = response.SupType == "Y" ? true : false,
                        RegiType=response.RegiType,
                        RegNo=response.RegNo,
                        SupId=response.SupId,
                        OrgType=response.OrgType

                    };
                    // return (data);
                }
                else
                {
                    return new ItemSupplierDtlVM();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<(string message, int Id)> DeleteItemSupplierDtl(int ItemSupplierDtlid)
        {
            try
            {
                var data = _db.InvSupplier.Where(x => x.SupId == ItemSupplierDtlid).FirstOrDefault();
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
