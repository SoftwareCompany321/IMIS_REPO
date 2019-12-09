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
        [Route("/ItemPurMasterPlanerFetchData.html")]
        public async Task<JsonResult> ItemPurMasterPlanerFetchData(DataTableVm model)
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
        [Route("/ItemPurMasterPlanerlsit.html")]
        public IActionResult ItemPurMasterPlanerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurMasterPlanerCreate.html")]
        public IActionResult ItemPurMasterPlanerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurMasterPlanerCreate.html")]
        public IActionResult ItemPurMasterPlanerCreate(ItemPurMasterPlanVM model)
        {
            return View();
        }
    }
}