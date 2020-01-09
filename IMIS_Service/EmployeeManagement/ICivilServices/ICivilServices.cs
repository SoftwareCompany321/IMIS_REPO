using IMIS_CORE.Core;
using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.EmployeeManagement.ICivilServices
{
    public interface ICivilServices
    {
        Task<(string message, int Id)> CivilServicesAddEdit(CivilServicesVM mspCivilServices);
        List<TreeViewContainer> CivilServicesTreeFetchData(DataTableVm model);
        Task<CivilServicesVM> ViewEdit(int id);
        Task<DataTableResponse> CivilServicesChildDataTabel(DataTableVm model, int id = 0);
        IEnumerable<SelectListItem> GetAllParentCivilServices(int id = 0);
        IEnumerable<SelectListItem> GetParentCivilServices(int id = 0);
    }
    public class CivilServices : ICivilServices
    {
        private readonly IMISDbContext _db;
        private readonly GlobalFunction.GlobalFunction _global;
        public CivilServices(IMISDbContext db, GlobalFunction.GlobalFunction global)
        {
            _db = db;
            _global = global;
        }

        public async Task<(string message, int Id)> CivilServicesAddEdit(CivilServicesVM mspCivilServices)
        {
            var add = new PisNijamatiSewaSamuha()
            {
                Code = mspCivilServices.Code,
                ParentId = (mspCivilServices.ParentId == 0) ? null : mspCivilServices.ParentId,
                NameNp = mspCivilServices.NameNp,
                NameEn = mspCivilServices.NameEn,
                order = mspCivilServices.order,
                GrpLevel = mspCivilServices.GrpLevel
            };
            try
            {
                int CivilServicesId = 0;


                if (mspCivilServices.Id == 0)
                {

                    int id = await _db.PisNijamatiSewaSamuha.CountAsync();
                    add.Id = id + 1;

                    await _db.AddAsync(add);
                    await _db.SaveChangesAsync();
                    CivilServicesId = add.Id;
                }
                else
                {
                    add.Id = mspCivilServices.Id;

                    _db.Entry(add).State = EntityState.Modified;
                    CivilServicesId = mspCivilServices.Id;
                    await _db.SaveChangesAsync();
                }
                return ("success", CivilServicesId);
            }
            catch (Exception ex)
            {
                throw ex;


            }
        }

        public Task<string> CivilServicesDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTableResponse> CivilServicesChildDataTabel(DataTableVm model, int id = 0)
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


            var CivilServiceslist = (from nt in _db.PisNijamatiSewaSamuha
                                     where nt.ParentId == id
                                     select new
                                     {
                                         nt.Id,
                                         nt.Code,
                                         nt.NameNp,
                                         nt.NameEn,
                                         nt.order
                                     }).ToList();
            if (CivilServiceslist.Count > 0)
            {
                totalResultsCount = CivilServiceslist.Count();
                if (!string.IsNullOrEmpty(searchBy))
                {
                    // CivilServiceslist = CivilServiceslist;
                }
                filteredResultsCount = CivilServiceslist.Count();
            }

            var list = CivilServiceslist.OrderByDescending(x => x.order).Skip(skip).ToList();

            return new DataTableResponse
            {
                draw = draw,
                TotalRecord = filteredResultsCount,
                FilteredRecord = totalResultsCount,
                data = list
            };
        }
        public List<TreeViewContainer> CivilServicesTreeFetchData(DataTableVm model)
        {
            string searchBy = string.Empty;
            int skip = 0;
            int take = 10;
            int draw = 0;
            List<TreeViewContainer> result = new List<TreeViewContainer>();
            List<TreeViewVM> Datas = new List<TreeViewVM>();
            try
            {
                if (model != null)
                {
                    searchBy = searchBy = !string.IsNullOrEmpty(model.search) ? model.search.Trim() : "";
                    take = model.length;
                    skip = model.start;
                    draw = model.draw;
                }
                Datas = (from iic in _db.PisNijamatiSewaSamuha
                         select new TreeViewVM
                         {
                             id = iic.Id.ConvertToString(),
                             text = Utils.ToggleLanguage(iic.NameEn, iic.NameNp),
                             parentId = iic.ParentId.ConvertToString(),
                         }).ToList();
                if (Datas.Count < 1)
                {
                    TreeViewVM tvm = new TreeViewVM();
                    tvm.text = Utils.GetLabel("Root");
                    tvm.id = "null";
                    tvm.parentId = "0";
                    Datas.Add(tvm);
                }

                result = (from d in Datas
                          where (d.parentId == "0" || d.parentId == "")
                          select (new TreeViewContainer()
                          {
                              text = d.text,
                              id = d.id,
                              parentId = null,
                              state = new { d.opened },
                              opened = d.opened,
                              a_attr = new { href = "#", onclick = "loadchildlist('" + d.id + "');", }
                          }).AddChildrens(Datas, 0)).ToList();



            }
            catch (Exception)
            {

            }
            return result;
        }
        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }

        public async Task<CivilServicesVM> ViewEdit(int id)
        {
            try
            {
                var data = await _db.PisNijamatiSewaSamuha.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    return (new CivilServicesVM
                    {
                        Id = data.Id,
                        NameNp = data.NameNp,
                        NameEn = data.NameEn,
                        ParentId = data.ParentId

                    });
                }
                return (new CivilServicesVM());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<SelectListItem> GetAllParentCivilServices(int id = 0)
        {
            return new SelectList(_db.PisNijamatiSewaSamuha.Where(x => x.ParentId == id), "Id", Utils.ToggleLanguage("NameEn", "NameNp"));

        }
        public IEnumerable<SelectListItem> GetParentCivilServices(int id = 0)
        {
            return new SelectList(_db.PisNijamatiSewaSamuha.Where(x => x.Id == id), "Id", Utils.ToggleLanguage("NameEn", "NameNp"));

        }
    }
}
