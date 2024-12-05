using MongoDB.Driver;
using vRootProject.Custom.Mongo.ProductMongo.ProductModelMongo;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ServicesProductMongo
{
    public class ServicesProductMong
    {
        private readonly IMongoCollection<ProductMong> _mongoProducts;
        public ServicesProductMong(IMongoDatabase mongoDatabase)
        {
            _mongoProducts = mongoDatabase.GetCollection<ProductMong>("Product");

        }

        // MongoDB methods

        public async Task<List<ProductMong>> GetMongoProductsAsync()
        {
            return await _mongoProducts.Find(product => true).ToListAsync();
        }







        // SetInMongo
        public async Task CreateMongoProductAsync(ProductMong newProduct) =>
        await _mongoProducts.InsertOneAsync(newProduct);

    }
}
