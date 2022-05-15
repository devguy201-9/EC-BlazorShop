using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class ShipmentDetailService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ShipmentDetailService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of shipment_details
        public async Task<List<shipment_details>> GetAllShipment_DetailsAsync()
        {
            return await _appDBContext.Shipment_Details.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert shipment_details
        public async Task<bool> InsertShipment_DetailsAsync(shipment_details shipment_details)
        {
            await _appDBContext.Shipment_Details.AddAsync(shipment_details);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get shipment_details by id
        public async Task<shipment_details> GetShipment_DetailsAsync(int Id)
        {
            shipment_details shipment_details = await _appDBContext.Shipment_Details.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return shipment_details;
        }
        #endregion

        #region Get shipment_details by shipmentsid
        public async Task<List<shipment_details>> GetShipment_DetailsByShipmentsIDAsync(int shipmentsID)
        {
            return await _appDBContext.Shipment_Details.Where(c => c.shipments.id.Equals(shipmentsID) && c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Update shipment_details
        public async Task<bool> UpdateShipment_DetailsAsync(shipment_details shipment_details)
        {
            _appDBContext.Shipment_Details.Update(shipment_details);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete shipment_details
        public async Task<bool> DeleteShipment_DetailsAsync(shipment_details shipment_details)
        {
            _appDBContext.Remove(shipment_details);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
