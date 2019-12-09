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
        [Route("/ProjectSetuperFetchData.html")]
        public async Task<JsonResult> ProjectSetuperFetchData(DataTableVm model)
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
        [Route("/ProjectSetuperlsit.html")]
        public IActionResult ProjectSetuperList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ProjectSetuperCreate.html")]
        public IActionResult ProjectSetuperCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ProjectSetuperCreate.html")]
        public IActionResult ProjectSetuperCreate(ProjectSetupVM model)
        {
            return View();
        }
    }
}