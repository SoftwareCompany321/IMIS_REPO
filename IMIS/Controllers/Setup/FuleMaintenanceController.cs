using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IFuelMaintenance;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class FuelMaintenanceController : Controller
    {
        private readonly IFuelMaintenance _FuelMaintenance;

        public FuelMaintenanceController(IFuelMaintenance FuelMaintenance)
        {
            _FuelMaintenance = FuelMaintenance;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/FuelMaintenanceFetchData.html")]
        public async Task<JsonResult> FuelMaintenanceFetchData(DataTableVm model)
        {
            var response = await _FuelMaintenance.FuelMaintenanceFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/FuelMaintenancelist.html")]
        public IActionResult FuelMaintenanceList()
        {
            return View();
        }

        [HttpGet]
        [Route("/FuelMaintenanceCreate.html")]
        public IActionResult FuelMaintenanceCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/FuelMaintenanceCreate.html")]
        public async Task<IActionResult> FuelMaintenanceCreate(FuelMaintenanceVM model)
        {
            var response = await _FuelMaintenance.AddEditFuelMaintenance(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/FuelMaintenancelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/FuelMaintenanceEdit.html")]
        public async Task<IActionResult> FuelMaintenanceEdit(int id)
        {
            return View(await _FuelMaintenance.ViewEdit(id));
        }

        [HttpGet]
        [Route("/FuelMaintenanceEdit.html")]
        public async Task<IActionResult> FuelMaintenanceEdit(FuelMaintenanceVM model, int id)
        {
            var response = await _FuelMaintenance.AddEditFuelMaintenance(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/FuelMaintenancelist.html");
            }
            return View();
        }
        [HttpGet]
        [Route("/{id}/FuelMaintenanceDelete.html")]
        public async Task<IActionResult> FuelMaintenanceDelete(int id)
        {
            var response = await _FuelMaintenance.Delete(id);
            if (response == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/FuelMaintenancelist.html");
            }
            return View();
        }
    }
}