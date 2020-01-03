using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.ICivilServices;
using IMIS_Service.GlobalFunction;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.EmployeeManagement
{
    public class CivilServicesController : Controller
    {
        private readonly ICivilServices _CivilServicesService;
        private readonly GlobalFunction _global;
        public CivilServicesController(ICivilServices CivilServicesService, GlobalFunction global)
        {
            _CivilServicesService = CivilServicesService;
            _global = global;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/CivilServicesTreeFetchData.html")]
        public JsonResult ItemCategoryFetchData(DataTableVm model)
        {
            // var response =  _ItemCategory.ItemCategoriesFetchData1(model);
            //return Json(repo.GetDataTree(id, TreeViewPathProvider.Instance().openedNodes));
            return Json(_CivilServicesService.CivilServicesTreeFetchData(model));


        }
        [HttpGet]
        [Route("/CivilServiceslist.html")]
        public IActionResult CivilServicesFetchList()
        {
            return View();
        }

        [HttpGet]
        [Route("/{id}/CivilServicesdatagetfetchdatadatable.html")]
        public async Task<JsonResult> CivilServicesdatagetfetchdatadatable(DataTableVm model, int id)
        {
            var response = await _CivilServicesService.CivilServicesChildDataTabel(model, id);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/{id}/CivilServicesCreate.html")]
        public IActionResult CivilServicesCreate(int id)
        {
            ViewData["ParentCivilServices"] = _CivilServicesService.GetParentCivilServices(id); //calling the all parent CivilServices
            return View("_partialCivilServices");

        }

        [HttpPost]
        [Route("/CivilServicesCreate.html")]
        public async Task<IActionResult> CivilServicesCreate(CivilServicesVM model)
        {
            var result = await _CivilServicesService.CivilServicesAddEdit(model);

            if (result.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/CivilServicesdatafetchlist.html");
            }
            ViewData["ParentCivilServices"] = _CivilServicesService.GetAllParentCivilServices();
            return View();
        }


        [HttpGet]
        [Route("/{id}/CivilServicesEdit.html")]
        public async Task<IActionResult> CivilServicesEdit(int id)
        {
            ViewData["ParentCivilServices"] = _CivilServicesService.GetAllParentCivilServices();
            return View("_partialCivilServices", await _CivilServicesService.ViewEdit(id));

        }




        [HttpGet]
        [Route("/{id}/CivilServicesTreePartial.html")]
        public IActionResult CivilServicesTreePartial(int id)
        {
            ViewData["id"] = id;
            return View("_CivilServicesList");
        }

    }
}