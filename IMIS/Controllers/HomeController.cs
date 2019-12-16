using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IMIS.Models;
using Microsoft.AspNetCore.Authorization;
using App.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;

namespace IMIS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ChangeStatus(string Languageset)
        {
            if (Languageset == "English")
            {
                AppHttpContext.Current.Session.SetString("LanguageSetting", "Nepali");
            }
            else
            {
                AppHttpContext.Current.Session.SetString("LanguageSetting", "English"); 
            }
            //string url = Request.Headers["Referer"].ToString();
            string url = Request.HttpContext.Request.Path ;
            //string url = HttpContext.Request.UrlReferrer.AbsoluteUri;
            if (url != null)
                return Redirect(url.ToString());
            //else if (url.ToString().Segments.Length >= 3)
            //    return RedirectToAction(Request.UrlReferrer.Segments[2].Replace("/", ""), Request.UrlReferrer.Segments[1].Replace("/", ""));
            else
                return RedirectToAction("Dashboard", "Dashboard");
            //return RedirectToAction("Dashboard", "Dashboard");
        }

    }
}
