using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.ProductMongo.ProductModelMongo;
using vRootProject.Custom.MySQL.ProductMysql.ModelsMySql;

namespace vRootProject.Custom.MySQL.ProductMysql.ProductServiceMysql
{
    public class ProductServiceMysq
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMongoCollection<ProductMong> _mongoProducts;

        public ProductServiceMysq(ApplicationDbContext dbContext, IMongoDatabase mongoDatabase)
        {
            _mongoProducts = mongoDatabase.GetCollection<ProductMong>("Product");
            _dbContext = dbContext;
        }

        public async Task<List<ProductMySql>> GetMySqlProductsAsync() =>
        await _dbContext.Products.ToListAsync();


    }
}
