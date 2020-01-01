using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.ITaxRate;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class TaxRateController : Controller
    {
        private readonly ITaxRate _TaxRate;

        public TaxRateController(ITaxRate TaxRate)
        {
            _TaxRate = TaxRate;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/TaxRateFetchData.html")]
        public async Task<JsonResult> TaxRateFetchData(DataTableVm model)
        {
            var response = await _TaxRate.TaxRateFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/TaxRatelist.html")]
        public IActionResult TaxRateList()
        {
            return View();
        }

        [HttpGet]
        [Route("/TaxRateCreate.html")]
        public IActionResult TaxRateCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/TaxRateCreate.html")]
        public async Task<IActionResult> TaxRateCreate(TaxRateVM model)
        {
            var response = await _TaxRate.AddEditTaxRate(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/TaxRatelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/TaxRateEdit.html")]
        public async Task<IActionResult> TaxRateEdit(decimal id)
        {
            return View(await _TaxRate.ViewEdit(id));
        }

        [HttpGet]
        [Route("/TaxRateEdit.html")]
        public async Task<IActionResult> TaxRateEdit(TaxRateVM model, int id)
        {
            var response = await _TaxRate.AddEditTaxRate(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/TaxRatelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/TaxRateDelete.html")]
        public async Task<IActionResult> TaxRateDelete(int brandId)
        {
            var response = await _TaxRate.DeleteTaxRate(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/TaxRatelist.html");
            }
            return View();
        }
    }
}