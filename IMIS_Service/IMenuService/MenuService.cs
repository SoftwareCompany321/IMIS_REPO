using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMIS_Service.IMenuService
{

    public interface IMenuService
    {
        Task<(string message, int Id)> MenuAddEdit(MenuVM mspMenu);
        Task<IList<MenuVM>> menuVM();
        Task<DataTableResponse> MenuDataTabel(DataTableVm model);

    }

    public class MenuService : IMenuService, IDisposable
    {
        private readonly IMISDbContext _db;
        private readonly GlobalFunction.GlobalFunction _global;
        public MenuService(IMISDbContext db, GlobalFunction.GlobalFunction global)
        {
            _db = db;
            _global = global;
        }

        public async Task<IList<MenuVM>> menuVM()
        {
            //for the query of menu and sub menu
            //Note m=mainmenu  and   s=submenu 

            try
            {
                return (await (from m in _db.ImisMenu
                               where m.ParentMenuId == 0
                               select new MenuVM
                               {
                                   DisplayName = m.DisplayName,
                                   MenuUrl = m.MenuUrl,
                                   NepName=m.DisplayNepName,
                                   MenuSubMenu = (from s in _db.ImisMenu
                                                  where s.ParentMenuId == m.Id
                                                  select new MenuSubMenuVM
                                                  {
                                                      DisplayName = s.DisplayName,
                                                      MenuUrl = s.MenuUrl,
                                                      NepName=s.DisplayNepName
                                                  }).ToList()
                               }).ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public async Task<(string message, int Id)> MenuAddEdit(MenuVM mspMenu)
        {
            var add = new ImisMenu()
            {
                MenuName = mspMenu.MenuName,
                Active = mspMenu.Active,
                DisplayName = mspMenu.DisplayName,
                IsLocked = mspMenu.IsLocked,
                MenuOrder = mspMenu.MenuOrder,
                ParentMenuId = mspMenu.ParentMenuId,
                Icon = mspMenu.Icon,
                DisplayNepName=mspMenu.NepName,
                Visible = mspMenu.Visible
            };
            try
            {
                int menuId = 0;
                if (mspMenu.Id == 0)
                {
                    int count = await _db.ImisMenu.CountAsync();
                    add.Id = count + 1;
                    add.CreatedAt = DateTime.Now;
                    add.CreatedBy = _global.getUserId();
                    await _db.AddAsync(add);
                    await _db.SaveChangesAsync();
                    menuId = add.Id;
                }
                else
                {
                    add.Id = mspMenu.Id;
                    add.UpdatedAt = DateTime.Now;
                    add.UpdateBy = _global.getUserId();
                    //_db.Update(add);
                    _db.Entry(add).State = EntityState.Modified;
                    menuId = mspMenu.Id;
                    await _db.SaveChangesAsync();
                }
                return ("success", menuId);
            }
            catch (Exception ex)
            {
                return ("fail", 0);

            }
        }

        public Task<string> MenuDelete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<DataTableResponse> MenuDataTabel(DataTableVm model)
        {
            string searchBy = string.Empty;
            int skip = 0;
            int take = 10;
            int totalResultsCount = 0;
            int filteredResultsCount = 0;
            int draw = 0;

            if (model != null)
            {
                searchBy = searchBy = !string.IsNullOrEmpty(model.search) ? model.search.Trim() : "";
                take = model.length;
                skip = model.start;
                draw = model.draw;
            }

            var menulist = await menuVM(); //calling the function for the all the menu item

            if (menulist.Count > 0)
            {
                totalResultsCount = menulist.Count();
                if (!string.IsNullOrEmpty(searchBy))
                {
                    // menulist = menulist;
                }
                filteredResultsCount = menulist.Count();
            }

            var list = menulist.OrderByDescending(x => x.CreatedAt).Skip(skip).ToList();

            return new DataTableResponse
            {
                draw = draw,
                TotalRecord = filteredResultsCount,
                FilteredRecord = totalResultsCount,
                data = list
            };
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }
    }
}