using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using Microsoft.EntityFrameworkCore;
using MSP_Service.DatatableModel;
using MSP_Service.GlobalFunc;
using MSP_Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.IMenuService
{

    public interface IMenuService
    {
        //Task<IList<Userassignments>> MspMenus();

        //Task<(string message, int Id)> MenuAdd(MenuVM mspMenu);

        //Task<string> MenuDelete(int id);
        //Task<IList<Userassignments>> MspSubMenu(int id);

        Task<IList<Userassignments>> menuVM();

       // Task<DataTableResponse> MenuDataTabel(DataTableM model);

    }

    public class MenuService : IMenuService, IDisposable
    {
        private readonly IMISDbContext _db;
       
        public MenuService(IMISDbContext db)
        {
            _db = db;
           
        }
        //public async Task<(string message, int Id)> MenuAdd(MenuVM mspMenu)
        //{
        //    var add = new MspMenu()
        //    {
        //        MenuName = mspMenu.MenuName,
        //        Active = mspMenu.Active,
        //        DisplayName = mspMenu.DisplayName,
        //        IsLocked = mspMenu.IsLocked,
        //        MenuOrder = mspMenu.MenuOrder,
        //        ParentMenuId = mspMenu.ParentMenuId,
        //        Icon = mspMenu.Icon,
        //        Visible = mspMenu.Visible

        //    };
        //    try
        //    {
        //        int menuId = 0;
        //        if (mspMenu.Id == 0)
        //        {
        //            add.CreatedAt = DateTime.UtcNow;
        //            add.CreatedBy = _gf.getUserId();
        //            //_db.Entry(add).State = EntityState.Added;
        //            await _db.SaveChangesAsync();
        //            menuId = add.Id;
        //        }
        //        else
        //        {
        //            add.Id = mspMenu.Id;
        //            add.UpdateAt = DateTime.UtcNow;
        //            add.UpdateBy = _gf.getUserId();
        //            //_db.Update(add);
        //            _db.Entry(add).State = EntityState.Modified;
        //            menuId = mspMenu.Id;
        //            await _db.SaveChangesAsync();
        //        }
        //        return ("success", menuId);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ("fail", 0);

        //    }


        //}

        public Task<string> MenuDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Userassignments>> menuVM()
        {
            //for the query of menu and sub menu
            //Note m=mainmenu  and   s=submenu 
            return( await _db.Userassignments.ToListAsync());
        }

        //public async Task<IList<MspMenu>> MspMenus()
        //{
        //    return (await _db.MspMenus.Where(x => x.ParentMenuId == 0).ToListAsync());
        //}

        //public async Task<IList<MspMenu>> MspSubMenu(int id)
        //{

        //    return (await _db.MspMenus.Where(x => x.ParentMenuId == id).ToListAsync());


        //}

        //public async Task<DataTableResponse> MenuDataTabel(DataTableM model)
        //{
        //    string searchBy = string.Empty;
        //    int skip = 0;
        //    int take = 10;
        //    int totalResultsCount = 0;
        //    int filteredResultsCount = 0;
        //    int draw = 0;

        //    if (model != null)
        //    {
        //        searchBy = searchBy = !string.IsNullOrEmpty(model.search) ? model.search.Trim() : "";
        //        take = model.length;
        //        skip = model.start;
        //        draw = model.draw;
        //    }

        //    var menuList = (from d in _db.MspMenus
        //                    select new
        //                    {
        //                        d.MenuName,
        //                        d.Visible,
        //                        d.DisplayName,
        //                        d.Active,
        //                        d.MenuUrl,
        //                        d.CreatedAt,
        //                        d.Id,
        //                        d.Icon
        //                    });
        //    ///filter count for the total; record
        //    ///

        //    if (menuList != null)
        //    {
        //        totalResultsCount = await menuList.CountAsync();
        //        if (!string.IsNullOrEmpty(searchBy))
        //        {
        //            menuList = menuList.Where(x => x.DisplayName == searchBy).OrderByDescending(x => x.CreatedAt);
        //        }
        //        filteredResultsCount = await menuList.CountAsync();
        //    }

        //    var list = menuList.OrderByDescending(x => x.CreatedAt).Skip(skip).ToListAsync();

        //    return new DataTableResponse
        //    {
        //        draw = draw,
        //        TotalRecord = filteredResultsCount,
        //        FilteredRecord = totalResultsCount,
        //        data = list.Result
        //    };
        //}

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }
    }
}