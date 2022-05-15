using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class CategoryService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public CategoryService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of categories
        public async Task<List<categories>> GetAllCategoriesAsync()
        {
            return await _appDBContext.Categories.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert categories
        public async Task<bool> InsertCategoriesAsync(categories categories)
        {
            await _appDBContext.Categories.AddAsync(categories);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get categories by id
        public async Task<categories> GetCategoiesAsync(int Id)
        {
            categories categories = await _appDBContext.Categories.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return categories;
        }
        #endregion

        #region Update categories
        public async Task<bool> UpdateCategoriesAsync(categories categories)
        {
            _appDBContext.Categories.Update(categories);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
