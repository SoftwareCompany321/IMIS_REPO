using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IReceiptDistribution;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ReceiptDistributionController : Controller
    {
        private readonly IReceiptDistribution _ReceiptDistribution;

        public ReceiptDistributionController(IReceiptDistribution ReceiptDistribution)
        {
            _ReceiptDistribution = ReceiptDistribution;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ReceiptDistributionFetchData.html")]
        public async Task<JsonResult> ReceiptDistributionFetchData(DataTableVm model)
        {
            var response = await _ReceiptDistribution.ReceiptDistributionFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ReceiptDistributionlist.html")]
        public IActionResult ReceiptDistributionList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ReceiptDistributionCreate.html")]
        public IActionResult ReceiptDistributionCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ReceiptDistributionCreate.html")]
        public IActionResult ReceiptDistributionCreate(ReceiptDistributionVM model)
        {
            return View();
        }
    }
}