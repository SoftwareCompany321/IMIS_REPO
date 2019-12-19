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

namespace IMIS_Service.Setup.IItemPurchaseType
{
    public interface IItemPurchaseType
    {
        Task<DataTableResponse> ItemPurchaseTypeFetchData(DataTableVm model);

        Task<(string message, int id)> AddEditSave(ItemPurchaseTypeVM model);

        Task<ItemPurchaseTypeVM> ViewEdit(int id);
    }
    public class ItemPurchaseType : IItemPurchaseType
    {
        private readonly IMISDbContext _db;
        public ItemPurchaseType(IMISDbContext db)
        {
            _db = db;
        }

        public async Task<(string message, int id)> AddEditSave(ItemPurchaseTypeVM model)
        {
            try
            {
                var item = new InvPurType()
                {
                    Id = model.Id,
                    NepEng = model.NepEng,
                    NepName = model.NepName,
                    Isdefault = model.Isdefault,
                    Remarks = model.Remarks
                };
                if (model.Id == 0)
                {
                    await _db.AddAsync(item);
                }
                else
                {
                    _db.Entry(item).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);

                return ("", 0);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DataTableResponse> ItemPurchaseTypeFetchData(DataTableVm model)
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
                var accMasters = (from ipt in _db.InvPurType
                                  select new
                                  {
                                      ipt.Id,
                                      ipt.NepEng,
                                      ipt.NepName
                                  });
                ///filter count for the total; record
                ///
                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters = accMasters.Where(x => x.NepName == searchBy || x.NepEng == searchBy);
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

        public async Task<ItemPurchaseTypeVM> ViewEdit(int id)
        {
            try
            {
                var response = await _db.InvPurType.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (response != null)
                {
                    return (new ItemPurchaseTypeVM()
                    {
                        NepEng=response.NepEng,
                        NepName=response.NepName,
                        Remarks=response.Remarks,
                        Isdefault=response.Isdefault
                    });
                }
                else
                {
                    return new ItemPurchaseTypeVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
