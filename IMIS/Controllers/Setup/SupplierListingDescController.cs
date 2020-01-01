using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.ISupplierListingDesc;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class SupplierListingDescController : Controller
    {
        private readonly ISupplierListingDesc _SupplierListingDesc;

        public SupplierListingDescController(ISupplierListingDesc SupplierListingDesc)
        {
            _SupplierListingDesc = SupplierListingDesc;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/SupplierListingDescFetchData.html")]
        public async Task<JsonResult> SupplierListingDescFetchData(DataTableVm model)
        {
            var response = await _SupplierListingDesc.SupplierListingDescFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/SupplierListingDesclist.html")]
        public IActionResult SupplierListingDescList()
        {
            return View();
        }

        [HttpGet]
        [Route("/SupplierListingDescCreate.html")]
        public IActionResult SupplierListingDescCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/SupplierListingDescCreate.html")]
        public async Task<IActionResult> SupplierListingDescCreate(SupplierListingDescVM model)
        {
            var response = await _SupplierListingDesc.AddEditSupplierListingDescType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/SupplierListingDesclist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/SupplierListingDescEdit.html")]
        public async Task<IActionResult> SupplierListingDescEdit(decimal id)
        {
            return View(await _SupplierListingDesc.ViewEdit(id));
        }

        [HttpGet]
        [Route("/SupplierListingDescEdit.html")]
        public async Task<IActionResult> SupplierListingDescEdit(SupplierListingDescVM model, int id)
        {
            var response = await _SupplierListingDesc.AddEditSupplierListingDescType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/SupplierListingDesclist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/SupplierListingDescDelete.html")]
        public async Task<IActionResult> SupplierListingDescDelete(int brandId)
        {
            var response = await _SupplierListingDesc.DeleteSupplierListingDescType(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/SupplierListingDesclist.html");
            }
            return View();
        }
    }
}