using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class OrderService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public OrderService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of orders
        public async Task<List<orders>> GetAllOrdersAsync()
        {
            return await _appDBContext.Orders.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert orders
        public async Task<bool> InsertOrdersAsync(orders orders)
        {
            await _appDBContext.Orders.AddAsync(orders);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get orders by usersid
        public async Task<List<orders>> GetOrdersByUsersIDAsync(int usersID)
        {
            return await _appDBContext.Orders.Where(c => c.users.id.Equals(usersID) && c.status.Equals(1)).ToListAsync();
            //orders orders = await _appDBContext.Orders.FirstOrDefaultAsync(c => c.id.Equals(usersID));
        }
        #endregion

        #region Update orders
        public async Task<bool> UpdateOrderssAsync(orders orders)
        {
            _appDBContext.Orders.Update(orders);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
