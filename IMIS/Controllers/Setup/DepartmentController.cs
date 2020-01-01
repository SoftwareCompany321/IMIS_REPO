﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IDepartment;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment _Department;

        public DepartmentController(IDepartment Department)
        {
            _Department = Department;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/DepartmentFetchData.html")]
        public async Task<JsonResult> DepartmentFetchData(DataTableVm model)
        {
            var response = await _Department.DepartmentFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/Departmentlist.html")]
        public IActionResult DepartmentList()
        {
            return View();
        }

        [HttpGet]
        [Route("/DepartmentCreate.html")]
        public IActionResult DepartmentCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/DepartmentCreate.html")]
        public async Task<IActionResult> DepartmentCreate(DepartmentVM model)
        {
            var response = await _Department.AddEditDepartment(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Departmentlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/DepartmentEdit.html")]
        public async Task<IActionResult> DepartmentEdit(decimal id)
        {
            return View(await _Department.ViewEdit(id));
        }

        [HttpGet]
        [Route("/DepartmentEdit.html")]
        public async Task<IActionResult> DepartmentEdit(DepartmentVM model, int id)
        {
            var response = await _Department.AddEditDepartment(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Departmentlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{deptid}/DepartmentDelete.html")]
        public async Task<IActionResult> DepartmentDelete(int deptid)
        {
            var response = await _Department.DeleteDepartment(deptid);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/Departmentlist.html");
            }
            return View();
        }
    }
}