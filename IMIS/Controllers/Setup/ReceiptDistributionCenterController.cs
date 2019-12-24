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
        [Route("/ReceiptDistributionCenterFetchData.html")]
        public async Task<JsonResult> ReceiptDistributionCenterFetchData(DataTableVm model)
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
        [Route("/ReceiptDistributionCenterlist.html")]
        public IActionResult ReceiptDistributionCenterList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ReceiptDistributionCenterCreate.html")]
        public IActionResult ReceiptDistributionCenterCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ReceiptDistributionCenterCreate.html")]
        public async Task<IActionResult> ReceiptDistributionCenterCreate(ReceiptDistributionCenterVM model)
        {
            var response = await _ReceiptDistributionCenter.AddEditSave(model);

            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ReceiptDistributionCenterlist.html");
            }
            return View();
        }
        [HttpGet]
        [Route("{id}/ReceiptDistributionCenterEdit.html")]
        public IActionResult ReceiptDistributionCenterEdit(int id)
        {
            return View(_ReceiptDistributionCenter.ViewEdit(id));
        }
        [HttpPost]
        [Route("/ReceiptDistributionCenterEdit.html")]
        public async Task<IActionResult> ReceiptDistributionCenterEdit(ReceiptDistributionCenterVM model)
        {
            var response = await _ReceiptDistributionCenter.AddEditSave(model);

            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ReceiptDistributionCenterlist.html");
            }
            return View();
        }
    }
}