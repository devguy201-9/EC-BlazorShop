using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class UserService
    {

        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public UserService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of users
        public async Task<List<users>> GetAllUsersAsync()
        {
            return await _appDBContext.Users.ToListAsync();
        }
        #endregion

        #region Insert users
        public async Task<bool> InsertUsersAsync(users users)
        {
            await _appDBContext.Users.AddAsync(users);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get users by id
        public async Task<users> GetUsersAsync(int Id)
        {
            users users = await _appDBContext.Users.FirstOrDefaultAsync(c => c.id.Equals(Id));
            return users;
        }
        #endregion

        #region Update users
        public async Task<bool> UpdateUsersAsync(users users)
        {
            _appDBContext.Users.Update(users);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete users
        public async Task<bool> DeleteUserssAsync(users users)
        {
            _appDBContext.Remove(users);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
