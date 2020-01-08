using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IPurchaseDetails;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class PurchaseDetailsController : Controller
    {
        private readonly IPurchaseDetails _PurchaseDetails;

        public PurchaseDetailsController(IPurchaseDetails PurchaseDetails)
        {
            _PurchaseDetails = PurchaseDetails;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/PurchaseDetailsFetchData.html")]
        public async Task<JsonResult> PurchaseDetailsFetchData(DataTableVm model)
        {
            var response = await _PurchaseDetails.PurchaseDetailsFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/PurchaseDetailList.html")]
        public IActionResult PurchaseDetailsList()
        {
            return View();
        }

        [HttpGet]
        [Route("/PurchaseDetailsCreate.html")]
        public IActionResult PurchaseDetailsCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/PurchaseDetailsCreate.html")]
        public async Task<IActionResult> PurchaseDetailsCreate(PurchaseDetailsVM model)
        {
            var response = await _PurchaseDetails.AddEditPurchaseDetails(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/PurchaseDetailslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/PurchaseDetailsEdit.html")]
        public async Task<IActionResult> PurchaseDetailsEdit(decimal id)
        {
            return View(await _PurchaseDetails.ViewEdit(id));
        }

        [HttpGet]
        [Route("/PurchaseDetailsEdit.html")]
        public async Task<IActionResult> PurchaseDetailsEdit(PurchaseDetailsVM model, int id)
        {
            var response = await _PurchaseDetails.AddEditPurchaseDetails(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/PurchaseDetailslist.html");
            }
            return View();
        }
    }
}