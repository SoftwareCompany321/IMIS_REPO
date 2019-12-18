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

        [HttpGet]
        [Route("{languageset}/ChangeStatus.html")]
        public async Task<IActionResult> ChangeStatus(string Languageset)
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
            string url = Request.Headers["Referer"].ToString();
            string returnUrl = string.Empty;
            Uri baseUri = new Uri(url);
            if (baseUri.LocalPath != null)
                returnUrl = baseUri.LocalPath;

             returnUrl = returnUrl ?? Url.Content("~/");
            return LocalRedirect(returnUrl);

        }

    }
}
