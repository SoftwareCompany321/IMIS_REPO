using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemBrand;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemBrandController : Controller
    {
        private readonly IItemBrand _ItemBrand;

        public ItemBrandController(IItemBrand ItemBrand)
        {
            _ItemBrand = ItemBrand;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemBrandFetchData.html")]
        public async Task<JsonResult> ItemBrandFetchData(DataTableVm model)
        {
            var response = await _ItemBrand.ItemBrandFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemBrandlist.html")]
        public IActionResult ItemBrandList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemBrandCreate.html")]
        public IActionResult ItemBrandCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemBrandCreate.html")]
        public async Task<IActionResult> ItemBrandCreate(ItemBrandVM model)
        {
            var response = await _ItemBrand.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemBrandlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/ItemBrandEdit.html")]
        public async Task<IActionResult> ItemBrandEdit(decimal id)
        {
            return View(await _ItemBrand.ViewEdit(id));
        }

        [HttpPost]
        [Route("/{id}/ItemBrandEdit.html")]
        public async Task<IActionResult> ItemBrandEdit(ItemBrandVM model)
        {
            var response = await _ItemBrand.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemBrandlist.html");
            }
            return View();
        }
    }
}