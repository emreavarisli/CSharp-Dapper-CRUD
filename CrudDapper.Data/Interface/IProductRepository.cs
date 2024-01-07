using CrudDapper.Data.Interface;
using CrudDapper.Entity;
using Dapper;
using System.Linq.Expressions;

namespace CrudDapper.Data
{
    public interface IProductRepository : IRepository<Products>
    {
        Task<IEnumerable<Products>> GetProductsAsync();
        Task<Products> GetProductsByIdAsync(int id);
        Task<bool> InsertProductsAsync(Products product);
        Task<bool> UpdateProductsAsync(Products product);
        Task<bool> DeleteProductsAsync(int id);

        Task<List<Products>> GetFilterProductsAll(Expression<Func<Products, bool>> filter);
        Task<Products> GetFilterProducts(Expression<Func<Products, bool>> filter);
        Task<int> ProductsStoredProcedure(string storedProcedure, DynamicParameters dynamicParameters);
        Task<List<Products>> GetQueryProducts(string query);
    }
}
