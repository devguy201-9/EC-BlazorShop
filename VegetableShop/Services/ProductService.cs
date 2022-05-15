using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class ProductService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ProductService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of products
        public async Task<List<products>> GetAllProductsAsync()
        {
            return await _appDBContext.Products.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert products
        public async Task<bool> InsertProductsAsync(products products)
        {
            await _appDBContext.Products.AddAsync(products);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get products by id
        public async Task<products> GetProductsAsync(int Id)
        {
            products products = await _appDBContext.Products.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return products;
        }
        #endregion

        #region Get products by categoiesid
        public async Task<List<products>> GetProductsByCateroriesIDAsync(int categoriesID)
        {
            return await _appDBContext.Products.Where(c => c.categories.id.Equals(categoriesID) && c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Update products
        public async Task<bool> UpdateProductssAsync(products products)
        {
            _appDBContext.Products.Update(products);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete products
        public async Task<bool> DeleteProductsAsync(products products)
        {
            _appDBContext.Remove(products);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
