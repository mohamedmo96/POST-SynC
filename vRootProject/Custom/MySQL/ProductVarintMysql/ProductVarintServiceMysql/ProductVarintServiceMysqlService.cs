using CoreLayer.Models.Business;
using CoreLayer.Models.ProductTechnology;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.BranchMongo.BranchMongoModel;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.ProductMongo.ProductModelMongo;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;
using vRootProject.Custom.Mongo.ProductVarintMongo.ProductVarintMongoModel;
using vRootProject.Custom.MySQL.BranchMysql.BranchMySqlModel;

namespace vRootProject.Custom.MySQL.ProductsMysql.ProductsServiceMysql
{
    public class ProductVarintServiceMysqlService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMongoCollection<ProductVarintColection> _mongoModel;

        public ProductVarintServiceMysqlService(ApplicationDbContext dbContext, IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<ProductVarintColection>("ProductVarint");
            _dbContext = dbContext;
        }

        // MySQL methods
        //public async Task AddProductToMySqlAsync(BranchMySql newProduct)
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



        public async Task<List<ProductVarint>> GetMySqlModelAsync() =>
        await _dbContext.productvarint.ToListAsync();

      
    }
}
