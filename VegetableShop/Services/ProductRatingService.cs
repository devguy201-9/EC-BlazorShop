using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VegetableShop.Data;

namespace VegetableShop.Services
{
    public class ProductRatingService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ProductRatingService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of product_ratings
        public async Task<List<product_ratings>> GetAllproduct_RatingsAsync()
        {
            return await _appDBContext.product_Ratings.Where(c => c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Insert product_ratings
        public async Task<bool> Insertproduct_RatingsAsync(product_ratings product_ratings)
        {
            await _appDBContext.product_Ratings.AddAsync(product_ratings);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get product_ratings by id
        public async Task<product_ratings> Getproduct_RatingsAsync(int Id)
        {
            product_ratings product_ratings = await _appDBContext.product_Ratings.FirstOrDefaultAsync(c => c.id.Equals(Id) && c.status.Equals(1));
            return product_ratings;
        }
        #endregion

        #region Get product_ratings by productsid
        public async Task<List<product_ratings>> Getproduct_RatingsByProductsIDAsync(int productsID)
        {
            return await _appDBContext.product_Ratings.Where(c => c.products.id.Equals(productsID) && c.status.Equals(1)).ToListAsync();
        }
        #endregion

        #region Update product_ratings
        public async Task<bool> Updateproduct_RatingsAsync(product_ratings product_ratings)
        {
            _appDBContext.product_Ratings.Update(product_ratings);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete product_ratings
        public async Task<bool> Deleteproduct_RatingsAsync(product_ratings product_ratings)
        {
            _appDBContext.Remove(product_ratings);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
