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
            return await _appDBContext.Users.Where(c => c.status.Equals(1)).ToListAsync();
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
            users users = await _appDBContext.Users.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return users;
        }
        #endregion

        #region Get users by email
        public async Task<users> GetUsersByEmailAsync(string email)
        {
            users users = await _appDBContext.Users.FirstOrDefaultAsync(c => c.email.Equals(email) && c.status.Equals(1));
            return users;
        }
        #endregion

        #region Get users by user_name and password
        public async Task<users> GetUsersByUserNameAndPasswordAsync(string user_name,string password)
        {
            users users = await _appDBContext.Users.FirstOrDefaultAsync(c => c.user_name.Equals(user_name) && c.password.Equals(password) && c.status.Equals(1));
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
