using IMIS_CORE.Core;
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


        //Item Unit
        public List<SelectListItem> UnitList()
        {
            var unitlist = new List<SelectListItem>();

            var list = (from unit in _db.InvUnit
                        where unit.IsActive == true
                        select new { Id = unit.UnitId, Text = Utils.ToggleLanguage(unit.DescEn, unit.DescNp) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }
        //End of Item Unit
        //Item Brand

        //end of Item Brand

        //Item Specification

        //End of Item Specification

        //Item Category
        public List<SelectListItem> ItemCategroyList()
        {
            var unitlist = new List<SelectListItem>();

            var list = (from ivt in _db.InvItemCategory
                        where (ivt.ParentId == null || ivt.ParentId == 0) && ivt.IsActive==true
                        select new { Id = ivt.Id, Text = Utils.ToggleLanguage(ivt.NameEn, ivt.NameNp) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }
        public List<SelectListItem> ItemSubCategroyList(int id = 0)
        {
            var unitlist = new List<SelectListItem>();
            //Need to change logic for subcategory
            var list = (from ivt in _db.InvItemCategory
                        where ivt.IsActive==true// ivt.ParentId == id
                        select new { Id = ivt.Id, Text = Utils.ToggleLanguage(ivt.NameEn, ivt.NameNp) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }
        //End of Item Category

        //Other Setup
        public List<SelectListItem> OthersetupList(int typeid)
        {
            var unitlist = new List<SelectListItem>();

            var list = (from its in _db.InvTypeSetup
                        where its.TypeId == typeid && its.IsActive == true
                        select new { Id = its.Id, Text = Utils.ToggleLanguage(its.DescEn, its.DescNp) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    unitlist.Add(selectListItem);
                }
            }
            return unitlist;
        }

        //End of OtherSetup

        //CountryList
        public List<SelectListItem> CountryList()
        {
            var fuellist = new List<SelectListItem>();

            var list = (from nt in _db.Nationalities
                        select new { Id = nt.Code, Text = Utils.ToggleLanguage(nt.Engname, nt.Nepname) }).ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Text,
                        Value = item.Id.ToString()
                    };
                    fuellist.Add(selectListItem);
                }
            }
            return fuellist;
        }
        //Endof Country List
    }
}
