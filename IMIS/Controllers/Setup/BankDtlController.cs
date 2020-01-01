using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IBankDtl;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class BankDtlController : Controller
    {
        private readonly IBankDtl _BankDtl;

        public BankDtlController(IBankDtl BankDtl)
        {
            _BankDtl = BankDtl;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/BankDtlFetchData.html")]
        public async Task<JsonResult> BankDtlerFetchData(DataTableVm model)
        {
            var response = await _BankDtl.BankDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/BankDtllist.html")]
        public IActionResult BankDtlerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/BankDtlCreate.html")]
        public IActionResult BankDtlCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/BankDtlCreate.html")]
        public async Task<IActionResult> BankDtlCreate(BankDtlVM model)
        {
            var response = await _BankDtl.AddEditBankDtl(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/BankDtllist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{id}/BankDtlEdit.html")]
        public async Task<IActionResult> BankDtlEdit(int id)
        {
            return View(await _BankDtl.ViewEdit(id));
        }

        [HttpGet]
        [Route("/BankDtlEdit.html")]
        public async Task<IActionResult> BankDtlEdit(BankDtlVM model, int id)
        {
            var response = await _BankDtl.AddEditBankDtl(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/BankDtllist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/BankDtlDelete.html")]
        public async Task<IActionResult> BankDtlDelete(int brandId)
        {
            var response = await _BankDtl.DeleteBankDtl(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/BankDtllist.html");
            }
            return View();
        }
    }
}