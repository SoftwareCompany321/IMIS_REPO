
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

namespace IMIS_Service.Setup.IItemMaster
{
    public interface IItemMaster
    {
        Task<DataTableResponse> ItemMasterFetchData(DataTableVm model);

        Task<(string message, int Id)> AddEditSave(ItemMasterVM model);
        Task<ItemMasterVM> ViewEdit(int Id);
    }
    public class ItemMaster : IItemMaster
    {
        private readonly IMISDbContext _db;
        private readonly IMapper _mapper;
        public ItemMaster(IMISDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<(string message, int Id)> AddEditSave(ItemMasterVM model)
        {
            try
            {

                //var item = new InvItemMst()
                //{
                //    AccId = model.AccId,
                //    AreaInsqFeets = model.AreaInsqFeets,
                //    BudgetAccId = model.BudgetAccId,
                //    Code = model.Code,
                //    Companyname = model.Companyname,
                //    Constructontype = model.Constructontype,
                //    Countryid = model.Countryid,
                //    Depmaxrate = model.Depmaxrate,
                //    Depreciation = model.Depreciation,
                //    Gussage = model.Gussage,
                //    Remarks = model.Remarks,
                //    Sizes = model.Sizes,
                //    Source = model.Source,
                //    ItemId = model.ItemId,
                //    ItemMainClass = model.ItemMainClass,
                //    ItemNature = model.ItemNature,
                //    KittaNo = model.KittaNo,
                //    ItemType = model.ItemType,
                //    Landid = model.Landid,
                //    LandAreaInsqFeets = model.LandAreaInsqFeets,
                //    LandLocation = model.LandLocation,
                //    LandMarketRate = model.LandMarketRate,
                //    LandUnitRate = model.LandUnitRate,
                //    Maxl = model.Maxl,
                //    Minl = model.Minl,
                //    Minrate = model.Minrate,
                //    NameEn = model.NameEn,
                //    NameNp = model.NameNp,
                //    Propertytype = model.Propertytype,
                //    Rmaxl = model.Rmaxl,
                //    Rminl = model.Rminl,
                //    UnitId = model.UnitId,
                //    VehiclePartsId = model.VehiclePartsId
                //};

                var item = _mapper.Map<InvItemMst>(model);
                if (model.AccId == 0)
                {
                    await _db.AddAsync(item);
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

        public async Task<DataTableResponse> ItemMasterFetchData(DataTableVm model)
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

                var accMasters = (from iim in _db.InvItemMst
                                  select new
                                  {
                                      iim.ItemId,
                                      iim.NameEn,
                                      iim.NameNp
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

                var finallist = await accMasters.OrderByDescending(x => x.ItemId).Skip(skip).ToListAsync();

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

        public async Task<ItemMasterVM> ViewEdit(int Id)
        {
            try
            {
                var response = await _db.InvItemMst.Where(x => x.AccId == Id).FirstOrDefaultAsync();

                if (response != null)
                {
                    return _mapper.Map<ItemMasterVM>(response);
                }
                return new ItemMasterVM(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
