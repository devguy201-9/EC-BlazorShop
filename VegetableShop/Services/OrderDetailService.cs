using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class OrderDetailService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public OrderDetailService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of order_details
        public async Task<List<order_details>> GetAllOrder_DetailsAsync()
        {
            return await _appDBContext.Order_Details.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert order_details
        public async Task<bool> InsertOrder_DetailsAsync(order_details order_details)
        {
            await _appDBContext.Order_Details.AddAsync(order_details);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get order_details by ordersid
        public async Task<List<order_details>> GetOrder_DetailsByOrdersIDAsync(int ordersID)
        {
            return await _appDBContext.Order_Details.Where(c => c.orders.id.Equals(ordersID) && c.status.Equals(1)).ToListAsync();
            //return await _appDBContext.Order_Details.FirstOrDefaultAsync(c => c.orders.id.Equals(ordersID));
        }
        #endregion

        #region Update order_details
        public async Task<bool> UpdateOrder_DetailsAsync(order_details order_details)
        {
            _appDBContext.Order_Details.Update(order_details);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
