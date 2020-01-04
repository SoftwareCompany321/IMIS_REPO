using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IItemNumbering;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class ItemNumberingController : Controller
    {
        private readonly IItemNumbering _ItemNumbering;

        public ItemNumberingController(IItemNumbering ItemNumbering)
        {
            _ItemNumbering = ItemNumbering;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemNumberingFetchData.html")]
        public async Task<JsonResult> ItemNumberingFetchData(DataTableVm model)
        {
            var response = await _ItemNumbering.ItemNumberingFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemNumberinglist.html")]
        public IActionResult ItemNumberingList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemNumberingCreate.html")]
        public IActionResult ItemNumberingCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemNumberingCreate.html")]
        public async Task<IActionResult> ItemNumberingCreate(ItemNumberingVM model)
        {
            var response = await _ItemNumbering.AddEditItemNumbering(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemNumberinglist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/ItemNumberingEdit.html")]
        public async Task<IActionResult> ItemNumberingEdit(decimal id)
        {
            return View(await _ItemNumbering.ViewEdit(id));
        }

        [HttpGet]
        [Route("/ItemNumberingEdit.html")]
        public async Task<IActionResult> ItemNumberingEdit(ItemNumberingVM model, int id)
        {
            var response = await _ItemNumbering.AddEditItemNumbering(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/ItemNumberinglist.html");
            }
            return View();
        }
    }
}