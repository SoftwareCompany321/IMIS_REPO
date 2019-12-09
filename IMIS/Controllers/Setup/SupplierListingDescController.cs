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
        [Route("/SupplierListingDesclsit.html")]
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
        public IActionResult SupplierListingDescCreate(SupplierListingDescVM model)
        {
            return View();
        }
    }
}