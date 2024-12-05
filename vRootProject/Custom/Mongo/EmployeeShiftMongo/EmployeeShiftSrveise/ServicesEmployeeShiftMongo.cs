using CoreLayer.Models.Business;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.BranchMongo.BranchMongoModel;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ServicesEmployeeShift
{
    public class ServicesEmployeeShiftMongo
    {
        private readonly IMongoCollection<EmployeeShiftColection> _mongoModel;
        public ServicesEmployeeShiftMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<EmployeeShiftColection>("EmployeeShift");

        }

        // MongoDB methods

        public async Task<List<EmployeeShiftColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }

        public async Task<List<EmployeeShiftColection>> GetEmployeeShiftsAsync(int branchId, int employeeId)
        {
            // تحقق من المدخلات
            if (branchId <= 0 || employeeId <= 0)
            {
                throw new ArgumentException("BranchId and EmployeeId must be valid positive numbers.");
            }

            // استعلام باستخدام MongoDB
            var filter = Builders<EmployeeShiftColection>.Filter.And(
                Builders<EmployeeShiftColection>.Filter.Eq(shift => shift.BranchId, branchId),
                Builders<EmployeeShiftColection>.Filter.Eq(shift => shift.EmployeeId, employeeId)
            );

            var shifts = await _mongoModel.Find(filter).ToListAsync();

            return shifts;
        }


        public async Task<List<EmployeeShiftColection>> GetEmployeeShiftsByIDAsync(int employeeId)
        {
            var filter = Builders<EmployeeShiftColection>.Filter.Eq(shift => shift.EmployeeId, employeeId);

            var shifts = await _mongoModel.Find(filter).ToListAsync();

            return shifts;
        }


        // SetInMongo
        public async Task CreateMongoModelAsync(EmployeeShiftColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
