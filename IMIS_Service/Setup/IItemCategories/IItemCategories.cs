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

namespace IMIS_Service.Setup.IItemCategories
{
    public interface IItemCategories
    {
        Task<DataTableResponse> ItemCategoriesFetchData(DataTableVm model);
        List<TreeViewContainer> ItemCategoriesFetchData1(DataTableVm model);
        Task<(string message, int id)> AddEditItemCategories(ItemCategoriesVM model);

        Task<ItemCategoriesVM> ViewEdit(int Id);
    }
    public class ItemCategories : IItemCategories
    {
        private readonly IMISDbContext _db;
        public ItemCategories(IMISDbContext db)
        {
            _db = db;
        }

        public async Task<(string message, int id)> AddEditItemCategories(ItemCategoriesVM model)
        {
            try
            {
                var item = new InvItemCategory()
                {
                    Id = model.Id,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp,
                    ParentId = model.ParentId ?? 0,
                    Rminl = model.Rminl,
                    Rmaxl = model.Rmaxl,
                    Code = model.Code,
                    Isexp = model.Isexp == true ? Convert.ToSByte(1) : Convert.ToSByte(0),
                    DepreciationMax = model.DepreciationMax,
                    DepreciationMin = model.DepreciationMin,
                    DepreciationPer = model.DepreciationPer
                };
                if (model.Id == 0)
                {
                    int id = await _db.InvItemCategory.CountAsync();
                    item.Id = id + 1;
                    _db.InvItemCategory.AddRange(item);
                }
                else
                {
                    _db.Entry(item).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);

                return ("success", 0);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DataTableResponse> ItemCategoriesFetchData(DataTableVm model)
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
                var accMasters = (from iic in _db.InvItemCategory
                                  where iic.ParentId == 0
                                  select new ItemCategoriesVM
                                  {
                                      Id = iic.Id,
                                      NameEn = iic.NameEn,
                                      NameNp = iic.NameNp,
                                      Code = iic.Code,
                                      Rminl = iic.Rminl,
                                      Rmaxl = iic.Rmaxl,

                                      itemCatSub = (from s in _db.InvItemCategory
                                                    where s.ParentId == iic.Id
                                                    select new ItemCatSub
                                                    {
                                                        Id = s.Id,
                                                        NameEn = s.NameEn,
                                                        NameNp = s.NameNp,
                                                        Code = s.Code,
                                                        Rminl = s.Rminl,
                                                        Rmaxl = s.Rmaxl,

                                                    }).ToList()

                                  });
                ///filter count for the total; record
                ///
                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters = accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
                    }
                    filteredResultsCount = await accMasters.CountAsync();
                }

                var finallist = await accMasters.OrderByDescending(x => x.Id).Skip(skip).ToListAsync();

                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = finallist
                };


            }
            catch (Exception)
            {
                return new DataTableResponse
                {
                    draw = draw,
                    TotalRecord = filteredResultsCount,
                    FilteredRecord = totalResultsCount,
                    data = 0
                };
                //add to do for the error log save in db
            }
        }
        public List<TreeViewContainer> ItemCategoriesFetchData1(DataTableVm model)
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
                Datas = (from iic in _db.InvItemCategory
                         select new TreeViewVM
                         {
                             id = iic.Id.ConvertToString(),
                             text = Utils.ToggleLanguage(iic.NameEn, iic.NameNp),
                             parentId = iic.ParentId.ConvertToString(),
                         }).ToList();



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
        public async Task<ItemCategoriesVM> ViewEdit(int Id)
        {
            try
            {
                var response = await _db.InvItemCategory.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new ItemCategoriesVM()
                    {
                        Id = response.Id,
                        Code = response.Code,
                        DepreciationMax = response.DepreciationMax,
                        DepreciationMin = response.DepreciationMin,
                        Isexp = response.Isexp == 1 ? true : false,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,
                        Rmaxl = response.Rmaxl,
                        Rminl = response.Rminl,
                        ParentId = response.ParentId

                    });
                }
                else
                {
                    return new ItemCategoriesVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
