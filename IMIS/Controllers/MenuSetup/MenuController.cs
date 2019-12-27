﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.GlobalFunction;
using IMIS_Service.IMenuService;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.MenuSetup
{
    [Authorize]
    public class MenuController : Controller
    {
        private readonly MenuService _menuService;
        private readonly GlobalFunction _global;
        public MenuController(MenuService menuService, GlobalFunction global)
        {
            _menuService = menuService;
            _global = global;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/MenuTreeFetchData.html")]
        public JsonResult ItemCategoryFetchData(DataTableVm model)
        {
            // var response =  _ItemCategory.ItemCategoriesFetchData1(model);
            //return Json(repo.GetDataTree(id, TreeViewPathProvider.Instance().openedNodes));
            return Json(_menuService.MenuTreeFetchData(model));


        }
        [HttpGet]
        [Route("/menudatafetchlist.html")]
        public IActionResult MenuFetchList()
        {
            return View();
        }

        [HttpGet]
        [Route("/{id}/menudatagetfetchdatadatable.html")]
        public async Task<JsonResult> menudatagetfetchdatadatable(DataTableVm model,int id)
        {
            var response = await _menuService.MenuChildDataTabel(model,id);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/{id}/MenuCreate.html")]
        public IActionResult MenuCreate(int id)
        {
            ViewData["ParentMenu"] = _global.GetParentMenu(id); //calling the all parent menu
            return View("_partialMenu");

        }

        [HttpPost]
        [Route("/MenuCreate.html")]
        public async Task<IActionResult> MenuCreate(MenuVM model)
        {
            var result = await _menuService.MenuAddEdit(model);

            if (result.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/menudatafetchlist.html");
            }
            ViewData["ParentMenu"] = _global.GetAllParentMenu();
            return View();
        }


        [HttpGet]
        [Route("/{id}/MenuEdit.html")]
        public async Task<IActionResult> MenuEdit(int id)
        {
            ViewData["ParentMenu"] = _global.GetAllParentMenu(); 
            return View("_partialMenu", await _menuService.ViewEdit(id));

        }

        


        [HttpGet]
        [Route("/{id}/MenuTreePartial.html")]
        public IActionResult MenuTreePartial(int id)
        {
            ViewData["id"] = id;
            return View("_MenuList");
        }

    }
}