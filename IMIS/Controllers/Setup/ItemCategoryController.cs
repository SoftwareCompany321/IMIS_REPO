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
        [Route("/ItemCategoryFetchData.html")]
        public async Task<JsonResult> ItemCategoryFetchData(DataTableVm model)
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
        [Route("/ItemCategorylist.html")]
        public IActionResult ItemCategoryList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemCategoryCreate.html")]
        public IActionResult ItemCategoryCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemCategoryCreate.html")]
        public async Task<IActionResult> ItemCategoryCreate(ItemCategoriesVM model)
        {
            var response = await _ItemCategory.AddEditItemCategories(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemCategorylist.html");
            }
            return View(); 
        }

        [HttpGet]
        [Route("/ItemCategoryEdit.html")]
        public async Task<IActionResult> ItemCategoryEdit(decimal id)
        {
            return View(await _ItemCategory.ViewEdit(id));
        }

        [HttpGet]
        [Route("/ItemCategoryEdit.html")]
        public async Task<IActionResult> ItemCategoryEdit(ItemCategoriesVM model, int id)
        {
            var response = await _ItemCategory.AddEditItemCategories(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemCategorylist.html");
            }
            return View();
        }
    }
}