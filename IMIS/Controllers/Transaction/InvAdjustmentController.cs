using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IInvAdjustment;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class InvAdjustmentController : Controller
    {
        private readonly IInvAdjustment _InvAdjustment;

        public InvAdjustmentController(IInvAdjustment InvAdjustment)
        {
            _InvAdjustment = InvAdjustment;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/InvAdjustmentFetchData.html")]
        public async Task<JsonResult> InvAdjustmentFetchData(DataTableVm model)
        {
            var response = await _InvAdjustment.InvAdjustmentFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/InvAdjustmentlist.html")]
        public IActionResult InvAdjustmentList()
        {
            return View();
        }

        [HttpGet]
        [Route("/InvAdjustmentCreate.html")]
        public IActionResult InvAdjustmentCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/InvAdjustmentCreate.html")]
        public async Task<IActionResult> InvAdjustmentCreate(InvAdjustmentVM model)
        {
            var response = await _InvAdjustment.AddEditInvAdjustment(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/InvAdjustmentlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/InvAdjustmentEdit.html")]
        public async Task<IActionResult> InvAdjustmentEdit(decimal id)
        {
            return View(await _InvAdjustment.ViewEdit(id));
        }

        [HttpGet]
        [Route("/InvAdjustmentEdit.html")]
        public async Task<IActionResult> InvAdjustmentEdit(InvAdjustmentVM model, int id)
        {
            var response = await _InvAdjustment.AddEditInvAdjustment(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/InvAdjustmentlist.html");
            }
            return View();
        }
    }
}