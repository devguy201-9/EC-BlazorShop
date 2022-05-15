using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class RoleService
    {

        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public RoleService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of roles
        public async Task<List<roles>> GetAllRolesAsync()
        {
            return await _appDBContext.Roles.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert roles
        public async Task<bool> InsertRolesAsync(roles roles)
        {
            await _appDBContext.Roles.AddAsync(roles);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get roles by id
        public async Task<roles> GetRolesAsync(int Id)
        {
            roles roles = await _appDBContext.Roles.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return roles;
        }
        #endregion

        #region Update roles
        public async Task<bool> UpdateRolessAsync(roles roles)
        {
            _appDBContext.Roles.Update(roles);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        
        #region Delete roles
        public async Task<bool> DeleteRolesAsync(roles roles)
        {
            _appDBContext.Remove(roles);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
