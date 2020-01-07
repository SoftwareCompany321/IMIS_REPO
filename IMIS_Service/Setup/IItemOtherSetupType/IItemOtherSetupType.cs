using ExceptionHandler;
using IMIS_CORE.Core;
using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IItemOtherSetupType
{
    public interface IItemOtherSetupType
    {
        Task<DataTableResponse> ItemOtherSetupTypeFetchData(DataTableVm model, int id);
        Task<(string message, int id)> AddEditItemOtherSetupType(ItemOtherSetupTypeVM model);
        List<TreeViewContainer> ItemOtherSetupTypeFetchTreeData(DataTableVm model);
        Task<(string message, int Id)> DeleteItemOtherSetupType(int UnitId);
        Task<ItemOtherSetupTypeVM> ViewEdit(decimal Id);

    }
    public class ItemOtherSetupType : IItemOtherSetupType
    {
        private readonly IMISDbContext _db;
        public ItemOtherSetupType(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> ItemOtherSetupTypeFetchData(DataTableVm model, int id)
        {
            string searchBy = string.Empty;
            int skip = 0;
            int take = 10;
            int totalResultsCount = 0;
            int filteredResultsCount = 0;
            int draw = 0;

            try
            {

                if (model != null)
                {
                    searchBy = searchBy = !string.IsNullOrEmpty(model.search) ? model.search.Trim() : "";
                    take = model.length;
                    skip = model.start;
                    draw = model.draw;
                }

                var accMasters =  (from its in _db.InvTypeSetup
                                   where its.IsActive == true && its.TypeId==id
                                   select new
                                        {
                                            its.Id,
                                            its.DescEn,
                                            its.DescNp ,
                                            its.Code
                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.DescNp == searchBy || x.DescEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Id).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data =finallist
                };


            }
            catch (Exception )
            {
                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data =0
                };
                //add to do for the error log save in db
            }
        }

        public List<TreeViewContainer> ItemOtherSetupTypeFetchTreeData(DataTableVm model)
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
                TreeViewVM tvm = new TreeViewVM();
                tvm.id = "1";
                tvm.text = Utils.ToggleLanguage("Item Status Type", "सामान अवस्था किसिम");
                tvm.parentId = "0";
                Datas.Add(tvm);
                tvm = new TreeViewVM();
                tvm.id = "2";
                tvm.text = Utils.ToggleLanguage("Item Nature Type", "सामान प्रकृति किसिम");
                tvm.parentId = "0";
                Datas.Add(tvm);
                tvm = new TreeViewVM();
                tvm.id = "3";
                tvm.text = Utils.ToggleLanguage("Item Requisition Type", "सामान माग किसिम");
                tvm.parentId = "0";
                Datas.Add(tvm);
                tvm = new TreeViewVM();
                tvm.id = "4";
                tvm.text = Utils.ToggleLanguage("Item Main Type", "सामानको मुख्य किसिम");
                tvm.parentId = "0";
                Datas.Add(tvm);
                tvm = new TreeViewVM();
                tvm.id = "5";
                tvm.text = Utils.ToggleLanguage("Budget Type", "बजेट किसिम");
                tvm.parentId = "0";
                Datas.Add(tvm);

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
        public async Task<(string message, int id)> AddEditItemOtherSetupType(ItemOtherSetupTypeVM model)
        {
            try
            {
                var item = new InvTypeSetup()
                {
                    Id = model.Id,
                    DescEn = model.DescEn,
                    DescNp = model.DescNp,
                    TypeId=model.TypeId,
                    Code=model.Code,
                    IsActive=model.IsActive
                };
                if (model.Id == 0)
                {
                    int id = await _db.InvTypeSetup.CountAsync();
                    item.Id = id + 1;
                    _db.InvTypeSetup.AddRange(item);
                }
                else
                {
                    _db.Entry(item).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);

                return ("success", 0);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<ItemOtherSetupTypeVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvTypeSetup.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new ItemOtherSetupTypeVM()
                    {
                        Id = response.Id,
                        DescEn = response.DescEn,
                        DescNp = response.DescNp ,
                        TypeId=response.TypeId,
                        IsActive=response.IsActive,
                        Code=response.Code

                    });
                }
                else
                {
                    return new ItemOtherSetupTypeVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteItemOtherSetupType(int ItemOtherSetupTypeid)
        {
            try
            {
                var data = _db.InvTypeSetup.Where(x => x.Id == ItemOtherSetupTypeid).FirstOrDefault();
                if (data != null)
                {
                    data.IsActive = false;
                    _db.Entry(data).State = EntityState.Modified;

                }
                await _db.SaveChangesAsync(true);
                return ("success", 0);
            }
            catch (Exception ex)
            {
                ExceptionManager.AppendLog(ex);
                throw;
            }

        }
    }
}
