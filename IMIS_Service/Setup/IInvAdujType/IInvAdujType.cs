using ExceptionHandler;
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

namespace IMIS_Service.Setup.IInvAdujType
{
    public interface IInvAdujType
    {
        Task<DataTableResponse> InvAdujTypeFetchData(DataTableVm model);
        Task<(string message, int id)> AddEditInvAdujType(InvAdujTypeVM model);
        Task<(string message, int Id)> DeleteInvAdujType(int InvAdujTypeid);
        Task<InvAdujTypeVM> ViewEdit(decimal Id);
    }
    public class InvAdujType : IInvAdujType
    {
        private readonly IMISDbContext _db;
        public InvAdujType(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> InvAdujTypeFetchData(DataTableVm model)
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

                var accMasters =  (from iiat in _db.InvItemAdjType
                                   where iiat.IsActive == true
                                   select new
                                        {
                                            iiat.Id,
                                            iiat.NameEn,
                                            iiat.NameNp ,
                                            iiat.AddSub,
                                            iiat.AdjType,

                                        });
                ///filter count for the total; record
                ///

                if (accMasters != null)
                {
                    totalResultsCount = await accMasters.CountAsync();
                    if (!string.IsNullOrEmpty(searchBy))
                    {
                        accMasters =  accMasters.Where(x => x.NameNp == searchBy || x.NameEn == searchBy);
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
        public async Task<(string message, int id)> AddEditInvAdujType(InvAdujTypeVM model)
        {
            try
            {
                var item = new InvItemAdjType()
                {
                    Id = model.Id,
                    NameEn = model.NameEn,
                    NameNp = model.NameNp,
                    AddSub = model.AddSub,
                    AdjType=model.AdjType
                };
                if (model.Id == 0)
                {
                    int id = await _db.InvItemAdjType.CountAsync();
                    item.Id = id + 1;
                    _db.InvItemAdjType.AddRange(item);
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
        public async Task<InvAdujTypeVM> ViewEdit(decimal Id)
        {
            try
            {
                var response = await _db.InvItemAdjType.Where(x => x.Id == Id).FirstOrDefaultAsync();
                if (response != null)
                {
                    return (new InvAdujTypeVM()
                    {
                        Id = response.Id,
                        NameEn = response.NameEn,
                        NameNp = response.NameNp,
                        AddSub = response.AddSub,
                        AdjType = response.AdjType,
                    });
                }
                else
                {
                    return new InvAdujTypeVM();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<(string message, int Id)> DeleteInvAdujType(int InvAdujTypeid)
        {
            try
            {
                var data = _db.InvItemAdjType.Where(x => x.Id == InvAdujTypeid).FirstOrDefault();
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
