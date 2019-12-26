using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.IEmployeeName;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class EmployeeNameController : Controller
    {
        private readonly IEmployeeName _EmployeeName;

        public EmployeeNameController(IEmployeeName EmployeeName)
        {
            _EmployeeName = EmployeeName;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/EmployeeNameFetchData.html")]
        public async Task<JsonResult> EmployeeNameFetchData(DataTableVm model)
        {
            var response = await _EmployeeName.EmployeeNameFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/EmployeeNamelist.html")]
        public IActionResult EmployeeNameList()
        {
            return View();
        }

        [HttpGet]
        [Route("/EmployeeNameCreate.html")]
        public IActionResult EmployeeNameCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/EmployeeNameCreate.html")]
        public async Task<IActionResult> EmployeeNameCreate(EmployeeNameVM model)
        {
            var response = await _EmployeeName.AddEditEmployeeName(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/EmployeeNamelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/EmployeeNameEdit.html")]
        public async Task<IActionResult> EmployeeNameEdit(decimal id)
        {
            return View(await _EmployeeName.ViewEdit(id));
        }

        [HttpGet]
        [Route("/EmployeeNameEdit.html")]
        public async Task<IActionResult> EmployeeNameEdit(EmployeeNameVM model, int id)
        {
            var response = await _EmployeeName.AddEditEmployeeName(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/EmployeeNamelist.html");
            }
            return View();
        }
    }
}