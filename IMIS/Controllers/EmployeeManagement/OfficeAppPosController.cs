﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.IOfficeAppPos;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.EmployeeManagement
{
    public class OfficeAppPosController : Controller
    {
        private readonly IOfficeAppPos _OfficeAppPos;

        public OfficeAppPosController(IOfficeAppPos OfficeAppPos)
        {
            _OfficeAppPos = OfficeAppPos;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OfficeAppPosFetchData.html")]
        public async Task<JsonResult> OfficeAppPosFetchData(DataTableVm model)
        {
            var response = await _OfficeAppPos.OfficeAppPosFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/OfficeAppPoslist.html")]
        public IActionResult OfficeAppPosList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OfficeAppPosCreate.html")]
        public IActionResult OfficeAppPosCreate()
        {
            ViewData["post"] = _OfficeAppPos.GetPositionList();
            return View();
        }

        [HttpPost]
        [Route("/OfficeAppPosCreate.html")]
        public async Task<IActionResult> OfficeAppPosCreate(OfficeAppPosVM model)
        {
            var response = await _OfficeAppPos.AddEditOfficeAppPos(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OfficeAppPoslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/OfficeAppPosEdit.html")]
        public async Task<IActionResult> OfficeAppPosEdit(int id)
        {
            return View(await _OfficeAppPos.ViewEdit(id));
        }

        [HttpGet]
        [Route("/OfficeAppPosEdit.html")]
        public async Task<IActionResult> OfficeAppPosEdit(OfficeAppPosVM model, int id)
        {
            var response = await _OfficeAppPos.AddEditOfficeAppPos(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OfficeAppPoslist.html");
            }
            return View();
        }
    }
}