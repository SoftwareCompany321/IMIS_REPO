using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.IEmployeePosition;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.EmployeeManagement
{
    public class EmployeePositionController : Controller
    {
        private readonly IEmployeePosition _EmployeePosition;

        public EmployeePositionController(IEmployeePosition EmployeePosition)
        {
            _EmployeePosition = EmployeePosition;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/EmployeePositionFetchData.html")]
        public async Task<JsonResult> EmployeePositionFetchData(DataTableVm model)
        {
            var response = await _EmployeePosition.EmployeePositionFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/EmployeePositionlist.html")]
        public IActionResult EmployeePositionList()
        {
            return View();
        }

        [HttpGet]
        [Route("/EmployeePositionCreate.html")]
        public IActionResult EmployeePositionCreate()
        {
           
            return View();
        }

        [HttpPost]
        [Route("/EmployeePositionCreate.html")]
        public async Task<IActionResult> EmployeePositionCreate(EmployeePositionVM model)
        {
            var response = await _EmployeePosition.AddEditEmployeePosition(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/EmployeePositionlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/EmployeePositionEdit.html")]
        public async Task<IActionResult> EmployeePositionEdit(decimal id)
        {
            return View(await _EmployeePosition.ViewEdit(id));
        }

        [HttpGet]
        [Route("/EmployeePositionEdit.html")]
        public async Task<IActionResult> EmployeePositionEdit(EmployeePositionVM model, int id)
        {
            var response = await _EmployeePosition.AddEditEmployeePosition(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/EmployeePositionlist.html");
            }
            return View();
        }
    }
}