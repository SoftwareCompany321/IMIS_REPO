using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemUnit;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemUnitController : Controller
    {
        private readonly IItemUnit _ItemUnit;

        public ItemUnitController(IItemUnit ItemUnit)
        {
            _ItemUnit = ItemUnit;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemUnitFetchData.html")]
        public async Task<JsonResult> ItemUnitFetchData(DataTableVm model)
        {
            var response = await _ItemUnit.ItemUnitFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemUnitlist.html")]
        public IActionResult ItemUnitList()
        {
           
            return View();
        }

        [HttpGet]
        [Route("/ItemUnitCreate.html")]
        public IActionResult ItemUnitCreate()
        {
            ViewData["MultipleFactor"] = _ItemUnit.GetItemUnitList();
            return View();
        }
        [HttpPost]
        [Route("/ItemUnitCreate.html")]
        public async Task<IActionResult> ItemUnitCreate(ItemUnitVM model)
        {
            var response = await _ItemUnit.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemUnitlist.html");
            }
            return View();
        }
        [HttpGet]

        [Route("{unitId}/ItemUnitEdit.html")]
        public async Task<IActionResult> ItemUnitEdit(int UnitId)
        {
            return View(await _ItemUnit.ViewOrEditData(UnitId));
        }
        [HttpPost]
        [Route("{unitId}/ItemUnitEdit.html")]
        public async Task<IActionResult> ItemUnitEdit(ItemUnitVM model, int UnitId)
        {
            var response = await _ItemUnit.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemUnitlist.html");
            }
            return View();
        }

        [HttpPost]
        [Route("{unitId}/ItemUnitDelete.html")]
        public async Task<IActionResult> ItemUnitDelete(ItemUnitVM model, int UnitId)
        {
            var response = await _ItemUnit.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemUnitlist.html");
            }
            return View();
        }
    }
}