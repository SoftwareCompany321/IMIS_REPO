using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemPurMasterPlan;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemPurMasterPlanController : Controller
    {
        private readonly IItemPurMasterPlan _ItemPurMasterPlan;

        public ItemPurMasterPlanController(IItemPurMasterPlan ItemPurMasterPlan)
        {
            _ItemPurMasterPlan = ItemPurMasterPlan;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurMasterPlanFetchData.html")]
        public async Task<JsonResult> ItemPurMasterPlanFetchData(DataTableVm model)
        {
            var response = await _ItemPurMasterPlan.ItemPurMasterPlanFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemPurMasterPlanlist.html")]
        public IActionResult ItemPurMasterPlanList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurMasterPlanCreate.html")]
        public IActionResult ItemPurMasterPlanCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurMasterPlanCreate.html")]
        public async Task<IActionResult> ItemPurMasterPlanCreate(ItemPurMasterPlanVM model)
        {
            var response = await _ItemPurMasterPlan.AddEditItemPurMasterPlan(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurMasterPlanlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/ItemPurMasterPlanEdit.html")]
        public async Task<IActionResult> ItemPurMasterPlanEdit(int id)
        {
            return View(await _ItemPurMasterPlan.ViewEdit(id));
        }

        [HttpGet]
        [Route("/ItemPurMasterPlanEdit.html")]
        public async Task<IActionResult> ItemPurMasterPlanEdit(ItemPurMasterPlanVM model, int id)
        {
            var response = await _ItemPurMasterPlan.AddEditItemPurMasterPlan(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurMasterPlanlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/ItemPurMasterPlanDelete.html")]
        public async Task<IActionResult> ItemPurMasterPlanDelete(int brandId)
        {
            var response = await _ItemPurMasterPlan.DeleteItemPurMasterPlan(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurMasterPlanlist.html");
            }
            return View();
        }
    }
}