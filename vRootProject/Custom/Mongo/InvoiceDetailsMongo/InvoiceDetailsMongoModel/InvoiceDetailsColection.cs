using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.Business;
using System.ComponentModel.DataAnnotations.Schema;
using CoreLayer.Models.ProductTechnology.ProductActions;
using CoreLayer.Models.ProductTechnology;
using System.ComponentModel.DataAnnotations;
using CoreLayer.Enum.ProductionEnums;
using CoreLayer.Enum;
using CoreLayer.Models;

namespace vRootProject.Custom.Mongo.ProductsMongo.ProductsMongoModel
{

    public class InvoiceDetailsColection: BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int? InvoiceDetailsId { get; set; }
        public int? ProductVarintId { get; set; }
        public int? ProductUnitId { get; set; }
        public double? Quantity { get; set; }
        public double? QuantityOfmainUnit { get; set; }
        public double? ProductVarintPrice { get; set; }
        public double? ProductVarintDiscount { get; set; }
        public double? ProductVarintDiscountPercent { get; set; }
        public double? ProductVarintTax { get; set; }
        public double? ProductVarintTaxPercent { get; set; }
        public double? ProductVarintFinalPrice { get; set; }
        public double? TotalProductVarintFinalPrice { get; set; }
        public string? Notes { get; set; }
        public int? ImageTempId { get; set; }
        public int? StockId { get; set; }
        public int? InvoiceId { get; set; }
        public int? ReturnInvoiceId { get; set; }
        public int? DiscountListId { get; set; }
        public double? DiscountListValue { get; set; }

        public string? Note { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }


    }


}
