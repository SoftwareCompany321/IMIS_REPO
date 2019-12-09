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
        [Route("/ReceiptDistributionerFetchData.html")]
        public async Task<JsonResult> ReceiptDistributionerFetchData(DataTableVm model)
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
        [Route("/ReceiptDistributionerlsit.html")]
        public IActionResult ReceiptDistributionerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ReceiptDistributionerCreate.html")]
        public IActionResult ReceiptDistributionerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ReceiptDistributionerCreate.html")]
        public IActionResult ReceiptDistributionerCreate(ReceiptDistributionVM model)
        {
            return View();
        }
    }
}