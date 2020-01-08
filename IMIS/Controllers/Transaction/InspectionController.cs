using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IInspection;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class InspectionController : Controller
    {
        private readonly IInspection _Inspection;

        public InspectionController(IInspection Inspection)
        {
            _Inspection = Inspection;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/InspectionFetchData.html")]
        public async Task<JsonResult> InspectionFetchData(DataTableVm model)
        {
            var response = await _Inspection.InspectionFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/InvInspectionList.html")]
        public IActionResult InspectionList()
        {
            return View();
        }

        [HttpGet]
        [Route("/InspectionCreate.html")]
        public IActionResult InspectionCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/InspectionCreate.html")]
        public async Task<IActionResult> InspectionCreate(InspectionVM model)
        {
            var response = await _Inspection.AddEditInspection(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Inspectionlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/InspectionEdit.html")]
        public async Task<IActionResult> InspectionEdit(decimal id)
        {
            return View(await _Inspection.ViewEdit(id));
        }

        [HttpGet]
        [Route("/InspectionEdit.html")]
        public async Task<IActionResult> InspectionEdit(InspectionVM model, int id)
        {
            var response = await _Inspection.AddEditInspection(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Inspectionlist.html");
            }
            return View();
        }
    }
}