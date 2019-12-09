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
        [Route("/ProjectSetuplsit.html")]
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
        public IActionResult ProjectSetupCreate(ProjectSetupVM model)
        {
            return View();
        }
    }
}