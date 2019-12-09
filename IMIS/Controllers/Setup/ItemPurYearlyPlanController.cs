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
        [Route("/ItemPurYearlyPlanerFetchData.html")]
        public async Task<JsonResult> ItemPurYearlyPlanerFetchData(DataTableVm model)
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
        [Route("/ItemPurYearlyPlanerlsit.html")]
        public IActionResult ItemPurYearlyPlanerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurYearlyPlanerCreate.html")]
        public IActionResult ItemPurYearlyPlanerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurYearlyPlanerCreate.html")]
        public IActionResult ItemPurYearlyPlanerCreate(ItemPurYearlyPlanVM model)
        {
            return View();
        }
    }
}