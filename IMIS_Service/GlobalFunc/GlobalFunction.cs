using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace MSP_Service.GlobalFunc
{
    public class GlobalFunction
    {
        private readonly IHttpContextAccessor _httpCA = null;
        public GlobalFunction(IHttpContextAccessor httpContextAccessor)
        {
            _httpCA = httpContextAccessor;
        }
        public string getUserId()
        {
            return (_httpCA.HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).FirstOrDefault());
        }

        public string getUserName(string userid = "")
        {
            return (_httpCA.HttpContext.User.Identity.Name);
        }
    }
}
