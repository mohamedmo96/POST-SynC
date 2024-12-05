using MongoDB.Driver;
using vRootProject.Custom.Mongo.BuddiesMongo.BuddiesMongoModel;
using vRootProject.Custom.Mongo.EmployeeMongo.EmployeeMongoModel;
using vRootProject.Custom.Mongo.EmployeeShiftMongo.EmployeeShiftMongoModel;
using vRootProject.Custom.Mongo.InvoiceDetailsMongo.Dtos;
using vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel;
using vRootProject.Custom.Mongo.ProductVarintMongo.ProductVarintMongoModel;

namespace vRootProject.Custom.Mongo.ProductMongoFile.ProductsSrveise
{
    public class ServicesInvoiceDetailsMongo
    {
        private readonly IMongoCollection<InvoiceDetailsColection> _mongoModel;
        private readonly IMongoCollection<ProductVarintColection> _productVariantsCollection;
        private readonly IMongoCollection<ProductsColection> _productCollection;
        public ServicesInvoiceDetailsMongo(IMongoDatabase mongoDatabase)
        {
            _mongoModel = mongoDatabase.GetCollection<InvoiceDetailsColection>("InvoiceDetails");
            _productVariantsCollection = mongoDatabase.GetCollection<ProductVarintColection>("ProductVarint");
            _productCollection = mongoDatabase.GetCollection<ProductsColection>("Products");

        }

        // MongoDB methods

        public async Task<List<InvoiceDetailsColection>> GetMongoModelsAsync()
        {
            return await _mongoModel.Find(product => true).ToListAsync();
        }



        public async Task<List<InvoiceDetailsDto>> GetInvoiceDetailsByInvoiceIdAsync(int invoiceId)
        {
            var invoiceDetails = await _mongoModel
                .Find(detail => detail.InvoiceDetailsId == invoiceId)
                .ToListAsync();

            var productVariantIds = invoiceDetails
                .Select(detail => detail.ProductVarintId)
                .Where(id => id.HasValue)
                .Distinct()
                .ToList();

            var productVariants = await _productVariantsCollection
                .Find(variant => productVariantIds.Contains(variant.ProductVarintId))
                .ToListAsync();

            var productIds = productVariants
                .Select(variant => variant.ProductId)
                .Distinct()
                .ToList();

            var products = await _productCollection
                .Find(product => productIds.Contains(product.ProductId))
                .ToListAsync();

            var invoiceDetailsDtos = invoiceDetails.Select(detail =>
            {
                var productVariant = productVariants.FirstOrDefault(v => v.ProductVarintId == detail.ProductVarintId);
                var product = productVariant != null ? products.FirstOrDefault(p => p.ProductId == productVariant.ProductId) : null;

                return new InvoiceDetailsDto
                {
                    InvoiceType = detail.InvoiceId,
                    CreateDate = detail.CreateDate?.ToString("yyyy-MM-dd"),
                    CreatedBy = detail.CreatedBy,
                    FinalPrice = detail.TotalProductVarintFinalPrice,
                    ProductName = product?.Name ?? "Unknown",
                    ProductVariantName = productVariant?.Name ?? "Unknown",
                    Quantity = detail.Quantity,
                    ProductVariantPrice = detail.ProductVarintPrice,
                    TotalProductVariantFinalPrice = detail.TotalProductVarintFinalPrice
                };
            }).ToList();

            return invoiceDetailsDtos;
        }


        // SetInMongo
        public async Task CreateMongoModelAsync(InvoiceDetailsColection newModel) =>
        await _mongoModel.InsertOneAsync(newModel);

    }
}
