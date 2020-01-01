using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.ICountryDtl;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class CountryDtlController : Controller
    {
        private readonly ICountryDtl _CountryDtl;

        public CountryDtlController(ICountryDtl CountryDtl)
        {
            _CountryDtl = CountryDtl;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/CountryDtlFetchData.html")]
        public async Task<JsonResult> CountryDtlFetchData(DataTableVm model)
        {
            var response = await _CountryDtl.CountryDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/CountryDtllist.html")]
        public IActionResult CountryDtlList()
        {
            return View();
        }

        [HttpGet]
        [Route("/CountryDtlCreate.html")]
        public IActionResult CountryDtlCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/CountryDtlCreate.html")]
        public async Task<IActionResult> CountryDtlCreate(CountryDtlVM model)
        {
            var response = await _CountryDtl.AddEditCountryDtl(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/CountryDtllist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/CountryDtlEdit.html")]
        public async Task<IActionResult> CountryDtlEdit(int id)
        {
            return View(await _CountryDtl.ViewEdit(id));
        }

        [HttpGet]
        [Route("/CountryDtlEdit.html")]
        public async Task<IActionResult> CountryDtlEdit(CountryDtlVM model, int id)
        {
            var response = await _CountryDtl.AddEditCountryDtl(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/CountryDtllist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/CountryDtlDelete.html")]
        public async Task<IActionResult> CountryDtlDelete(int brandId)
        {
            var response = await _CountryDtl.DeleteCountryDtl(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/CountryDtllist.html");
            }
            return View();
        }
    }
}