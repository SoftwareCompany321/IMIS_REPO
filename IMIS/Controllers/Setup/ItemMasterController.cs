using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemMaster;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemMasterController : Controller
    {
        private readonly IItemMaster _ItemMaster;

        public ItemMasterController(IItemMaster ItemMaster)
        {
            _ItemMaster = ItemMaster;
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
            return View();
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
            return View();
        }

        [HttpGet]
        [Route("/{Id}/ItemMasterCreate.html")]
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
            return View();
        }
    }
}