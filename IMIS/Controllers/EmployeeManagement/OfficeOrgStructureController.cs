using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.EmployeeManagement.IOfficeOrgStructure;
using IMIS_Service.GlobalFunction;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.EmployeeManagement
{
    public class OfficeOrgStructureController : Controller
    {
        private readonly IOfficeOrgStructure _OfficeOrgStructureService;
        private readonly GlobalFunction _global;
        public OfficeOrgStructureController(IOfficeOrgStructure OfficeOrgStructureService, GlobalFunction global)
        {
            _OfficeOrgStructureService = OfficeOrgStructureService;
            _global = global;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/OfficeOrgStructureTreeFetchData.html")]
        public JsonResult ItemCategoryFetchData(DataTableVm model)
        {
            // var response =  _ItemCategory.ItemCategoriesFetchData1(model);
            //return Json(repo.GetDataTree(id, TreeViewPathProvider.Instance().openedNodes));
            return Json(_OfficeOrgStructureService.OfficeOrgStructureTreeFetchData(model));


        }
        [HttpGet]
        [Route("/OfficeOrgStructurelist.html")]
        public IActionResult OfficeOrgStructureFetchList()
        {
            return View();
        }

        [HttpGet]
        [Route("/{id}/OfficeOrgStructuredatagetfetchdatadatable.html")]
        public async Task<JsonResult> OfficeOrgStructuredatagetfetchdatadatable(DataTableVm model, int id)
        {
            var response = await _OfficeOrgStructureService.OfficeOrgStructureChildDataTabel(model, id);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/{parentid}/OfficeOrgStructureCreate.html")]
        public IActionResult OfficeOrgStructureCreate(int parentid)
        {
            ViewData["ParentOfficeOrgStructure"] = _OfficeOrgStructureService.GetParentOfficeOrgStructure(parentid); //calling the all parent OfficeOrgStructure
            ViewData["georegion"] = _OfficeOrgStructureService.GetGeoRegion();
            return View("_partialOfficeOrgStructure");

        }

        [HttpPost]
        [Route("/OfficeOrgStructureCreate.html")]
        public async Task<IActionResult> OfficeOrgStructureCreate(OfficeOrgStructureVM model)
        {
            var result = await _OfficeOrgStructureService.OfficeOrgStructureAddEdit(model);

            if (result.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/OfficeOrgStructuredatafetchlist.html");
            }
            ViewData["ParentOfficeOrgStructure"] = _OfficeOrgStructureService.GetAllParentOfficeOrgStructure();
            return View();
        }


        [HttpGet]
        [Route("/{parentid}/OfficeOrgStructureEdit.html")]
        public async Task<IActionResult> OfficeOrgStructureEdit(int parentid)
        {
            ViewData["ParentOfficeOrgStructure"] = _OfficeOrgStructureService.GetAllParentOfficeOrgStructure();
            return View("_partialOfficeOrgStructure", await _OfficeOrgStructureService.ViewEdit(parentid));

        }




        [HttpGet]
        [Route("/{parentid}/OfficeOrgStructureTreePartial.html")]
        public IActionResult OfficeOrgStructureTreePartial(int parentid)
        {
            ViewData["parentid"] = parentid;
            return View("_OfficeOrgStructureList");
        }
    }
}