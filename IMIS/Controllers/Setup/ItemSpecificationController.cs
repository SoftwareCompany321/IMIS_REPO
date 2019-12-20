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
        [Route("/ItemSpecificationFetchData.html")]
        public async Task<JsonResult> ItemSpecificationFetchData(DataTableVm model)
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
        [Route("/ItemSpecificationlist.html")]
        public IActionResult ItemSpecificationList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemSpecificationCreate.html")]
        public IActionResult ItemSpecificationCreate()
        {
            return View();
        }
        [HttpPost]
        [Route("/ItemSpecificationCreate.html")]
        public async Task<IActionResult> ItemSpecificationCreate(ItemSpecificationVM model)
        {
            var response = await _ItemSpecification.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemSpecificationCreate.html");
            }
            return View();
        }
        [HttpGet]

        [Route("{SpecificationId}/ItemSpecificationEdit.html")]
        public async Task<IActionResult> ItemSpecificationEdit(int SpecificationId)
        {
            return View(await _ItemSpecification.ViewOrEditData(SpecificationId));
        }
        [HttpPost]
        [Route("{SpecificationId}/ItemSpecificationEdit.html")]
        public async Task<IActionResult> ItemSpecificationEdit(ItemSpecificationVM model, int SpecificationId)
        {
            var response = await _ItemSpecification.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemSpecificationlist.html");
            }
            return View();
        }
    }
}