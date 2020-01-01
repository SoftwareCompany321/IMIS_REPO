using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemPurchaseType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemPurchaseTypeController : Controller
    {
        private readonly IItemPurchaseType _ItemPurchaseType;

        public ItemPurchaseTypeController(IItemPurchaseType ItemPurchaseType)
        {
            _ItemPurchaseType = ItemPurchaseType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurchaseTypeFetchData.html")]
        public async Task<JsonResult> ItemPurchaseTypeFetchData(DataTableVm model)
        {
            var response = await _ItemPurchaseType.ItemPurchaseTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemPurchaseTypelist.html")]
        public IActionResult ItemPurchaseTypeList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurchaseTypeCreate.html")]
        public IActionResult ItemPurchaseTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurchaseTypeCreate.html")]
        public async Task<IActionResult> ItemPurchaseTypeCreate(ItemPurchaseTypeVM model)
        {
            var response = await _ItemPurchaseType.AddEditSave(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurchaseTypelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/ItemPurchaseTypeEdit.html")]
        public async Task<IActionResult> ItemPurchaseTypeEdit(int id)
        {
            return View(await _ItemPurchaseType.ViewEdit(id));
        }

        [HttpPost]
        [Route("/ItemPurchaseTypeEdit.html")]
        public async Task<IActionResult> ItemPurchaseTypeEdit(ItemPurchaseTypeVM model)
        {
            var response = await _ItemPurchaseType.AddEditSave(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Update";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurchaseTypelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/ItemPurchaseTypeDelete.html")]
        public async Task<IActionResult> ItemPurchaseTypeDelete(int brandId)
        {
            var response = await _ItemPurchaseType.DeleteItemPurchaseType(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemPurchaseTypelist.html");
            }
            return View();
        }
    }
}