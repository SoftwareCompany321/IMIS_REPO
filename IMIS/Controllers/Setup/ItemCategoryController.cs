using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS.TreeView;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemCategories;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemCategoryController : Controller
    {
        private readonly IItemCategories _ItemCategory;
        private readonly IObjectRepositary repo;

        public ItemCategoryController(IItemCategories ItemCategory, IObjectRepositary r)
        {
            _ItemCategory = ItemCategory;
            repo = r;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemCategoryFetchData.html")]
        public JsonResult ItemCategoryFetchData(DataTableVm model)
        {
            // var response =  _ItemCategory.ItemCategoriesFetchData1(model);
            //return Json(repo.GetDataTree(id, TreeViewPathProvider.Instance().openedNodes));
            return Json(_ItemCategory.ItemCategoriesFetchData1(model));


        }

        [HttpGet]
        [Route("/{id}/ItemCategoryFetchDataList.html")]
        public async Task<JsonResult> ItemCategoryFetchDataList(DataTableVm model, int id)
        {
            var response = await _ItemCategory.ItemCategoriesFetchData(model, id);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }
        [HttpGet]
        [Route("/{id}/ItemCategorylist.html")]
        public IActionResult ItemCategoryList(int id)
        {
            ViewData["ParentCategory"] = _ItemCategory.GetParentItemCategory(id); //calling the all parent menu
            return View("_partialItemCategory");

        }

        [HttpGet]
        [Route("/{id}/ItemCategoryCreate.html")]
        public IActionResult ItemCategoryCreate(int id)
        {
            var item = new ItemCategoriesVM();
            item.ParentId = id;
            return View(item);
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
        [Route("/{id}/ItemCategoryEdit.html")]
        public async Task<IActionResult> ItemCategoryEdit(int id)
        {
            return View(await _ItemCategory.ViewEdit(id));
        }

        [HttpGet]
        [Route("/{id}/ItemCategoryPartial.html")]
        public IActionResult ItemCategoryPartial(int id)
        {
            return View("_CategoryList");
        }
    }
}