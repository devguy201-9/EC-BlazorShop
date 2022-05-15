using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class CartService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public CartService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of carts
        public async Task<List<carts>> GetAllCartsAsync()
        {
            return await _appDBContext.Carts.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert carts
        public async Task<bool> InsertCartsAsync(carts carts)
        {
            await _appDBContext.Carts.AddAsync(carts);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        
        #region Get carts by usersid
        public async Task<List<carts>> GetCartsByUsersIDAsync(int usersID)
        {
            return await _appDBContext.Carts.Where(c => c.users.id.Equals(usersID) && c.status.Equals(1)).ToListAsync();
            //carts carts = await _appDBContext.Carts.FirstOrDefaultAsync(c => c.users.id.Equals(usersID));
        }
        #endregion

        #region Update Quantity of carts
        public async Task<bool> UpdateQuantityCartsAsync(carts carts)
        {
            _appDBContext.Carts.Update(carts);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete carts
        public async Task<bool> DeleteCartsAsync(carts carts)
        {
            _appDBContext.Remove(carts);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
