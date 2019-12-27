using IMIS_DataEntity.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace IMIS_Service.GlobalFunction
{

    public class GlobalFunction
    {
        private readonly IHttpContextAccessor _httpCA = null;

        private readonly IMISDbContext _db;
        public GlobalFunction(IHttpContextAccessor httpContextAccessor, IMISDbContext db)
        {
            _httpCA = httpContextAccessor;
            _db = db;
        }
        public string getUserId()
        {
            return (_httpCA.HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).FirstOrDefault());
        }

        public string getUserName(string userid = "")
        {
            return (_httpCA.HttpContext.User.Identity.Name);
        }

        public IEnumerable<SelectListItem> GetAllParentMenu(int id = 0)
        {
            return new SelectList(_db.ImisMenu.Where(x => x.ParentMenuId == id), "Id", "DisplayName");

        }
        public IEnumerable<SelectListItem> GetParentMenu(int id = 0)
        {
            return new SelectList(_db.ImisMenu.Where(x => x.Id == id), "Id", "DisplayName");

        }
    }
}
