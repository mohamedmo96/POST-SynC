using MongoDB.Driver;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;
using vRootProject.Custom.Mongo.ProductVarintMongo.ProductVarintMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise
{
    public class ServicesProductVarintMongo
    {
        private readonly IMongoCollection<ProductVarintColection> _mongoModel;
        public ServicesProductVarintMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<ProductVarintColection>("ProductVarint");

        }

        // MongoDB methods

        public async Task<List<ProductVarintColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }


        // SetInMongo
        public async Task CreateMongoModelAsync(ProductVarintColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
