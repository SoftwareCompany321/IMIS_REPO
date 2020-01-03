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

namespace IMIS_Service.EmployeeManagement.IOfficeOrgStructure
{
    public interface IOfficeOrgStructure
    {
        Task<(string message, int Id)> OfficeOrgStructureAddEdit(OfficeOrgStructureVM mspOfficeOrgStructure);
        List<TreeViewContainer> OfficeOrgStructureTreeFetchData(DataTableVm model);
        Task<OfficeOrgStructureVM> ViewEdit(int id);
        Task<DataTableResponse> OfficeOrgStructureChildDataTabel(DataTableVm model, int id = 0);
        IEnumerable<SelectListItem> GetAllParentOfficeOrgStructure(int id = 0);
        IEnumerable<SelectListItem> GetParentOfficeOrgStructure(int id = 0);
    }
    public class OfficeOrgStructure : IOfficeOrgStructure
    {
        private readonly IMISDbContext _db;
        private readonly GlobalFunction.GlobalFunction _global;
        public OfficeOrgStructure(IMISDbContext db, GlobalFunction.GlobalFunction global)
        {
            _db = db;
            _global = global;
        }

        public async Task<(string message, int Id)> OfficeOrgStructureAddEdit(OfficeOrgStructureVM mspOfficeOrgStructure)
        {
            var add = new OrganizationTree()
            {
                Code = mspOfficeOrgStructure.Code,
                ParentId = mspOfficeOrgStructure.ParentId,
                NepName = mspOfficeOrgStructure.NepName,
                EngName = mspOfficeOrgStructure.EngName,
                order = mspOfficeOrgStructure.order,
                GrpLevel = mspOfficeOrgStructure.GrpLevel
            };
            try
            {
                int OfficeOrgStructureId = 0;
                if (mspOfficeOrgStructure.Id == 0)
                {


                    await _db.AddAsync(add);
                    await _db.SaveChangesAsync();
                    OfficeOrgStructureId = add.Id;
                }
                else
                {
                    add.Id = mspOfficeOrgStructure.Id;

                    _db.Entry(add).State = EntityState.Modified;
                    OfficeOrgStructureId = mspOfficeOrgStructure.Id;
                    await _db.SaveChangesAsync();
                }
                return ("success", OfficeOrgStructureId);
            }
            catch (Exception ex)
            {
                throw ex;


            }
        }

        public Task<string> OfficeOrgStructureDelete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTableResponse> OfficeOrgStructureChildDataTabel(DataTableVm model, int id = 0)
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


            var OfficeOrgStructurelist = (from nt in _db.OrganizationTree
                                     where nt.ParentId == id
                                     select new
                                     {
                                         nt.Id,
                                         nt.Code,
                                         nt.NepName,
                                         nt.EngName,
                                         nt.order
                                     }).ToList();
            if (OfficeOrgStructurelist.Count > 0)
            {
                totalResultsCount = OfficeOrgStructurelist.Count();
                if (!string.IsNullOrEmpty(searchBy))
                {
                    // OfficeOrgStructurelist = OfficeOrgStructurelist;
                }
                filteredResultsCount = OfficeOrgStructurelist.Count();
            }

            var list = OfficeOrgStructurelist.OrderByDescending(x => x.order).Skip(skip).ToList();

            return new DataTableResponse
            {
                draw = draw,
                TotalRecord = filteredResultsCount,
                FilteredRecord = totalResultsCount,
                data = list
            };
        }
        public List<TreeViewContainer> OfficeOrgStructureTreeFetchData(DataTableVm model)
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
                Datas = (from iic in _db.OrganizationTree
                         select new TreeViewVM
                         {
                             id = iic.Id.ConvertToString(),
                             text = Utils.ToggleLanguage(iic.EngName, iic.NepName),
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
                          where d.parentId == "0"
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

        public async Task<OfficeOrgStructureVM> ViewEdit(int id)
        {
            try
            {
                var data = await _db.OrganizationTree.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    return (new OfficeOrgStructureVM
                    {
                        Id = data.Id,
                        NepName = data.NepName,
                        EngName = data.EngName,
                        ParentId = data.ParentId

                    });
                }
                return (new OfficeOrgStructureVM());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<SelectListItem> GetAllParentOfficeOrgStructure(int id = 0)
        {
            return new SelectList(_db.OrganizationTree.Where(x => x.ParentId == id), "Id", "DisplayName");

        }
        public IEnumerable<SelectListItem> GetParentOfficeOrgStructure(int id = 0)
        {
            return new SelectList(_db.OrganizationTree.Where(x => x.Id == id), "Id", "DisplayName");

        }
    }
}
