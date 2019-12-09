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
        [Route("/ItemPurYearlyPlanlsit.html")]
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
        public IActionResult ItemPurYearlyPlanCreate(ItemPurYearlyPlanVM model)
        {
            return View();
        }
    }
}