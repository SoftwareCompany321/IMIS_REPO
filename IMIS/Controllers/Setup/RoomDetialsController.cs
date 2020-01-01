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
        public async Task<IActionResult> RoomDetialsCreate(RoomDetialsVM model)
        {
            var response = await _RoomDetials.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/RoomDetialsList.html");
            }
            return View();
        }
        [HttpGet]

        [Route("{SpecificationId}/RoomDetialsEdit.html")]
        public async Task<IActionResult> RoomDetialsEdit(int SpecificationId)
        {
            return View(await _RoomDetials.ViewOrEditData(SpecificationId));
        }
        [HttpPost]
        [Route("{SpecificationId}/RoomDetialsEdit.html")]
        public async Task<IActionResult> RoomDetialsEdit(RoomDetialsVM model, int SpecificationId)
        {
            var response = await _RoomDetials.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/RoomDetialslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{brandId}/RoomDetialsDelete.html")]
        public async Task<IActionResult> RoomDetialsDelete(int brandId)
        {
            var response = await _RoomDetials.DeleteRoomDetials(brandId);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/RoomDetialslist.html");
            }
            return View();
        }
    }
}