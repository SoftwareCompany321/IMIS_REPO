using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IInvAdujType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class InvAdujTypeController : Controller
    {
        private readonly IInvAdujType _InvAdujType;

        public InvAdujTypeController(IInvAdujType InvAdujType)
        {
            _InvAdujType = InvAdujType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/InvAdujTypeFetchData.html")]
        public async Task<JsonResult> InvAdujTypeFetchData(DataTableVm model)
        {
            var response = await _InvAdujType.InvAdujTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/InvAdujTypelist.html")]
        public IActionResult InvAdujTypeList()
        {
            return View();
        }

        [HttpGet]
        [Route("/InvAdujTypeCreate.html")]
        public IActionResult InvAdujTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/InvAdujTypeCreate.html")]
        public IActionResult InvAdujTypeCreate(InvAdujTypeVM model)
        {
            return View();
        }
    }
}