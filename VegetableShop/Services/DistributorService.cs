using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class DistributorService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public DistributorService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of distributors
        public async Task<List<distributors>> GetAllDistributorsAsync()
        {
            return await _appDBContext.Distributors.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert distributors
        public async Task<bool> InsertDistributorsAsync(distributors distributors)
        {
            await _appDBContext.Distributors.AddAsync(distributors);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get distributors by id
        public async Task<distributors> GetDistributorsAsync(int Id)
        {
            distributors distributors = await _appDBContext.Distributors.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return distributors;
        }
        #endregion

        #region Update distributors
        public async Task<bool> UpdateDistributorsAsync(distributors distributors)
        {
            _appDBContext.Distributors.Update(distributors);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
