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
        private readonly DataContext _appDBContext;
        #endregion

        #region Constructor
        public OrderService(DataContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of orders
        public async Task<List<orders>> GetAllOrdersAsync()
        {
            return await _appDBContext.Orders.ToListAsync();
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

        #region Get orders by id
        public async Task<orders> GetOrdersAsync(int Id)
        {
            orders orders = await _appDBContext.Orders.FirstOrDefaultAsync(c => c.id.Equals(Id));
            return orders;
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

        #region Delete orders
        public async Task<bool> DeleteOrdersAsync(orders orders)
        {
            _appDBContext.Remove(orders);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
