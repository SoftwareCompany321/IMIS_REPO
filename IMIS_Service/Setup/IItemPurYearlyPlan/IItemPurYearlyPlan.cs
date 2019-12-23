using AutoMapper;
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

namespace IMIS_Service.Setup.IItemPurYearlyPlan
{
    public interface IItemPurYearlyPlan
    {
        Task<DataTableResponse> ItemPurYearlyPlanFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditItemPurYearlyPlan(ItemPurYearlyPlanVM model);

        Task<ItemPurYearlyPlanVM> ViewEdit(int Id);
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

                //if (model != null)
                //{
                //    searchBy = searchBy = !string.IsNullOrEmpty(model.search) ? model.search.Trim() : "";
                //    take = model.length;
                //    skip = model.start;
                //    draw = model.draw;
                //}

                //var accMasters = (from iypp in _db.InvYrlyPurPlan
                //                  select new
                //                  {
                //                      iypp.Id,
                //                      iypp.NameEn,
                //                      iypp.NameNp
                //                  });
                /////filter count for the total; record
                /////

                //if (accMasters != null)
                //{
                //    totalResultsCount = await accMasters.CountAsync();
                //    if (!string.IsNullOrEmpty(searchBy))
                //    {
                //        accMasters = accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
                //    }
                //    filteredResultsCount = await accMasters.CountAsync();
                //}

                //var finallist = await accMasters.OrderByDescending(x => x.Id).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = ""
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

                //var item = _mapper.Map<InvYrlyPurPlan>(model);
                //if (model.Id == 0)
                //{
                //    int id = await _db.InvYrlyPurPlan.CountAsync();
                //    item.Id = id + 1;
                //    _db.InvYrlyPurPlan.AddRange(item);
                //}
                //else
                //{
                //    _db.Entry(item).State = EntityState.Modified;
                //}
                //await _db.SaveChangesAsync(true);

                return ("success", 0);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<ItemPurYearlyPlanVM> ViewEdit(int Id)
        {
            try
            {
                var response = ""; //await _db.InvYrlyPurPlan.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (_mapper.Map<ItemPurYearlyPlanVM>(response));
                    //return (new ItemPurYearlyPlanVM()
                    //{
                    //    Id = response.Id,
                    //    NameEn = response.NameEn,
                    //    NameNp = response.NameNp

                    //});
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
    }
}
