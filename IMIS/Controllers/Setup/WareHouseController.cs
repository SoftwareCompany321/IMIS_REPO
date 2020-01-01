using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IWareHouse;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class WareHouseController : Controller
    {
        private readonly IWareHouse _WareHouse;

        public WareHouseController(IWareHouse WareHouse)
        {
            _WareHouse = WareHouse;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/WareHouseFetchData.html")]
        public async Task<JsonResult> WareHouseFetchData(DataTableVm model)
        {
            var response = await _WareHouse.WareHouseFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/WareHouselist.html")]
        public IActionResult WareHouseList()
        {
            return View();
        }

        [HttpGet]
        [Route("/WareHouseCreate.html")]
        public IActionResult WareHouseCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/WareHouseCreate.html")]
        public async Task<IActionResult> WareHouseCreate(WareHouseVM model)
        {
            var response = await _WareHouse.AddEditWareHouse(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/WareHouselist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/WareHouseEdit.html")]
        public async Task<IActionResult> WareHouseEdit(decimal id)
        {
            return View(await _WareHouse.ViewEdit(id));
        }

        [HttpGet]
        [Route("/WareHouseEdit.html")]
        public async Task<IActionResult> WareHouseEdit(WareHouseVM model, int id)
        {
            var response = await _WareHouse.AddEditWareHouse(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/WareHouselist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{id}/WareHouseDelete.html")]
        public async Task<IActionResult> WareHouseDelete(int id)
        {
            var response = await _WareHouse.DeleteWareHouse(id);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/WareHouselist.html");
            }
            return View();
        }
    }
}