using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemOtherSetupType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class OtherSetupTypeController : Controller
    {
        private readonly IItemOtherSetupType _OtherSetupType;

        public OtherSetupTypeController(IItemOtherSetupType OtherSetupType)
        {
            _OtherSetupType = OtherSetupType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OtherSetupTypeFetchData.html")]
        public async Task<JsonResult> OtherSetupTypeFetchData(DataTableVm model)
        {
            var response = await _OtherSetupType.ItemOtherSetupTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]        
        [Route("/OtherSetupTypelist.html")]
        public IActionResult OtherSetupTypeList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OtherSetupTypeCreate.html")]
        public IActionResult OtherSetupTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OtherSetupTypeCreate.html")]
        public IActionResult OtherSetupTypeCreate(ItemOtherSetupTypeVM model)
        {
            return View();
        }
    }
}