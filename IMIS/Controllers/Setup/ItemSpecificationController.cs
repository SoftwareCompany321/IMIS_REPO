using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemSpecification;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemSpecificationController : Controller
    {
        private readonly IItemSpecification _ItemSpecification;

        public ItemSpecificationController(IItemSpecification ItemSpecification)
        {
            _ItemSpecification = ItemSpecification;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemSpecificationerFetchData.html")]
        public async Task<JsonResult> ItemSpecificationerFetchData(DataTableVm model)
        {
            var response = await _ItemSpecification.ItemSpecificationFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemSpecificationerlsit.html")]
        public IActionResult ItemSpecificationerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemSpecificationerCreate.html")]
        public IActionResult ItemSpecificationerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemSpecificationerCreate.html")]
        public IActionResult ItemSpecificationerCreate(ItemSpecificationVM model)
        {
            return View();
        }
    }
}