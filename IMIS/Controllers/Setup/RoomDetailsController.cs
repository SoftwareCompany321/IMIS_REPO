using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IRoomDetails;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class RoomDetailsController : Controller
    {
        private readonly IRoomDetails _RoomDetails;

        public RoomDetailsController(IRoomDetails RoomDetails)
        {
            _RoomDetails = RoomDetails;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/RoomDetailsFetchData.html")]
        public async Task<JsonResult> RoomDetailsFetchData(DataTableVm model)
        {
            var response = await _RoomDetails.RoomDetailsFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/RoomDetailslist.html")]
        public IActionResult RoomDetailsList()
        {
            return View();
        }

        [HttpGet]
        [Route("/RoomDetailsCreate.html")]
        public IActionResult RoomDetailsCreate()
        {
            ViewData["departments"] = _RoomDetails.GetDepartmentList();
            return View();
        }

        
        [HttpPost]
        [Route("/RoomDetailsCreate.html")]
        public async Task<IActionResult> RoomDetailsCreate(RoomDetailsVM model)
        {
            var response = await _RoomDetails.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/RoomDetailsList.html");
            }
            return View();
        }
        [HttpGet]

        [Route("{SpecificationId}/RoomDetailsEdit.html")]
        public async Task<IActionResult> RoomDetailsEdit(int SpecificationId)
        {
            ViewData["departments"] = _RoomDetails.GetDepartmentList();
            return View(await _RoomDetails.ViewOrEditData(SpecificationId));
        }
        [HttpPost]
        [Route("{SpecificationId}/RoomDetailsEdit.html")]
        public async Task<IActionResult> RoomDetailsEdit(RoomDetailsVM model, int SpecificationId)
        {
            var response = await _RoomDetails.AddEdit(model);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Added";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/RoomDetailslist.html");
            }
            return View();
        }

        [HttpGet]
        [Route("{roomid}/RoomDetailsDelete.html")]
        public async Task<IActionResult> RoomDetailsDelete(int roomid)
        {
            var response = await _RoomDetails.DeleteRoomDetails(roomid);
            if (response.message == "success")
            {
                TempData["Message"] = "Successfully Deleted";
                TempData["Class"] = "alert alert-success ";
                return Redirect("~/RoomDetailslist.html");
            }
            return View();
        }

    }
}