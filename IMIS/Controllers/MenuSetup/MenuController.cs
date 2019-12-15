using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.IMenuService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.MenuSetup
{
    [Authorize]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/menudatafetchlist.html")]
        public async Task<JsonResult> MenuFetchList(DataTableVm model)
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

    }
}