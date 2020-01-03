using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IStockDetails;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class StockDetailsController : Controller
    {
        private readonly IStockDetails _StockDetails;

        public StockDetailsController(IStockDetails StockDetails)
        {
            _StockDetails = StockDetails;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/StockDetailsFetchData.html")]
        public async Task<JsonResult> StockDetailsFetchData(DataTableVm model)
        {
            var response = await _StockDetails.StockDetailsFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/StockDetailslist.html")]
        public IActionResult StockDetailsList()
        {
            return View();
        }

        [HttpGet]
        [Route("/StockDetailsCreate.html")]
        public IActionResult StockDetailsCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/StockDetailsCreate.html")]
        public async Task<IActionResult> StockDetailsCreate(StockDetailsVM model)
        {
            var response = await _StockDetails.AddEditStockDetails(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/StockDetailslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/StockDetailsEdit.html")]
        public async Task<IActionResult> StockDetailsEdit(decimal id)
        {
            return View(await _StockDetails.ViewEdit(id));
        }

        [HttpGet]
        [Route("/StockDetailsEdit.html")]
        public async Task<IActionResult> StockDetailsEdit(StockDetailsVM model, int id)
        {
            var response = await _StockDetails.AddEditStockDetails(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/StockDetailslist.html");
            }
            return View();
        }
    }
}