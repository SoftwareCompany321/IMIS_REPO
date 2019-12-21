using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IInvAdujType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class InvAdujTypeController : Controller
    {
        private readonly IInvAdujType _InvAdujType;

        public InvAdujTypeController(IInvAdujType InvAdujType)
        {
            _InvAdujType = InvAdujType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/InvAdujTypeFetchData.html")]
        public async Task<JsonResult> InvAdujTypeFetchData(DataTableVm model)
        {
            var response = await _InvAdujType.InvAdujTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/InvAdujTypelist.html")]
        public IActionResult InvAdujTypeList()
        {
            return View();
        }
        [HttpGet]
        [Route("/InvAdujTypeCreate.html")]
        public IActionResult InvAdujTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/InvAdujTypeCreate.html")]
        public async Task<IActionResult> InvAdujTypeCreate(InvAdujTypeVM model)
        {
            var response = await _InvAdujType.AddEditInvAdujType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/InvAdujTypelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/InvAdujTypeEdit.html")]
        public async Task<IActionResult> InvAdujTypeEdit(decimal id)
        {
            return View(await _InvAdujType.ViewEdit(id));
        }

        [HttpGet]
        [Route("/InvAdujTypeEdit.html")]
        public async Task<IActionResult> InvAdujTypeEdit(InvAdujTypeVM model, int id)
        {
            var response = await _InvAdujType.AddEditInvAdujType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/InvAdujTypelist.html");
            }
            return View();
        }
    }
}