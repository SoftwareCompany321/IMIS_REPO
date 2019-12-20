﻿using IMIS_CORE.Utility;
using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.Setup.IRoomDetials
{
    public interface IRoomDetials
    {
        Task<DataTableResponse> RoomDetialsFetchData(DataTableVm model);
        Task<(string message, int Id)> AddEdit(RoomDetialsVM Model);

        Task<RoomDetialsVM> ViewOrEditData(int Id);
    }
    public class RoomDetials : IRoomDetials
    {
        private readonly IMISDbContext _db;
        public RoomDetials(IMISDbContext db)
        {
            _db = db;
        }
        public async Task<DataTableResponse> RoomDetialsFetchData(DataTableVm model)
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

                var accMasters =  (from IRM in _db.InvRoomMst
                                        select new
                                        {
                                            IRM.RoomId,
                                            IRM.BlockNo,
                                            IRM.Dept,
                                            IRM.DeptId,
                                            IRM.DescEn,
                                            IRM.DescNp,
                                            IRM.FloorNo 
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

                var finallist = await accMasters.OrderByDescending(x => x.RoomId).Skip(skip).ToListAsync();

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

        public async Task<(string message, int Id)> AddEdit(RoomDetialsVM Model)
        {
            try
            {
                var AddEdit = new InvRoomMst()
                {
                    RoomId = Model.RoomId,
                    DescEn = Model.DescEn,
                    DescNp = Model.DescNp 

                };

                if (Model.RoomId == 0)
                {
                    int countrow = await _db.InvUnit.CountAsync();
                    AddEdit.RoomId = countrow + 1;
                    await _db.AddAsync(AddEdit);
                }
                else
                {
                    _db.Entry(AddEdit).State = EntityState.Modified;
                }
                await _db.SaveChangesAsync(true);
                return ("success", 0);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<RoomDetialsVM> ViewOrEditData(int UnitId)
        {
            try
            {
                var data = await _db.InvRoomMst.Where(x => x.RoomId == UnitId).FirstOrDefaultAsync();
                if (data != null)
                {
                    return new RoomDetialsVM()
                    {
                        DeptId = data.RoomId,
                        DescNp = data.DescNp,
                        DescEn = data.DescEn 
                    };
                }
                else
                {
                    return new RoomDetialsVM();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
