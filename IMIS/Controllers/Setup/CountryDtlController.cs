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
        [Route("/CountryDtlerFetchData.html")]
        public async Task<JsonResult> CountryDtlerFetchData(DataTableVm model)
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
        [Route("/CountryDtlerlsit.html")]
        public IActionResult CountryDtlerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/CountryDtlerCreate.html")]
        public IActionResult CountryDtlerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/CountryDtlerCreate.html")]
        public IActionResult CountryDtlerCreate(CountryDtlVM model)
        {
            return View();
        }
    }
}