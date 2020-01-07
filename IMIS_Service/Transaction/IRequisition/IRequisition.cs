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

namespace IMIS_Service.Transaction.IRequisition
{
    public interface IRequisition
    {
        Task<DataTableResponse> RequisitionFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditRequisition(RequisitionVM model);

        Task<RequisitionVM> ViewEdit(decimal Id);
        Task<string> Delete(int Id);
    }
    public class Requisition : IRequisition
    {
        private readonly IMISDbContext _db;
        public Requisition(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> RequisitionFetchData(DataTableVm model)
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

                var accMasters = (from invreq in _db.InvRequisitionMast
                                      //join reqdetail in _db.InvReqDetail
                                      //on invreq.Code equals reqdetail.Code into leftinvreq
                                      //from leftreq in leftinvreq.DefaultIfEmpty()
                                      //join invmaster in _db.InvIssueMaster on invreq.Code equals invmaster.Code into leftjoinmaster
                                      //from leftmaaster in leftjoinmaster.DefaultIfEmpty()
                                  select new
                                  {
                                      id = invreq.Id,
                                      code=invreq.Code,
                                      stockGive = invreq.StockGive,
                                      itemId = invreq.ItemId,
                                      typeId = invreq.TypeId,
                                      remarks = invreq.Remarks,
                                      reqId = invreq.ReqId,
                                      reqDateEng = invreq.ReqDateEng,
                                      reqType = invreq.ReqType,
                                      orgstaffpost = invreq.Orgstaffpost,
                                      reqByNavigation = invreq.ReqByNavigation,
                                      purchaseGive = invreq.PurchaseGive,
                                      maintainItemId = invreq.MaintainItemId,
                                      reasion = invreq.Reasion,
                                      prepBy = invreq.PrepBy,
                                      prepDt = invreq.PrepDt,
                                      checkBy = invreq.CheckBy,
                                      checkDt = invreq.CheckDt,
                                      acceptBy = invreq.AcceptBy,
                                      acceptDt = invreq.AcceptDt
                                  });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters = accMasters.Where(x => x.orgstaffpost == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.id).Skip(skip).ToListAsync();

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
        public async Task<(string message, int id)> AddEditRequisition(RequisitionVM model)
        {
            try
            {
                var item = new InvRequisitionMast()
                {
                    Id = model.Id,
                    StockGive = model.StockGive,
                    ItemId = model.ItemId,
                    TypeId = model.TypeId,
                    Remarks = model.Remarks,
                    ReqId = model.ReqId,
                    ReqDateEng = model.ReqDateEng,
                    ReqType = model.ReqType,
                    Orgstaffpost = model.Orgstaffpost,
                    ReqByNavigation = model.ReqByNavigation,
                    PurchaseGive = model.PurchaseGive,
                    MaintainItemId = model.MaintainItemId,
                    Reasion = model.Reasion,
                    PrepBy = model.PrepBy,
                    PrepDt = model.PrepDt,
                    CheckBy = model.CheckBy,
                    CheckDt = model.CheckDt,
                    AcceptBy = model.AcceptBy,
                    AcceptDt = model.AcceptDt

                };
                if (model.Id == 0)
                {
                    int id = await _db.InvRequisitionMast.CountAsync();
                    item.Id = id + 1;
                    _db.InvRequisitionMast.Add(item);
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
        public async Task<RequisitionVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvRequisitionMast.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new RequisitionVM()
                    {
                        TypeId = response.TypeId,
                        Remarks = response.Remarks,
                        StockGive = response.StockGive,
                        ItemId = response.ItemId,
                        Id = response.Id,
                        PurchaseGive = response.PurchaseGive,
                        AcceptBy = response.AcceptBy,
                        AcceptDt = response.AcceptDt,
                        CheckBy = response.CheckBy,
                        CheckDt = response.CheckDt,
                        PrepBy = response.PrepBy,
                        PrepDt = response.PrepDt,
                        MaintainItemId = response.MaintainItemId,
                        Orgstaffpost = response.Orgstaffpost,


                    });
                }
                else
                {
                    return new RequisitionVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> Delete(int Id)
        {
            try
            {
                var response = await _db.InvRequisitionMast.Where(x => x.Id == Id).FirstOrDefaultAsync();

                if (response != null)
                {
                    _db.InvRequisitionMast.Remove(response);
                    _db.SaveChanges(true);
                    return "success";
                }

                return "fail";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
