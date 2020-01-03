using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.IEmploymentStatus;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.EmployeeManagement
{
    public class EmploymentStatusController : Controller
    {
        private readonly IEmploymentStatus _EmploymentStatus;

        public EmploymentStatusController(IEmploymentStatus EmploymentStatus)
        {
            _EmploymentStatus = EmploymentStatus;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/EmploymentStatusFetchData.html")]
        public async Task<JsonResult> EmploymentStatusFetchData(DataTableVm model)
        {
            var response = await _EmploymentStatus.EmploymentStatusFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/EmploymentStatuslist.html")]
        public IActionResult EmploymentStatusList()
        {
            return View();
        }

        [HttpGet]
        [Route("/EmploymentStatusCreate.html")]
        public IActionResult EmploymentStatusCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/EmploymentStatusCreate.html")]
        public async Task<IActionResult> EmploymentStatusCreate(EmploymentStatusVM model)
        {
            var response = await _EmploymentStatus.AddEditEmploymentStatus(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/EmploymentStatuslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/EmploymentStatusEdit.html")]
        public async Task<IActionResult> EmploymentStatusEdit(decimal id)
        {
            return View(await _EmploymentStatus.ViewEdit(id));
        }

        [HttpGet]
        [Route("/EmploymentStatusEdit.html")]
        public async Task<IActionResult> EmploymentStatusEdit(EmploymentStatusVM model, int id)
        {
            var response = await _EmploymentStatus.AddEditEmploymentStatus(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/EmploymentStatuslist.html");
            }
            return View();
        }
    }
}