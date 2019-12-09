using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemCategories;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemCategoryController : Controller
    {
        private readonly IItemCategories _ItemCategory;

        public ItemCategoryController(IItemCategories ItemCategory)
        {
            _ItemCategory = ItemCategory;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemCategoryerFetchData.html")]
        public async Task<JsonResult> ItemCategoryerFetchData(DataTableVm model)
        {
            var response = await _ItemCategory.ItemCategoriesFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemCategoryerlsit.html")]
        public IActionResult ItemCategoryerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemCategoryerCreate.html")]
        public IActionResult ItemCategoryerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemCategoryerCreate.html")]
        public IActionResult ItemCategoryerCreate(ItemCategoriesVM model)
        {
            return View();
        }
    }
}