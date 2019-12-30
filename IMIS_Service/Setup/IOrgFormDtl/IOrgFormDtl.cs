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

namespace IMIS_Service.Setup.IOrgFormDtl
{
    public interface IOrgFormDtl
    {
        Task<DataTableResponse> OrgFormDtlFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditOrgFormDtl(OrgFormDtlVM model);
        Task<(string message, int Id)> DeleteOrgFormDtl(int UnitId);
        Task<OrgFormDtlVM> ViewEdit(decimal Id);
    }
    public class OrgFormDtl : IOrgFormDtl
    {
        private readonly IMISDbContext _db;
        public OrgFormDtl(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> OrgFormDtlFetchData(DataTableVm model)
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

                var accMasters =  (from aom in _db.AccOrgMaster
                                        select new
                                        {
                                            aom.OrgId,
                                            aom.NameNp,
                                            aom.NameEn,
                                            aom.RegNo,
                                            aom.Address,
                                            aom.Emails,
                                            aom.MobileNo,
                                            aom.PanNo,
                                            aom.VatNo,
                                            aom.RelatedPerson,
                                            aom.Sapati

                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.OrgId).Skip(skip).ToListAsync();

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
        public async Task<(string message, int id)> AddEditOrgFormDtl(OrgFormDtlVM model)
        {
            try
            {
                var item = new AccOrgMaster()
                {
                    OrgId =         model.OrgId,
                    NameNp =        model.NameNp,
                    NameEn =        model.NameEn,
                    RegNo=          model.RegNo,
                    Address=        model.Address,
                    Emails=         model.Emails,
                    MobileNo=       model.MobileNo,
                    PanNo=          model.PanNo,
                    VatNo=          model.VatNo,
                    RelatedPerson=  model.RelatedPerson,
                    Sapati=         model.Sapati
                };
                if (model.OrgId == 0)
                {
                    int id = await _db.AccOrgMaster.CountAsync();
                    item.OrgId = id + 1;
                    _db.AccOrgMaster.AddRange(item);
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
        public async Task<OrgFormDtlVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.AccOrgMaster.Where(x => x.OrgId == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new OrgFormDtlVM()
                    {
                        OrgId = response.OrgId,
                        NameNp = response.NameNp,
                        NameEn = response.NameEn,
                        RegNo = response.RegNo,
                        Address = response.Address,
                        Emails = response.Emails,
                        MobileNo = response.MobileNo,
                        PanNo = response.PanNo,
                        VatNo = response.VatNo,
                        RelatedPerson = response.RelatedPerson,
                        Sapati = response.Sapati

                    });
                }
                else
                {
                    return new OrgFormDtlVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteOrgFormDtl(int OrgFormDtlid)
        {
            try
            {
                var data = _db.AccOrgMaster.Where(x => x.OrgId == OrgFormDtlid).FirstOrDefault();
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
