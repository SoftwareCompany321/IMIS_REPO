﻿using IMIS_CORE.Utility;
using IMIS_Service.GlobalFunction;
using IMIS_Service.Setup.IItemMaster;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IMIS.Controllers.Setup
{
    public class ItemMasterController : Controller
    {
        private readonly IItemMaster _ItemMaster;
        private readonly GlobalFunction _global;
        public ItemMasterController(IItemMaster ItemMaster,  GlobalFunction global)
        {
            _ItemMaster = ItemMaster;
            _global = global;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemMasterFetchData.html")]
        public async Task<JsonResult> ItemMasterFetchData(DataTableVm model)
        {
            var response = await _ItemMaster.ItemMasterFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemMasterlist.html")]
        public IActionResult ItemMasterList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemMasterCreate.html")]
        public IActionResult ItemMasterCreate()
        {
            ItemMasterVM model = new ItemMasterVM();
            model.landdesc = _ItemMaster.InvUntList();
            model.fuelmaintenance  = _ItemMaster.FuelMaintenanceDtl();
            model.unitlist  = _global.UnitList();
            model.ItemCategorylist  = _global.ItemCategroyList();
            model.ItemSubCategoryList  = _global.ItemSubCategroyList(0);
            model.ItemNatureList = _global.OthersetupList(2);
            model.CountryList  = _global.CountryList();
            return View(model);
        }

        [HttpPost]
        [Route("/ItemMasterCreate.html")]
        public async Task<IActionResult> ItemMasterCreate(ItemMasterVM model)
        {
            var response = await _ItemMaster.AddEditSave(model);
     
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemMasterlist.html");
            }
            model.landdesc = _ItemMaster.InvUntList();
            model.fuelmaintenance = _ItemMaster.FuelMaintenanceDtl();
            model.unitlist = _global.UnitList();
            model.ItemCategorylist = _global.ItemCategroyList();
            model.ItemSubCategoryList = _global.ItemSubCategroyList(0);
            model.ItemNatureList = _global.OthersetupList(2);
            model.CountryList = _global.CountryList();

            return View();
        }

        [HttpGet]
        [Route("/{Id}/ItemMasterEdit.html")]
        public async Task<IActionResult> ItemMasterEdit(int Id)
        { 
           
            return View(await _ItemMaster.ViewEdit(Id));
        }

        [HttpPost]
        [Route("ItemMasterEdit.html")]
        public async Task<IActionResult> ItemMasterEdit(ItemMasterVM model, int Id)
        {
            var response = await _ItemMaster.AddEditSave(model);
            
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemMasterlist.html");
            }
            model.landdesc = _ItemMaster.InvUntList();
            model.fuelmaintenance = _ItemMaster.FuelMaintenanceDtl();
            model.unitlist = _global.UnitList();
            model.ItemCategorylist = _global.ItemCategroyList();
            model.ItemSubCategoryList = _global.ItemSubCategroyList(0);
            model.ItemNatureList = _global.OthersetupList(2);
            model.CountryList = _global.CountryList();

            return View();
        }

        [HttpGet]
        [Route("{brandId}/ItemMasterDelete.html")]
        public async Task<IActionResult> ItemMasterDelete(int brandId)
        {
            var response = await _ItemMaster.DeleteItemMaster(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemMasterlist.html");
            }
            return View();
        }
    }
}