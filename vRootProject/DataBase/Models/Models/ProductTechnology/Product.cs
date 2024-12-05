using CoreLayer.Enum;
using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Enum.ProductionEnums;
using CoreLayer.Models.Business;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreLayer.Models.ProductTechnology
{
    public class Product : BaseEntity
    {

        [Key]

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public int ?MainProductUnitID { get; set; }
        public int ?PurchaseDefaultProductUnitID { get; set; }
        public int ?SalesDefaultProductUnitID { get; set; }
        public bool ?Stackable { get; set; }
        public int? ClassificationId { get; set; }
        public bool? NotReturnable { get; set; }
        public DiscountListType? DiscountListType { get; set; }
        public ContainerType? ContainerType { get; set; }
        public WarrantyType? WarrantyType { get; set; }
        public int ?WarrantyNumber { get; set; }
        public bool ?IsSerial { get; set; }
        public bool? IsExpire { get; set; }
        public double ?TaxValue { get; set; }
        public string ?Code { get; set; }
        public string ?Int_Barcode { get; set; }
        public string ?Barcode { get; set; }
        public string ?QRCode { get; set; }
        public string ?R_Code { get; set; }
        [NotMapped]
        public string ?MainUnitR_Code { get; set; }
        [NotMapped]
        public string ?ClassificationR_Code { get; set; }
        [NotMapped]
        public string? BrandR_Code { get; set; }
        public int? BrandId { get; set; }
        public int ?BranchId { get; set; }
        public int? CompanyId { get; set; }
        public ProductType? Type { get; set; }
        public int? Flags { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
    