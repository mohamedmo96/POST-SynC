using CoreLayer.Enum.BusinessEnums;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ServicesBuddies
{
    public class ServicesBuddiesMongo
    {
        private readonly IMongoCollection<BuddiesColection> _mongoModel;
        public ServicesBuddiesMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<BuddiesColection>("Buddies");

        }

        // MongoDB methods

        public async Task<List<BuddiesColection>> GetMongoModelsAsync()
        {
            var data = await _mongoModel.Find(product => true).ToListAsync();
            return data;
        }

        public async Task<List<BuddiesColection>> GetAllDeliveriesAsync()
        {
            var data = await _mongoModel
               .Find(buddy => buddy.BodyTypes.HasValue && (int)buddy.BodyTypes.Value == 5)
               .ToListAsync();
            return data;
        }


        public async Task<List<BuddiesColection>> GetDeliveriesAsync(int userBranchId, int userBranchType, int companyId)
        {
            if (userBranchType == (int)ProductType.Shared)
            {
                return await _mongoModel
                    .Find(buddy => buddy.CompanyId == companyId &&
                                   buddy.Type == ProductType.Shared &&
                           buddy.BodyTypes.HasValue && (int)buddy.BodyTypes.Value == 5)
                    .ToListAsync();
            }
            else if (userBranchType == (int)ProductType.Unique)
            {
                return await _mongoModel
                    .Find(buddy => buddy.BranchId == userBranchId &&
                           buddy.BodyTypes.HasValue && (int)buddy.BodyTypes.Value == 5)
                    .ToListAsync();
            }

            return new List<BuddiesColection>();
        }


        // SetInMongo
        public async Task CreateMongoModelAsync(BuddiesColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
