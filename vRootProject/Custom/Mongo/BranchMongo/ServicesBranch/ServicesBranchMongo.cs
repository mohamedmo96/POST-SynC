using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.Business;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.BranchMongo.BranchMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ServicesBranch
{
    public class ServicesBranchMongo
    {
        private readonly IMongoCollection<Branch> _mongoBranch;
        public ServicesBranchMongo(IMongoDatabase mongoDatabase)
        {
            _mongoBranch = mongoDatabase.GetCollection<Branch>("Branch");

        }

        // MongoDB methods

        public async Task<List<Branch>> GetMongoBranchAsync()
        {
            return await _mongoBranch.Find(product => true).ToListAsync();
        }
        public async Task<List<Branch>> GetBranchesByTypeAsync(int type)
        {
            var data = await _mongoBranch
                .Find(branch => branch.Type == (ProductType?)type)
                .ToListAsync();
            return data; 
        }

        public async Task<List<Branch>> GetBranchesAsync(int userBranchId, int userBranchType, int companyId)
        {
            if (userBranchType == 1) 
            {
                return await _mongoBranch
                    .Find(branch => branch.CompanyId == companyId && branch.Type == ProductType.Shared)
                    .ToListAsync();
            }
            else if (userBranchType == 2) 
            {
                return await _mongoBranch
                    .Find(branch => branch.BranchId == userBranchId)
                    .ToListAsync();
            }

            return new List<Branch>();
        }


        public async Task<List<Branch>> GetBranchesByTypeAsync(ProductType type, int? branchId = null)
        {
            var filter = Builders<Branch>.Filter.Eq(b => b.Type, type);

            if (branchId.HasValue)
            {
                filter &= Builders<Branch>.Filter.Eq(b => b.BranchId, branchId.Value);
            }

            return await _mongoBranch.Find(filter).ToListAsync();
        }



        // SetInMongo
        public async Task CreateMongoProductAsync(Branch newProduct) =>
        await _mongoBranch.InsertOneAsync(newProduct);

    }
}
