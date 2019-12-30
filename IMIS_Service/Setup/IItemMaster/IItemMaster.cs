
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
using IMIS_CORE.Core;

namespace IMIS_Service.Setup.IItemMaster
{
    public interface IItemMaster
    {
        Task<DataTableResponse> ItemMasterFetchData(DataTableVm model);
        Task<(string message, int Id)> AddEditSave(ItemMasterVM model);
        Task<ItemMasterVM> ViewEdit(int Id);
        List<SelectListItem> InvUntList();
        List<SelectListItem> FuelMaintenanceDtl();
        List<SelectListItem> UnitList();
        List<SelectListItem> ItemCategroyList();
        List<SelectListItem> ItemSubCategroyList(int id);
        List<SelectListItem> OthersetupList();
        List<SelectListItem> CountryList();
    }
    public class ItemMaster : IItemMaster
    {
        private readonly IMISDbContext _db;
        private readonly IMapper _mapper;
        public ItemMaster(IMISDbContext db, IMapper mapper)
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

        public List<SelectListItem> InvUntList()
        {
            var landlist = new List<SelectListItem>();

            var list = (from itemmaster in _db.InvItemMst
                        join invunt in _db.InvUnit on itemmaster.UnitId equals invunt.UnitId into leftjoin
                        from leftunit in leftjoin.DefaultIfEmpty()
                        join invcat in _db.InvItemCategory on itemmaster.ItemType equals invcat.Id into leftjoincat
                        from leftcat in leftjoincat.DefaultIfEmpty()
                        select new { Id = itemmaster.ItemId, Text = itemmaster.Code + ' ' + itemmaster.NameEn + ' ' + leftcat.NameEn + ' ' + leftunit.DescEn }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    landlist.Add(selectListItem);
                }
            }
            return landlist;
        }
        public List<SelectListItem> CountryList()
        {
            var fuellist = new List<SelectListItem>();

            var list = (from nt in _db.Nationalities
                        select new { Id = nt.Code, Text = Utils.ToggleLanguage(nt.Engname, nt.Nepname) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    fuellist.Add(selectListItem);
                }
            }
            return fuellist;
        }
        public List<SelectListItem> FuelMaintenanceDtl()
        {
            var fuellist = new List<SelectListItem>();

            var list = (from fuel in _db.TblVehicleParts
                        select new { Id = fuel.Sn, Text = Utils.ToggleLanguage(fuel.EngName, fuel.NpName) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    fuellist.Add(selectListItem);
                }
            }
            return fuellist;
        }
        public List<SelectListItem> OthersetupList()
        {
            var unitlist = new List<SelectListItem>();

            var list = (from its in _db.InvTypeSetup
                        select new { Id = its.Id, Text = Utils.ToggleLanguage(its.DescEn, its.DescNp) }).ToList();
            if (unitlist.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }
        public List<SelectListItem> UnitList()
        {
            var unitlist = new List<SelectListItem>();

            var list = (from unit in _db.InvUnit
                        select new { Id = unit.UnitId, Text = Utils.ToggleLanguage(unit.DescEn, unit.DescNp) }).ToList();
            if (unitlist.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }
        public List<SelectListItem> ItemCategroyList()
        {
            var unitlist = new List<SelectListItem>();

            var list = (from ivt in _db.InvItemCategory
                        select new { Id = ivt.Id, Text = Utils.ToggleLanguage(ivt.NameEn, ivt.NameNp) }).ToList();
            if (unitlist.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }
        public List<SelectListItem> ItemSubCategroyList(int id = 0)
        {
            var unitlist = new List<SelectListItem>();

            var list = (from ivt in _db.InvItemCategory
                        where ivt.ParentId == id
                        select new { Id = ivt.Id, Text = Utils.ToggleLanguage(ivt.NameEn, ivt.NameNp) }).ToList();
            if (unitlist.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
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
                                  {   iim.Code,
                                      iim.ItemId,
                                      iim.NameEn,
                                      iim.NameNp,
                                      iim.Companyname,
                                      iim.Unit,
                                      iim.ItemMainClass,
                                      iim.ItemNature,
                                      iim.KittaNo,
                                      iim.Countryid,
                                      iim.Maxl,
                                      iim.Minl,
                                      iim.Minrate,
                                      iim.Depmaxrate,
                                      iim.Depreciation,
                                      iim.AccId,
                                      iim.Constructontype,
                                      iim.Landid,
                                      iim.LandUnitRate,
                                      iim.Propertytype,
                                      iim.Source,
                                      iim.VehiclePartsId.HasValue,
                                      iim.ItemType,
                                      iim.Rmaxl,
                                      iim.Rminl,
                                      iim.LandAreaInsqFeets,
                                      iim.LandLocation,
                                      iim.Remarks
                                     
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
                    ItemMasterVM vm = _mapper.Map<ItemMasterVM>(response);
                    vm.landdesc = InvUntList();
                    vm.fuelmaintenance = FuelMaintenanceDtl();
                    vm.unitlist = UnitList();
                    vm.ItemCategorylist = ItemCategroyList();
                    vm.ItemSubCategoryList = ItemSubCategroyList(0);
                    vm.othsetuplist = OthersetupList();
                    vm.CountryList = CountryList();
                    return vm;
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
