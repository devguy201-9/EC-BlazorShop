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
        private readonly DataContext _appDBContext;
        #endregion

        #region Constructor
        public OrderDetailService(DataContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of order_details
        public async Task<List<order_details>> GetAllOrder_DetailsAsync()
        {
            return await _appDBContext.Order_Details.ToListAsync();
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

        #region Get order_details by id
        public async Task<order_details> GetOrder_DetailsAsync(int Id)
        {
            order_details order_details = await _appDBContext.Order_Details.FirstOrDefaultAsync(c => c.id.Equals(Id));
            return order_details;
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

        #region Delete order_details
        public async Task<bool> DeleteOrder_DetailsAsync(order_details order_details)
        {
            _appDBContext.Remove(order_details);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
