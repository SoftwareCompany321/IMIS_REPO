using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IRoomDetials;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class RoomDetialsController : Controller
    {
        private readonly IRoomDetials _RoomDetials;

        public RoomDetialsController(IRoomDetials RoomDetials)
        {
            _RoomDetials = RoomDetials;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/RoomDetialsFetchData.html")]
        public async Task<JsonResult> RoomDetialsFetchData(DataTableVm model)
        {
            var response = await _RoomDetials.RoomDetialsFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/RoomDetialslist.html")]
        public IActionResult RoomDetialsList()
        {
            return View();
        }

        [HttpGet]
        [Route("/RoomDetialsCreate.html")]
        public IActionResult RoomDetialsCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/RoomDetialsCreate.html")]
        public IActionResult RoomDetialsCreate(RoomDetialsVM model)
        {
            return View();
        }
    }
}