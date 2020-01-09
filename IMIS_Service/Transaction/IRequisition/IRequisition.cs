﻿using IMIS_CORE.Utility;
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
                                      code = invreq.Code,
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
                    ItemId = model.ItemId ?? 0,
                    TypeId = model.TypeId ?? 0,
                    Remarks = model.Remarks,
                    ReqId = model.ReqId,
                    ReqDateEng = model.ReqDateEng,
                    ReqType = model.ReqType,
                    Orgstaffpost = model.Orgstaffpost,
                    // ReqByNavigation = model.ReqByNavigation,
                    PurchaseGive = model.PurchaseGive,
                    MaintainItemId = model.MaintainItemId,
                    Reasion = model.Reasion,
                    PrepBy = model.PrepBy,
                    PrepDt = model.PrepDt,
                    CheckBy = model.CheckBy,
                    CheckDt = model.CheckDt,
                    AcceptBy = model.AcceptBy,
                    AcceptDt = model.AcceptDt,
                    PrepByNavigation = new PisEmployeeMaster
                    {
                        EmpId = model.PrepBy ?? 0
                    },
                    CheckByNavigation = new PisEmployeeMaster
                    {
                        EmpId = model.CheckBy ?? 0
                    },
                    AcceptByNavigation = new PisEmployeeMaster
                    {
                        EmpId = model.AcceptBy ?? 0
                    },
                    ReqByNavigation = new PisEmployeeMaster
                    {
                        EmpId = model.ReqBy ?? 0
                    },
                    Proj = new InvProject
                    {
                        ProjectId = model.ProjId ?? 0,
                        NameNp = "test"
                    },
                    Item = new InvItemMst
                    {
                        ItemId = model.ItemId ?? 0,
                        NameNp = "test"
                    },

                };
                if (model.Id == 0)
                {
                    int id = await _db.InvRequisitionMast.CountAsync();
                    item.Id = id + 1;
                    _db.InvRequisitionMast.Add(item);

                    var invreq = new InvReqDetail
                    {

                        Brand = model.InvReqDetail.Brand,
                        Item = model.Item,
                        BrandId = model.InvReqDetail.BrandId,
                        ItemId = model.ItemId ?? 0,
                        Remarks = model.InvReqDetail.Remarks,
                        Qty = model.InvReqDetail.Qty,
                        ReqMast = model.InvReqDetail.ReqMast,
                        Spec = model.InvReqDetail.Spec,
                        ReqMastId = model.InvReqDetail.ReqMastId,
                        SpecId = model.InvReqDetail.SpecId,
                        IsActive = model.InvReqDetail.IsActive,
                        Code = model.InvReqDetail.Code,
                        Id = item.Id
                    };
                    _db.InvReqDetail.Add(invreq);
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
                        ReqId = response.ReqId,
                        ReqDateEng = response.ReqDateEng,
                        ReqType = response.ReqType,



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