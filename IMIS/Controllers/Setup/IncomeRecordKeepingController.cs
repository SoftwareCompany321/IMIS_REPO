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
        [Route("/IncomeRecordKeepingerFetchData.html")]
        public async Task<JsonResult> IncomeRecordKeepingerFetchData(DataTableVm model)
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
        [Route("/IncomeRecordKeepingerlsit.html")]
        public IActionResult IncomeRecordKeepingerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/IncomeRecordKeepingerCreate.html")]
        public IActionResult IncomeRecordKeepingerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/IncomeRecordKeepingerCreate.html")]
        public IActionResult IncomeRecordKeepingerCreate(IncomeRecordKeepingVM model)
        {
            return View();
        }
    }
}