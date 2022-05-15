using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class ShipmentService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ShipmentService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of shipments
        public async Task<List<shipments>> GetAllShipmentsAsync()
        {
            return await _appDBContext.Shipments.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert shipments
        public async Task<bool> InsertShipmentsAsync(shipments shipments)
        {
            await _appDBContext.Shipments.AddAsync(shipments);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get shipments by id
        public async Task<shipments> GetShipmentsAsync(int Id)
        {
            shipments shipments = await _appDBContext.Shipments.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return shipments;
        }
        #endregion

        #region Get shipments by distributorsid
        public async Task<List<shipments>> GetShipmentsByDistributorsIDAsync(int distributorsID)
        {
            return await _appDBContext.Shipments.Where(c => c.distributors.id.Equals(distributorsID) && c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Update shipments
        public async Task<bool> UpdateShipmentssAsync(shipments shipments)
        {
            _appDBContext.Shipments.Update(shipments);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete shipments
        public async Task<bool> DeleteShipmentsAsync(shipments shipments)
        {
            _appDBContext.Remove(shipments);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
