using CoreLayer.Models.Business;
using CoreLayer.Models.ProductTechnology.ProductActions;
using MongoDB.Bson;
using MongoDB.Driver;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.InvoiceMongo.InvoiceDto;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;
using vRootProject.Custom.Mongo.TransactionFlowMongo.TransactionFlowMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise
{
    public class ServicesInvoiceMongo
    {
        private readonly IMongoCollection<InvoiceColection> _mongoModel;
        private readonly IMongoCollection<BuddiesColection> _buddiesCollection;
        private readonly IMongoCollection<EmployeeColection> _EmpCollection;
        private readonly IMongoCollection<TransactionFlowColection> _EmpshiftsCollection;
        private readonly IMongoCollection<EmployeeShiftColection> _EmployeeShiftColection;

        public ServicesInvoiceMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<InvoiceColection>("Invoice");
            _buddiesCollection = mongoDatabase.GetCollection<BuddiesColection>("Buddies");
            _EmpCollection = mongoDatabase.GetCollection<EmployeeColection>("Employee");
            _EmpshiftsCollection = mongoDatabase.GetCollection<TransactionFlowColection>("TransactionFlow");
            _EmployeeShiftColection = mongoDatabase.GetCollection<EmployeeShiftColection>("EmployeeShift");

        }


        public async Task<List<InvoiceDtos>> GetInvoicesByBranchWithBuddiesAsync(int branchId)
        {
            var invoices = await _mongoModel.Find(i => i.BranchId == branchId).ToListAsync();
            var transaction = await _EmpshiftsCollection.Find(i => i.BranchId == branchId).ToListAsync();

            var employeeIds = invoices
                .Select(i => i.CreatedBy)
                .Distinct()
                .Select(id => int.TryParse(id, out int parsedId) ? parsedId : (int?)null)
                .Where(parsedId => parsedId.HasValue)
                .Select(parsedId => parsedId.Value)
                .ToList();

            var employees = await _EmpCollection.Find(e => employeeIds.Contains((int)e.EmployeeId)).ToListAsync();

          var Trancation = await _EmpshiftsCollection.Find(i => i.BranchId == branchId).ToListAsync();


            var invoiceDtos = invoices.Select(i =>
            {
                var employee = employees.FirstOrDefault(e => e.EmployeeId == int.Parse(i.CreatedBy));
                var empshifts = Trancation.FirstOrDefault(e => e.EmployeeId == int.Parse(i.CreatedBy));

                return new InvoiceDtos
                {
                    InvoiceId = i.FlagByDateCompany,
                   EmployeeShiftId = empshifts.EmployeeShiftId,
                    InvoiceType = i.InvoiceStatus,
                    Status = i.PermissionStatus,
                    Employee = employee?.FirstName ?? "Unknown", 
                    TotalPrice = i.TotalPrice,
                    InvoiceDiscount = i.InvoiceDiscount,
                    DeliveryAreaPrice = i.DeliveryAreaPrice,
                    ServicePrice = i.ServicePrice,
                    FinalPrice = i.FinalPrice
                };
            }).ToList();

            return invoiceDtos;
        }

        // MongoDB methods

        public async Task<List<InvoiceColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }

        public async Task<List<InvoiceColection>> GetInvoicesByDateAndBranchAsync(DateTime date, int branchId)
        {
            if (date == DateTime.MinValue)
            {
                throw new ArgumentException("Invalid date provided.");
            }

            if (branchId==null)
            {
                throw new ArgumentException("Branch ID cannot be null or empty.");
            }

            // MongoDB filter
            var filter = Builders<InvoiceColection>.Filter.And(
                Builders<InvoiceColection>.Filter.Gte(invoice => invoice.CreateDate, date.Date),
                Builders<InvoiceColection>.Filter.Lt(invoice => invoice.CreateDate, date.Date.AddDays(1)),
                Builders<InvoiceColection>.Filter.Eq(invoice => invoice.BranchId, branchId)
            );

            var invoices = await _mongoModel.Find(filter).ToListAsync();

            return invoices;
        }


        public async Task<List<InvoiceColection>> GetInvoicesByDeliveryAsync(string deliveryId)
        {
            // تحقق من أن deliveryId ليس فارغًا
            if (string.IsNullOrWhiteSpace(deliveryId))
            {
                throw new ArgumentException("DeliveryId cannot be null or empty.");
            }

            // MongoDB filter
            var filter = Builders<InvoiceColection>.Filter.Eq(invoice => invoice.DeliveryId, deliveryId);

            // استرجاع البيانات
            var invoices = await _mongoModel.Find(filter).ToListAsync();

            return invoices;
        }

        public async Task<List<InvoiceColection>> GetInvoicesByEmployeeAsync(string employeeId)
        {
            if (employeeId =="0")
            {
                throw new ArgumentException("EmployeeId must be a valid positive number.");
            }

            // MongoDB filter
            var filter = Builders<InvoiceColection>.Filter.Eq(invoice => invoice.CreatedBy, employeeId);

            var invoices = await _mongoModel.Find(filter).ToListAsync();

            return invoices;
        }

        public async Task<List<InvoiceColection>> GetInvoicesByShiftsAndTimePeriod(DateTime startTime, DateTime endTime)
        {
            var shifts = await GetEmployeeShiftsByTimePeriod(startTime, endTime);

            var invoices = new List<InvoiceColection>();

            foreach (var shift in shifts)
            {
                var invoiceFilter = Builders<InvoiceColection>.Filter.Eq(i => i.SellerId, shift.EmployeeId) &
                                    Builders<InvoiceColection>.Filter.Eq(i => i.BranchId, shift.BranchId);

                var shiftInvoices = await _mongoModel.Find(invoiceFilter).ToListAsync();
                invoices.AddRange(shiftInvoices);
            }

            return invoices;
        }

        public async Task<List<EmployeeShiftColection>> GetEmployeeShiftsByTimePeriod(DateTime startTime, DateTime endTime)
        {
            var shiftFilter = Builders<EmployeeShiftColection>.Filter.Gte(s => s.StartTime, startTime) &
                              Builders<EmployeeShiftColection>.Filter.Lte(s => s.StartTime, endTime);

            return await _EmployeeShiftColection.Find(shiftFilter).ToListAsync();
        }

        public async Task<List<InvoiceColection>> GetInvoicesByShiftIdAsync(int shiftId)
        {
            var shift = await _EmpshiftsCollection.Find(x => x.EmployeeShiftId == shiftId).FirstOrDefaultAsync();

            if (shift == null)
            {
                return new List<InvoiceColection>();
            }

            var filter = Builders<InvoiceColection>.Filter.Eq("EmployeeShiftId", shift.EmployeeShiftId);

            var invoices = await _mongoModel.Find(filter).ToListAsync();

            return invoices;
        }
        public async Task<InvoiceTotalsDto> GetInvoiceTotalsAsync()
        {
            var filter = Builders<InvoiceColection>.Filter.Eq(invoice => invoice.IsDeleted, false);

            var invoices = await _mongoModel.Find(filter).ToListAsync();

            var result = new InvoiceTotalsDto
            {
                NetInvoicesCount = invoices.Count,
                InvoiceDiscountTotal = invoices.Sum(i => i.InvoiceDiscount ?? 0),
                DeliveryAreaPriceTotal = invoices.Sum(i => i.DeliveryAreaPrice ?? 0),
                DeliveryCostPriceTotal = invoices.Sum(i => i.DeliveryCostPrice ?? 0),
                ServicePriceTotal = invoices.Sum(i => i.ServicePrice ?? 0),
                InvoiceTaxTotal = invoices.Sum(i => i.InvoiceTax ?? 0)
            };

            return result;
        }




        // SetInMongo
        public async Task CreateMongoModelAsync(InvoiceColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
