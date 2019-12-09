using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IOrgFormDtl;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class OrgFormDtlController : Controller
    {
        private readonly IOrgFormDtl _OrgFormDtl;

        public OrgFormDtlController(IOrgFormDtl OrgFormDtl)
        {
            _OrgFormDtl = OrgFormDtl;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrgFormDtlerFetchData.html")]
        public async Task<JsonResult> OrgFormDtlerFetchData(DataTableVm model)
        {
            var response = await _OrgFormDtl.OrgFormDtlFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/OrgFormDtlerlsit.html")]
        public IActionResult OrgFormDtlerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrgFormDtlerCreate.html")]
        public IActionResult OrgFormDtlerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OrgFormDtlerCreate.html")]
        public IActionResult OrgFormDtlerCreate(OrgFormDtlVM model)
        {
            return View();
        }
    }
}