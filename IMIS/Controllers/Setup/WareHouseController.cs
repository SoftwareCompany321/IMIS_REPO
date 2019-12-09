using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class WareHouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}