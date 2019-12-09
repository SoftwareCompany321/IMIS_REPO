using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IReceiptDistributionCenter;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ReceiptDistributionCenterController : Controller
    {
        private readonly IReceiptDistributionCenter _ReceiptDistributionCenter;

        public ReceiptDistributionCenterController(IReceiptDistributionCenter ReceiptDistributionCenter)
        {
            _ReceiptDistributionCenter = ReceiptDistributionCenter;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ReceiptDistributionCentererFetchData.html")]
        public async Task<JsonResult> ReceiptDistributionCentererFetchData(DataTableVm model)
        {
            var response = await _ReceiptDistributionCenter.ReceiptDistributionCenterFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ReceiptDistributionCentererlsit.html")]
        public IActionResult ReceiptDistributionCentererList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ReceiptDistributionCentererCreate.html")]
        public IActionResult ReceiptDistributionCentererCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ReceiptDistributionCentererCreate.html")]
        public IActionResult ReceiptDistributionCentererCreate(ReceiptDistributionCenterVM model)
        {
            return View();
        }
    }
}