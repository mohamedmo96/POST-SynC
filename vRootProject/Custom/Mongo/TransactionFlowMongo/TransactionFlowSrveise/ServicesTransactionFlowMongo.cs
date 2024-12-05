using MongoDB.Driver;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;
using vRootProject.Custom.Mongo.TransactionFlowMongo.TransactionFlowMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.TransactionFlowSrveise
{
    public class ServicesTransactionFlowMongo
    {
        private readonly IMongoCollection<TransactionFlowColection> _mongoModel;
        public ServicesTransactionFlowMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<TransactionFlowColection>("TransactionFlow");

        }

        // MongoDB methods

        public async Task<List<TransactionFlowColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }


        // SetInMongo
        public async Task CreateMongoModelAsync(TransactionFlowColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
