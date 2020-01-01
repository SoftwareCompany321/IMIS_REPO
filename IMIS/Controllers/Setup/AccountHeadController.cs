using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.IAccountHead;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    [Authorize]
    public class AccountHeadController : Controller
    {
        private readonly IAccountHead _accountHead;

        public AccountHeadController(IAccountHead accountHead)
        {
            _accountHead = accountHead;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/AccountHeaderFetchData.html")]
        public async Task<JsonResult> AccountHeaderFetchData(DataTableVm model)
        {
            var response = await _accountHead.AccountHeadFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/accountheaderlist.html")] 
        public IActionResult AccountHeaderList()
        {
            return View();
        }

        [HttpGet]
        [Route("/AccountHeaderCreate.html")]
        public IActionResult AccountHeaderCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/AccountHeaderCreate.html")]
        public IActionResult AccountHeaderCreate(AccountHeaderVM model)
        {
            return View();
        }

        [HttpGet]
        [Route("/{id}/AccountHeaderEdit.html")]
        public IActionResult AccountHeaderEdit(int id)
        {
            return View();
        }
        [HttpPost]
        [Route("/AccountHeaderEdit.html")]
        public IActionResult AccountHeaderEdit(AccountHeaderVM model)
        {
            return View();
        }

        [HttpGet]
        [Route("/{id}/AccountHeaderDelete.html")]
        public IActionResult AccountHeaderDelete(int id)
        {
            return View();
        } 
    }
}