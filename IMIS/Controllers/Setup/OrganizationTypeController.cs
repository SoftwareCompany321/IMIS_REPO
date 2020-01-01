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
        [Route("/OrganizationTypeFetchData.html")]
        public async Task<JsonResult> OrganizationTypeFetchData(DataTableVm model)
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
        [Route("/OrganizationTypelist.html")]
        public IActionResult OrganizationTypeList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrganizationTypeCreate.html")]
        public IActionResult OrganizationTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OrganizationTypeCreate.html")]
        public async Task<IActionResult> OrganizationTypeCreate(OrganizationTypeVM model)
        {
            var response = await _OrganizationType.AddEditSave(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OrganizationTypelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/OrganizationTypeEdit.html")]
        public async Task<IActionResult> OrganizationTypeEdit(int id)
        {
            return View(await _OrganizationType.ViewEdit(id));
        }

        [HttpPost]
        [Route("/OrganizationTypeEdit.html")]
        public async Task<IActionResult> OrganizationTypeEdit(OrganizationTypeVM model)
        {
            var response = await _OrganizationType.AddEditSave(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Update";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OrganizationTypelist.html");
            }
            return View();
        }
    }
}