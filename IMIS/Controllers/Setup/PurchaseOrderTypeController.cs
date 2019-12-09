using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IPurchaseOrderType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class PurchaseOrderTypeController : Controller
    {
        private readonly IPurchaseOrderType _PurchaseOrderType;

        public PurchaseOrderTypeController(IPurchaseOrderType PurchaseOrderType)
        {
            _PurchaseOrderType = PurchaseOrderType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/PurchaseOrderTypeerFetchData.html")]
        public async Task<JsonResult> PurchaseOrderTypeerFetchData(DataTableVm model)
        {
            var response = await _PurchaseOrderType.PurchaseOrderTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/PurchaseOrderTypeerlsit.html")]
        public IActionResult PurchaseOrderTypeerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/PurchaseOrderTypeerCreate.html")]
        public IActionResult PurchaseOrderTypeerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/PurchaseOrderTypeerCreate.html")]
        public IActionResult PurchaseOrderTypeerCreate(PurchaseOrderTypeVM model)
        {
            return View();
        }
    }
}