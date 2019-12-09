using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IBankDtl;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class BankDtlController : Controller
    {
        private readonly IBankDtl _BankDtl;

        public BankDtlController(IBankDtl BankDtl)
        {
            _BankDtl = BankDtl;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/BankDtlerFetchData.html")]
        public async Task<JsonResult> BankDtlerFetchData(DataTableVm model)
        {
            var response = await _BankDtl.BankDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/BankDtlerlsit.html")]
        public IActionResult BankDtlerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/BankDtlerCreate.html")]
        public IActionResult BankDtlerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/BankDtlerCreate.html")]
        public IActionResult BankDtlerCreate(BankDtlVM model)
        {
            return View();
        }
    }
}