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
    public class BankEntryController : Controller
    {
        private readonly IBankDtl _BankEntry;

        public BankEntryController(IBankDtl BankEntry)
        {
            _BankEntry = BankEntry;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/BankEntryerFetchData.html")]
        public async Task<JsonResult> BankEntryerFetchData(DataTableVm model)
        {
            var response = await _BankEntry.BankDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/BankEntryerlsit.html")]
        public IActionResult BankEntryerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/BankEntryerCreate.html")]
        public IActionResult BankEntryerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/BankEntryerCreate.html")]
        public IActionResult BankEntryerCreate(BankDtlVM model)
        {
            return View();
        }
    }
}