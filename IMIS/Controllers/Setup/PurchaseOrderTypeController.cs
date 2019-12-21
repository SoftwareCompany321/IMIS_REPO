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
        [Route("/PurchaseOrderTypeFetchData.html")]
        public async Task<JsonResult> PurchaseOrderTypeFetchData(DataTableVm model)
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
        [Route("/PurchaseOrderTypelist.html")]
        public IActionResult PurchaseOrderTypeList()
        {
            return View();
        }

        [HttpGet]
        [Route("/PurchaseOrderTypeCreate.html")]
        public IActionResult PurchaseOrderTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/PurchaseOrderTypeCreate.html")]
        public async Task<IActionResult> PurchaseOrderTypeCreate(PurchaseOrderTypeVM model)
        {
            var response = await _PurchaseOrderType.AddEditPurchaseOrderType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/PurchaseOrderTypelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/PurchaseOrderTypeEdit.html")]
        public async Task<IActionResult> PurchaseOrderTypeEdit(decimal id)
        {
            return View(await _PurchaseOrderType.ViewEdit(id));
        }

        [HttpGet]
        [Route("/PurchaseOrderTypeEdit.html")]
        public async Task<IActionResult> PurchaseOrderTypeEdit(PurchaseOrderTypeVM model, int id)
        {
            var response = await _PurchaseOrderType.AddEditPurchaseOrderType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/PurchaseOrderTypelist.html");
            }
            return View();
        }
    }
}