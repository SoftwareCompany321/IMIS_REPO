﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.IOfficeOrgStructure;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class OfficeOrgStructureController : Controller
    {
        private readonly IOfficeOrgStructure _OfficeOrgStructure;

        public OfficeOrgStructureController(IOfficeOrgStructure OfficeOrgStructure)
        {
            _OfficeOrgStructure = OfficeOrgStructure;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OfficeOrgStructureFetchData.html")]
        public async Task<JsonResult> OfficeOrgStructureerFetchData(DataTableVm model)
        {
            var response = await _OfficeOrgStructure.OfficeOrgStructureFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/OfficeOrgStructurelist.html")]
        public IActionResult OfficeOrgStructureerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OfficeOrgStructureCreate.html")]
        public IActionResult OfficeOrgStructureCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OfficeOrgStructureCreate.html")]
        public async Task<IActionResult> OfficeOrgStructureCreate(OfficeOrgStructureVM model)
        {
            var response = await _OfficeOrgStructure.AddEditOfficeOrgStructure(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OfficeOrgStructurelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/OfficeOrgStructureEdit.html")]
        public async Task<IActionResult> OfficeOrgStructureEdit(decimal id)
        {
            return View(await _OfficeOrgStructure.ViewEdit(id));
        }

        [HttpGet]
        [Route("/OfficeOrgStructureEdit.html")]
        public async Task<IActionResult> OfficeOrgStructureEdit(OfficeOrgStructureVM model, int id)
        {
            var response = await _OfficeOrgStructure.AddEditOfficeOrgStructure(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OfficeOrgStructurelist.html");
            }
            return View();
        }
    }
}