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
        [Route("/OrgFormDtlFetchData.html")]
        public async Task<JsonResult> OrgFormDtlFetchData(DataTableVm model)
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
        [Route("/OrgFormDtllsit.html")]
        public IActionResult OrgFormDtlList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OrgFormDtlCreate.html")]
        public IActionResult OrgFormDtlCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OrgFormDtlCreate.html")]
        public IActionResult OrgFormDtlCreate(OrgFormDtlVM model)
        {
            return View();
        }
    }
}