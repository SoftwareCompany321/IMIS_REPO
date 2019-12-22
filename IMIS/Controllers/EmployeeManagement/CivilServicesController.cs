using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.ICivilServices;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class CivilServicesController : Controller
    {
        private readonly ICivilServices _CivilServices;

        public CivilServicesController(ICivilServices CivilServices)
        {
            _CivilServices = CivilServices;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/CivilServicesFetchData.html")]
        public async Task<JsonResult> CivilServiceserFetchData(DataTableVm model)
        {
            var response = await _CivilServices.CivilServicesFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/CivilServiceslist.html")]
        public IActionResult CivilServiceserList()
        {
            return View();
        }

        [HttpGet]
        [Route("/CivilServicesCreate.html")]
        public IActionResult CivilServicesCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/CivilServicesCreate.html")]
        public async Task<IActionResult> CivilServicesCreate(CivilServicesVM model)
        {
            var response = await _CivilServices.AddEditCivilServices(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/CivilServiceslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/CivilServicesEdit.html")]
        public async Task<IActionResult> CivilServicesEdit(decimal id)
        {
            return View(await _CivilServices.ViewEdit(id));
        }

        [HttpGet]
        [Route("/CivilServicesEdit.html")]
        public async Task<IActionResult> CivilServicesEdit(CivilServicesVM model, int id)
        {
            var response = await _CivilServices.AddEditCivilServices(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/CivilServiceslist.html");
            }
            return View();
        }
    }
}