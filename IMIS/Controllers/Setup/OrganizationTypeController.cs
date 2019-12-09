using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IOrganizationType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class OrganizationTypeController : Controller
    {
        private readonly IOrganizationType _OrganizationType;

        public OrganizationTypeController(IOrganizationType OrganizationType)
        {
            _OrganizationType = OrganizationType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrganizationTypeerFetchData.html")]
        public async Task<JsonResult> OrganizationTypeerFetchData(DataTableVm model)
        {
            var response = await _OrganizationType.OrganizationTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/OrganizationTypeerlsit.html")]
        public IActionResult OrganizationTypeerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrganizationTypeerCreate.html")]
        public IActionResult OrganizationTypeerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OrganizationTypeerCreate.html")]
        public IActionResult OrganizationTypeerCreate(OrganizationTypeVM model)
        {
            return View();
        }
    }
}