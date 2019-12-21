using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemPurYearlyPlan;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemPurYearlyPlanController : Controller
    {
        private readonly IItemPurYearlyPlan _ItemPurYearlyPlan;

        public ItemPurYearlyPlanController(IItemPurYearlyPlan ItemPurYearlyPlan)
        {
            _ItemPurYearlyPlan = ItemPurYearlyPlan;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurYearlyPlanFetchData.html")]
        public async Task<JsonResult> ItemPurYearlyPlanFetchData(DataTableVm model)
        {
            var response = await _ItemPurYearlyPlan.ItemPurYearlyPlanFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemPurYearlyPlanlist.html")]
        public IActionResult ItemPurYearlyPlanList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurYearlyPlanCreate.html")]
        public IActionResult ItemPurYearlyPlanCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurYearlyPlanCreate.html")]
        public async Task<IActionResult> ItemPurYearlyPlanCreate(ItemPurYearlyPlanVM model)
        {
            var response = await _ItemPurYearlyPlan.AddEditItemPurYearlyPlan(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurYearlyPlanlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/ItemPurYearlyPlanEdit.html")]
        public async Task<IActionResult> ItemPurYearlyPlanEdit(decimal id)
        {
            return View(await _ItemPurYearlyPlan.ViewEdit(id));
        }

        [HttpGet]
        [Route("/ItemPurYearlyPlanEdit.html")]
        public async Task<IActionResult> ItemPurYearlyPlanEdit(ItemPurYearlyPlanVM model, int id)
        {
            var response = await _ItemPurYearlyPlan.AddEditItemPurYearlyPlan(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurYearlyPlanlist.html");
            }
            return View();
        }
    }
}