using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemSupplierDtl;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemSupplierDtlController : Controller
    {
        private readonly IItemSupplierDtl _ItemSupplierDtl;

        public ItemSupplierDtlController(IItemSupplierDtl ItemSupplierDtl)
        {
            _ItemSupplierDtl = ItemSupplierDtl;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemSupplierDtlFetchData.html")]
        public async Task<JsonResult> ItemSupplierDtlFetchData(DataTableVm model)
        {
            var response = await _ItemSupplierDtl.ItemSupplierDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemSupplierDtllsit.html")]
        public IActionResult ItemSupplierDtlList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemSupplierDtlCreate.html")]
        public IActionResult ItemSupplierDtlCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemSupplierDtlCreate.html")]
        public IActionResult ItemSupplierDtlCreate(ItemSupplierDtlVM model)
        {
            return View();
        }
    }
}