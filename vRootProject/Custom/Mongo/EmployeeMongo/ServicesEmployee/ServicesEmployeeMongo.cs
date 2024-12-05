using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.Business;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployee
{
    public class ServicesEmployeeMongo
    {
        private readonly IMongoCollection<EmployeeColection> _mongoModel;
        public ServicesEmployeeMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<EmployeeColection>("Employee");

        }

        // MongoDB methods

        public async Task<List<EmployeeColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }
        public async Task<List<EmployeeColection>> GetEmployeesByBranchIdAsync(int branchId)
        {
            if (branchId==null)
            {
                throw new ArgumentException("BranchId cannot be null or empty", nameof(branchId));
            }

            return await _mongoModel.Find(employee => employee.BranchId == branchId).ToListAsync();
        }

        public async Task<List<EmployeeColection>> GetEmployeesAsync(int userBranchId, int userBranchType, int companyId)
        {
            if (userBranchType == 2) 
            {
                return await _mongoModel
                    .Find(employee => employee.CompanyId == companyId && employee.Type == ProductType.Shared)
                    .ToListAsync();
            }
            else if (userBranchType == 1)
            {
                return await _mongoModel
                    .Find(employee => employee.BranchId == userBranchId)
                    .ToListAsync();
            }

            return new List<EmployeeColection>();
        }






        // SetInMongo
        public async Task CreateMongoModelAsync(EmployeeColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
