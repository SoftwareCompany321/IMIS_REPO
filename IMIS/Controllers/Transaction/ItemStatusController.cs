using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IItemStatus;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class ItemStatusController : Controller
    {
        private readonly IItemStatus _ItemStatus;

        public ItemStatusController(IItemStatus ItemStatus)
        {
            _ItemStatus = ItemStatus;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemStatusFetchData.html")]
        public async Task<JsonResult> ItemStatusFetchData(DataTableVm model)
        {
            var response = await _ItemStatus.ItemStatusFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemStatuslist.html")]
        public IActionResult ItemStatusList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemStatusCreate.html")]
        public IActionResult ItemStatusCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemStatusCreate.html")]
        public async Task<IActionResult> ItemStatusCreate(ItemStatusVM model)
        {
            var response = await _ItemStatus.AddEditItemStatus(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemStatuslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/ItemStatusEdit.html")]
        public async Task<IActionResult> ItemStatusEdit(decimal id)
        {
            return View(await _ItemStatus.ViewEdit(id));
        }

        [HttpGet]
        [Route("/ItemStatusEdit.html")]
        public async Task<IActionResult> ItemStatusEdit(ItemStatusVM model, int id)
        {
            var response = await _ItemStatus.AddEditItemStatus(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemStatuslist.html");
            }
            return View();
        }
    }
}