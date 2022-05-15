using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class UnitService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public UnitService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of units
        public async Task<List<units>> GetAllUnitsAsync()
        {
            return await _appDBContext.Units.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert units
        public async Task<bool> InsertRolesAsync(units units)
        {
            await _appDBContext.Units.AddAsync(units);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get units by id
        public async Task<units> GetUnitsAsync(int Id)
        {
            units units = await _appDBContext.Units.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return units;
        }
        #endregion

        #region Update units
        public async Task<bool> UpdateUnitssAsync(units units)
        {
            _appDBContext.Units.Update(units);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete units
        public async Task<bool> DeleteRolesAsync(units units)
        {
            _appDBContext.Remove(units);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
