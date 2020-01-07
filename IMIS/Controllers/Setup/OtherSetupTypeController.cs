using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Core;
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
        [Route("/OtherSetupTypeFetchTreeData.html")]
        public JsonResult OtherSetupTypeFetchTreeData(DataTableVm model)
        {

            return Json(_OtherSetupType.ItemOtherSetupTypeFetchTreeData(model));


        }
        [HttpGet]
        [Route("/{typeid}/OtherSetupTypeFetchData.html")]
        public async Task<JsonResult> OtherSetupTypeFetchData(DataTableVm model, int typeid)
        {
            var response = await _OtherSetupType.ItemOtherSetupTypeFetchData(model, typeid);
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
        [Route("/{typeid}/OtherSetupTypeCreate.html")]
        public IActionResult OtherSetupTypeCreate(int typeid)
        {
            var item = new ItemOtherSetupTypeVM();
            item.TypeId = typeid;
            item.type = GetType(typeid);
            return View("_partialOtherSetupType",item);
        }


        [HttpPost]
        [Route("/OtherSetupTypeCreate.html")]
        public async Task<IActionResult> OtherSetupTypeCreate(ItemOtherSetupTypeVM model)
        {
            var response = await _OtherSetupType.AddEditItemOtherSetupType(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OtherSetupTypelist.html");
            }
            return View();
        }


        [HttpGet]
        [Route("{typeid}/OtherSetupTypeDelete.html")]
        public async Task<IActionResult> OtherSetupTypeDelete(int typeid)
        {
            var response = await _OtherSetupType.DeleteItemOtherSetupType(typeid);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OtherSetupTypelist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("/{typeid}/OtherSetupTypePartial.html")]
        public IActionResult OtherSetupTypePartial(int typeid)
        {
            ViewData["typeid"] = typeid;
            return View("_OtherSetupTypeList");
        }

        private string GetType(int id)
        {
            string typename = "";
            if (id == 1)
                typename = Utils.ToggleLanguage("Item Status Type", "सामान अवस्था किसिम");
            if (id == 2)
                typename = Utils.ToggleLanguage("Item Nature Type", "सामान प्रकृति किसिम");
            if (id == 3)
                typename = Utils.ToggleLanguage("Item Requisition Type", "सामान माग किसिम");
            if (id == 4)
                typename = Utils.ToggleLanguage("Item Main Type", "सामानको मुख्य किसिम");
            if (id == 5)
                typename = Utils.ToggleLanguage("Budget Type", "बजेट किसिम");
            return typename;
        }
    }
}