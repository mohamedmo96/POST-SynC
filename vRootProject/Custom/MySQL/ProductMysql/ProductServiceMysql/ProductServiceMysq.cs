using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.ProductMongo.ProductModelMongo;
using vRootProject.Custom.MySQL.ProductMysql.ModelsMySql;

namespace vRootProject.Custom.MySQL.ProductMysql.ProductServiceMysql
{
    public class ProductServiceMysq
    {
        //private readonly ApplicationDbContext _dbContext;
        //private readonly IMongoCollection<ProductMong> _mongoProducts;

        //public ProductServiceMysq(ApplicationDbContext dbContext, IMongoDatabase mongoDatabase)
        //{
        //    _mongoProducts = mongoDatabase.GetCollection<ProductMong>("Product");
        //    _dbContext = dbContext;
        //}

        //// MySQL methods
        //public async Task AddProductToMySqlAsync(ProductMySql newProduct)
        //{
        //    using (var transaction = await _dbContext.Database.BeginTransactionAsync())
        //    {
        //        try
        //        {
        //            _dbContext.Product.Add(newProduct);
        //            await _dbContext.SaveChangesAsync();

        //            var mongoProduct = new ProductMong
        //            {
        //                Name = newProduct.Name,
        //                Description = newProduct.Description,
        //                Price = newProduct.Price,
        //                Category = newProduct.Category,
        //                InStock = newProduct.InStock
        //            };

        //            await _mongoProducts.InsertOneAsync(mongoProduct);

        //            await transaction.CommitAsync();
        //        }
        //        catch (Exception)
        //        {
        //            await transaction.RollbackAsync();
        //            throw;
        //        }
        //    }
        //}



        //public async Task<List<ProductMySql>> GetMySqlProductsAsync() =>
        //await _dbContext.Product.ToListAsync();

      
    }
}
