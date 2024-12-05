//using Microsoft.EntityFrameworkCore;
//using MongoDB.Bson;
//using MongoDB.Driver;
//using vRootProject.Custom.Mongo.Product.ModelsMongo;
//using vRootProject.Custom.MySQL.ProductMysql.ModelsMySql;

//namespace vRootProject.CollectionService
//{

//    public class ProductServiceMysql
//    {
//        private readonly IMongoCollection<ProductMongo> _mongoProducts;
//        private readonly ApplicationDbContext _dbContext;

//        public ProductServiceMysql(IMongoDatabase mongoDatabase, ApplicationDbContext dbContext)
//        {
//            _mongoProducts = mongoDatabase.GetCollection<ProductMongo>("Product");
//            _dbContext = dbContext;
//        }

//        // MongoDB methods
//        public async Task<List<ProductMongo>> GetMongoProductsAsync()
//        {
//            return await _mongoProducts.Find(product => true).ToListAsync();
//        }

//        // MySQL methods
//        public async Task AddProductToMySqlAsync(ProductMySql newProduct)
//        {
//            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
//            {
//                try
//                {
//                    _dbContext.Product.Add(newProduct);
//                    await _dbContext.SaveChangesAsync();

//                    var mongoProduct = new ProductMongo
//                    {
//                        Name = newProduct.Name,
//                        Description = newProduct.Description,
//                        Price = newProduct.Price,
//                        Category = newProduct.Category,
//                        InStock = newProduct.InStock
//                    };

//                    await _mongoProducts.InsertOneAsync(mongoProduct);

//                    await transaction.CommitAsync();
//                }
//                catch (Exception)
//                {
//                    await transaction.RollbackAsync();
//                    throw;
//                }
//            }
//        }










//        /// <summary>
//        /// /Run For One Time To Get ALL Data 
//        /// </summary>
//        /// <returns></returns>
//        public async Task<List<ProductMySql>> GetMySqlProductsAsync() =>
//        await _dbContext.Product.ToListAsync();
//        public async Task CreateMongoProductAsync(ProductMongo newProduct) =>
//        await _mongoProducts.InsertOneAsync(newProduct);
//    }




//}
