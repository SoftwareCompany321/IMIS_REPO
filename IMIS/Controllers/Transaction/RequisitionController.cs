using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IRequisition;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class RequisitionController : Controller
    {
        private readonly IRequisition _Requisition;

        public RequisitionController(IRequisition Requisition)
        {
            _Requisition = Requisition;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/RequisitionFetchData.html")]
        public async Task<JsonResult> RequisitionFetchData(DataTableVm model)
        {
            var response = await _Requisition.RequisitionFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/Requisitionlist.html")]
        public IActionResult RequisitionList()
        {
            return View();
        }

        [HttpGet]
        [Route("/RequisitionCreate.html")]
        public IActionResult RequisitionCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/RequisitionCreate.html")]
        public async Task<IActionResult> RequisitionCreate(RequisitionVM model)
        {
            var response = await _Requisition.AddEditRequisition(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Requisitionlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/RequisitionEdit.html")]
        public async Task<IActionResult> RequisitionEdit(int id)
        {
            return View(await _Requisition.ViewEdit(id));
        }

        [HttpGet]
        [Route("/RequisitionEdit.html")]
        public async Task<IActionResult> RequisitionEdit(RequisitionVM model, int id)
        {
            var response = await _Requisition.AddEditRequisition(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Requisitionlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/RequisitionDelete.html")]
        public async Task<IActionResult> RequisitionDelete(int id)
        {
            return View(await _Requisition.Delete(id));
        }

    }
}