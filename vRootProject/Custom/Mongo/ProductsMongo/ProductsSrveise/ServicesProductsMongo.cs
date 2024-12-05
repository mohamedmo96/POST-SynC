using MongoDB.Driver;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise
{
    public class ServicesProductsMongo
    {
        private readonly IMongoCollection<ProductsColection> _mongoModel;
        public ServicesProductsMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<ProductsColection>("Products");

        }

        // MongoDB methods

        public async Task<List<ProductsColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }


        // SetInMongo
        public async Task CreateMongoModelAsync(ProductsColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
