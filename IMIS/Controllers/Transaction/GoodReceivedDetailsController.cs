using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IGoodReceivedDetails;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class GoodReceivedDetailsController : Controller
    {
        private readonly IGoodReceivedDetails _GoodReceivedDetails;

        public GoodReceivedDetailsController(IGoodReceivedDetails GoodReceivedDetails)
        {
            _GoodReceivedDetails = GoodReceivedDetails;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/GoodReceivedDetailsFetchData.html")]
        public async Task<JsonResult> GoodReceivedDetailsFetchData(DataTableVm model)
        {
            var response = await _GoodReceivedDetails.GoodReceivedDetailsFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/GoodReceivedDetailslist.html")]
        public IActionResult GoodReceivedDetailsList()
        {
            return View();
        }

        [HttpGet]
        [Route("/GoodReceivedDetailsCreate.html")]
        public IActionResult GoodReceivedDetailsCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/GoodReceivedDetailsCreate.html")]
        public async Task<IActionResult> GoodReceivedDetailsCreate(GoodReceivedDetailsVM model)
        {
            var response = await _GoodReceivedDetails.AddEditGoodReceivedDetails(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/GoodReceivedDetailslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/GoodReceivedDetailsEdit.html")]
        public async Task<IActionResult> GoodReceivedDetailsEdit(decimal id)
        {
            return View(await _GoodReceivedDetails.ViewEdit(id));
        }

        [HttpGet]
        [Route("/GoodReceivedDetailsEdit.html")]
        public async Task<IActionResult> GoodReceivedDetailsEdit(GoodReceivedDetailsVM model, int id)
        {
            var response = await _GoodReceivedDetails.AddEditGoodReceivedDetails(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/GoodReceivedDetailslist.html");
            }
            return View();
        }
    }
}