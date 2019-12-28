using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_Service.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIS_DataEntity.EntityClass;

namespace IMIS_Service.Setup.IItemBrand
{
    public interface IItemBrand
    {
        Task<DataTableResponse> ItemBrandFetchData(DataTableVm model);

        Task<(string message, int id)> AddEdit(ItemBrandVM model);

        Task<ItemBrandVM> ViewEdit(decimal braandId);
    }
    public class ItemBrand : IItemBrand
    {
        private readonly IMISDbContext _db;
        public ItemBrand(IMISDbContext db)
        {
            _db = db;
        }

        public async Task<(string message, int id)> AddEdit(ItemBrandVM model)
        {
            try
            {
                var InvBrand = new InvBrand()
                {
                   BrandId=model.BrandId,
                   NameEn=model.NameEn,
                   NameNp=model.NameNp,
                   IsActive=true
                };
                if (model.BrandId == 0)
                {
                    int count = await _db.InvBrand.CountAsync();
                    InvBrand.BrandId = count + 1;
                    await _db.AddAsync(InvBrand);
                } 
                else
                {
                    _db.Entry(InvBrand).State = EntityState.Modified;
                } 
                await _db.SaveChangesAsync();

                return ("success", 0);
            } 
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<DataTableResponse> ItemBrandFetchData(DataTableVm model)
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

                var accMasters =  (from ib in _db.InvBrand
                                        select new
                                        {
                                            ib.BrandId,
                                            ib.NameEn,
                                            ib.NameNp 
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

                var finallist = await accMasters.OrderByDescending(x => x.BrandId).Skip(skip).ToListAsync();

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

        public async Task<ItemBrandVM> ViewEdit(decimal braandId)
        {
            try
            {
                var response = await _db.InvBrand.Where(x => x.BrandId == braandId).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new ItemBrandVM()
                    {
                        BrandId = response.BrandId,
                        //IsActive = response.IsActive,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp
                    });
                }
                else
                {
                    return new ItemBrandVM();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
