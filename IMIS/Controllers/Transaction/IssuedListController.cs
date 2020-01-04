using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Transaction.IIssuedList;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Transaction
{
    public class IssuedListController : Controller
    {
        private readonly IIssuedList _IssuedList;

        public IssuedListController(IIssuedList IssuedList)
        {
            _IssuedList = IssuedList;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/IssuedListFetchData.html")]
        public async Task<JsonResult> IssuedListFetchData(DataTableVm model)
        {
            var response = await _IssuedList.IssuedListFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/IssuedListlist.html")]
        public IActionResult IssuedListList()
        {
            return View();
        }

        [HttpGet]
        [Route("/IssuedListCreate.html")]
        public IActionResult IssuedListCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/IssuedListCreate.html")]
        public async Task<IActionResult> IssuedListCreate(IssuedListVM model)
        {
            var response = await _IssuedList.AddEditIssuedList(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/IssuedListlist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/IssuedListEdit.html")]
        public async Task<IActionResult> IssuedListEdit(decimal id)
        {
            return View(await _IssuedList.ViewEdit(id));
        }

        [HttpGet]
        [Route("/IssuedListEdit.html")]
        public async Task<IActionResult> IssuedListEdit(IssuedListVM model, int id)
        {
            var response = await _IssuedList.AddEditIssuedList(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/IssuedListlist.html");
            }
            return View();
        }
    }
}