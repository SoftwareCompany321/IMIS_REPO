using IMIS_DataEntity.Data;
using IMIS_DataEntity.EntityClass;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP_Service.User
{

    public interface IUserService
    {
        //Task<IList<Usermaster>> MspUsers();

        //Task<int> MspUserCount();

    }
    public class UserService : IUserService
    {
        private readonly IMISDbContext _db;
        public UserService(IMISDbContext db)
        {
            _db = db;
        }

        //public async Task<int> MspUserCount()
        //{
        //    return (await _db.Users.CountAsync());
        //}

        //public async Task<IList<Usermaster>> MspUsers()
        //{
        //    return (await _db..ToListAsync());
        //}
    }
}
