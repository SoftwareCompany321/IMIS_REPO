using System;
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
        [Route("/menudatafetchlist.html")]
        public IActionResult MenuFetchList()
        {
            return View();
        }

        [HttpGet]
        [Route("/menudatagetfetchdatadatable.html")]
        public async Task<JsonResult> menudatagetfetchdatadatable(DataTableVm model)
        {
            var response = await _menuService.MenuDataTabel(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/MenuCreate.html")]
        public IActionResult MenuCreate()
        {
            ViewData["ParentMenu"] = _global.GetAllParentMenu(); //calling the all parent menu
            return View();

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
            return View(await _menuService.ViewEdit(id));

        }

        [HttpPost]
        [Route("/{id}/MenuEdit.html")] 
        public async Task<IActionResult> MenuEdit(MenuVM model)
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




    }
}