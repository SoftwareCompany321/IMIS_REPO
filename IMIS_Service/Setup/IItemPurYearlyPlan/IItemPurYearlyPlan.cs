using AutoMapper;
using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IItemPurYearlyPlan
{
    public interface IItemPurYearlyPlan
    {
        Task<DataTableResponse> ItemPurYearlyPlanFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditItemPurYearlyPlan(ItemPurYearlyPlanVM model);
        Task<ItemPurYearlyPlanVM> ViewEdit(int Id);
        Task<IEnumerable<SelectListItem>> InVPurType();
    }
    public class ItemPurYearlyPlan : IItemPurYearlyPlan
    {
        private readonly IMISDbContext _db;
        private readonly IMapper _mapper;
        public ItemPurYearlyPlan(IMISDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<DataTableResponse> ItemPurYearlyPlanFetchData(DataTableVm model)
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

                var accMasters = (from iypp in _db.InvYrlyPurPlan
                                  select new
                                  {
                                      iypp.Id,
                                      iypp.NameEn,
                                      iypp.NameNp,
                                      iypp.ApproxAmt,
                                      iypp.AgreementType,
                                      iypp.PurType,
                                      iypp.AnlysisDsgnDtAd,
                                      iypp.WrkAcmplshDate
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

                var finallist = await accMasters.OrderByDescending(x => x.Id).Skip(skip).ToListAsync();

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
        public async Task<(string message, int id)> AddEditItemPurYearlyPlan(ItemPurYearlyPlanVM model)
        {
            try
            {
                var item = new InvYrlyPurPlan()
                {
                    Id=model.Id,
                    NameEn=model.NameEn,
                    NameNp=model.NameNp,
                    TendrSaleDate=model.TendrSaleDate,
                    AgreementType=model.AgreementType,
                    ApproxAmt=model.ApproxAmt,
                    FormEntryDate=model.FormEntryDate,
                    InfoPublishDate=model.InfoPublishDate,
                    PurType=model.PurType,
                    TendrAcceptDate=model.TendrAcceptDate,
                    AprxAmtAcptDate=model.AprxAmtAcptDate,
                    WrkAcmplshDate=model.WrkAcmplshDate,
                    TendrOpenDate=model.TendrOpenDate,
                    WrkOrderDate=model.WrkOrderDate,
                };



               // var item = _mapper.Map<InvYrlyPurPlan>(model);
                if (model.Id == 0)
                {
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
        public async Task<ItemPurYearlyPlanVM> ViewEdit(int Id)
        {
            try
            {
                var response = await _db.InvYrlyPurPlan.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                   // return (_mapper.Map<ItemPurYearlyPlanVM>(response));
                    return (new ItemPurYearlyPlanVM()
                    {
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,
                        TendrSaleDate = response.TendrSaleDate,
                        AgreementType = response.AgreementType,
                        ApproxAmt = response.ApproxAmt,
                        FormEntryDate = response.FormEntryDate,
                        InfoPublishDate = response.InfoPublishDate,
                        PurType = response.PurType,
                        TendrAcceptDate = response.TendrAcceptDate,
                        AprxAmtAcptDate = response.AprxAmtAcptDate,
                        WrkAcmplshDate = response.WrkAcmplshDate,
                        TendrOpenDate = response.TendrOpenDate,
                        WrkOrderDate = response.WrkOrderDate,

                    });
                }
                else
                {
                    return new ItemPurYearlyPlanVM();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<SelectListItem>> InVPurType()
        {
            return new SelectList(await _db.InvPurType.ToListAsync(), "Id", "NepName");
        }

    }
}
