using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IIncomeRecordKeeping;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class IncomeRecordKeepingController : Controller
    {
        private readonly IIncomeRecordKeeping _IncomeRecordKeeping;

        public IncomeRecordKeepingController(IIncomeRecordKeeping IncomeRecordKeeping)
        {
            _IncomeRecordKeeping = IncomeRecordKeeping;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/IncomeRecordKeepingFetchData.html")]
        public async Task<JsonResult> IncomeRecordKeepingFetchData(DataTableVm model)
        {
            var response = await _IncomeRecordKeeping.IncomeRecordKeepingFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/IncomeRecordKeepinglist.html")]
        public IActionResult IncomeRecordKeepingList()
        {
            return View();
        }

        [HttpGet]
        [Route("/IncomeRecordKeepingCreate.html")]
        public IActionResult IncomeRecordKeepingCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/IncomeRecordKeepingCreate.html")]
        public IActionResult IncomeRecordKeepingCreate(IncomeRecordKeepingVM model)
        {
            return View();
        }
    }
}