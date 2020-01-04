using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IOrgFormDtl;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class OrgFormDtlController : Controller
    {
        private readonly IOrgFormDtl _OrgFormDtl;

        public OrgFormDtlController(IOrgFormDtl OrgFormDtl)
        {
            _OrgFormDtl = OrgFormDtl;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrgFormDtlFetchData.html")]
        public async Task<JsonResult> OrgFormDtlFetchData(DataTableVm model)
        {
            var response = await _OrgFormDtl.OrgFormDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/OrgFormDtllist.html")]
        public IActionResult OrgFormDtlList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrgFormDtlCreate.html")]
        public IActionResult OrgFormDtlCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OrgFormDtlCreate.html")]
        public async Task<IActionResult> OrgFormDtlCreate(OrgFormDtlVM model)
        {
            var response = await _OrgFormDtl.AddEditOrgFormDtl(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OrgFormDtllist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/OrgFormDtlEdit.html")]
        public async Task<IActionResult> OrgFormDtlEdit(int id)
        {
            return View(await _OrgFormDtl.ViewEdit(id));
        }

        [HttpGet]
        [Route("/OrgFormDtlEdit.html")]
        public async Task<IActionResult> OrgFormDtlEdit(OrgFormDtlVM model, int id)
        {
            var response = await _OrgFormDtl.AddEditOrgFormDtl(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OrgFormDtllist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/OrgFormDtlDelete.html")]
        public async Task<IActionResult> OrgFormDtlDelete(int brandId)
        {
            var response = await _OrgFormDtl.DeleteOrgFormDtl(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OrgFormDtllist.html");
            }
            return View();
        }
    }
}