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

    public class InvoiceColection: BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int InvoiceId { get; set; }

        public InvoiceType? InvoiceType { get; set; }
        public PermissionStatus? PermissionStatus { get; set; }
        public InvoiceStatus? InvoiceStatus { get; set; }
        public int? InvoiceStatusFlag { get; set; }
        public string? BuddiesId { get; set; }//
        public string ?TechnicalId { get; set; }
        public string ?DeliveryId { get; set; }
        public string ?WaiterId { get; set; }
        public string ?Driver_ID { get; set; }
        public string ?Chef_ID { get; set; }
        public int ?FlagByDateCompany { get; set; }
        public int ?FlagByDateBranch { get; set; }
        public string? EmployeeNote { get; set; }
        public string ?ClientNote { get; set; }
        public string ?PreparationNotes { get; set; }
        public string ?Photo { get; set; }
        public double ?FinalPrice { get; set; }
        public double ?Commission { get; set; }
        public double ?TotalPrice { get; set; }
        public double ?TotalProductVarintTax { get; set; }
        public double ?TotalProductVarintDiscountListPrice { get; set; }
        public double ?TotalProductVarintDiscountExtraPrice { get; set; }
        public double ?InvoiceTax { get; set; }
        public double ?InvoiceDiscount { get; set; }
        public double ?DeliveryAreaPrice { get; set; }
        public double ?DeliveryCostPrice { get; set; }
        public double? ServicePrice { get; set; }
        public bool ?WillShipping { get; set; }
        public bool? WillPreparing { get; set; }
        public int ?SellerId { get; set; }
        public int? StockPermissinId { get; set; }
        public int? OrderId { get; set; }
        public int? BranchId { get; set; } //
        public int? ToBranchId { get; set; }
        public int? CompanyId { get; set; }
        public int ?TableNumber { get; set; }
        public string? InvoiceCode { get; set; }
        public bool ?Is_Schedule { get; set; }
        public DateTime? Schedule_Date { get; set; }
        public ProductType? Type { get; set; }
        public status? Status { get; set; }
        public PaymentType? PaymentType { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string ?CreatedBy { get; set; }//
        public string ?UpdatedBy { get; set; }


    }


}
