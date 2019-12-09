using System;
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
        [Route("/DepartmenterFetchData.html")]
        public async Task<JsonResult> DepartmenterFetchData(DataTableVm model)
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
        [Route("/Departmenterlsit.html")]
        public IActionResult DepartmenterList()
        {
            return View();
        }

        [HttpGet]
        [Route("/DepartmenterCreate.html")]
        public IActionResult DepartmenterCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/DepartmenterCreate.html")]
        public IActionResult DepartmenterCreate(DepartmentVM model)
        {
            return View();
        }
    }
}