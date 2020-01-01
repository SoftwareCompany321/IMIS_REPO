using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IProjectSetup;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ProjectSetupController : Controller
    {
        private readonly IProjectSetup _ProjectSetup;

        public ProjectSetupController(IProjectSetup ProjectSetup)
        {
            _ProjectSetup = ProjectSetup;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ProjectSetupFetchData.html")]
        public async Task<JsonResult> ProjectSetupFetchData(DataTableVm model)
        {
            var response = await _ProjectSetup.ProjectSetupFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ProjectSetuplist.html")]
        public IActionResult ProjectSetupList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ProjectSetupCreate.html")]
        public IActionResult ProjectSetupCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ProjectSetupCreate.html")]
        public async Task<IActionResult> ProjectSetupCreate(ProjectSetupVM model)
        {
            var response = await _ProjectSetup.AddEditProjectSetup(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ProjectSetuplist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/ProjectSetupEdit.html")]
        public async Task<IActionResult> ProjectSetupEdit(decimal id)
        {
            return View(await _ProjectSetup.ViewEdit(id));
        }

        [HttpGet]
        [Route("/ProjectSetupEdit.html")]
        public async Task<IActionResult> ProjectSetupEdit(ProjectSetupVM model, int id)
        {
            var response = await _ProjectSetup.AddEditProjectSetup(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ProjectSetuplist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{id}/ProjectSetupDelete.html")]
        public async Task<IActionResult> ProjectSetupDelete(int id)
        {
            var response = await _ProjectSetup.DeleteProjectSetup(id);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ProjectSetuplist.html");
            }
            return View();
        }
    }
}