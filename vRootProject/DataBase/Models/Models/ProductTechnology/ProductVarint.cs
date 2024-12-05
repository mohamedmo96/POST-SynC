using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.Business;
using CoreLayer.Models.ProductTechnology.ProductActions;
using System.ComponentModel.DataAnnotations;

namespace CoreLayer.Models.ProductTechnology
{
    public class ProductVarint : BaseEntity
    {
        [Key]

        public int ProductVarintId { get; set; }
        public string ?Name { get; set; }
        public string ?Barcode { get; set; }
        public string ?Int_Barcode { get; set; }
        public string ?Code { get; set; }
        public string ?R_Code { get; set; }
        public string ?Description { get; set; }
        public string ?Photo { get; set; }
        public double ?ConsumerPrice { get; set; }
        public string? DefaultStock { get; set; }
        public string? DefaultSecStock { get; set; }
        public int ?MaximumLimitForBranch { get; set; }
        public int ?MinimumLimitForBranch { get; set; }
        public int ?MaximumLimitForCompany { get; set; }
        public int ?MinimumLimitForCompany { get; set; }
        public int ?MaximumOrder { get; set; }
        public int ?ExchangeLimit { get; set; }
        public string? ImagePath { get; set; }
        public bool? NewPurchasePriceTurnOffFromPurchase { get; set; }
        public double? NewPurchasePrice { get; set; }
        public string ?NewPurchaseTurnOffNote { get; set; }
        public DateTime? NewPurchaseDate { get; set; }
        public bool? Isasleep { get; set; }
        public double ?PurchasePrice { get; set; }
        public double ?SalesPrice1 { get; set; }
        public double ?SalesPrice2 { get; set; }
        public double ?SalesPrice3 { get; set; }
        public double ?SalesPrice4 { get; set; }
        public double ?SalesPrice5 { get; set; }
        public double ?SalesPrice6 { get; set; }
        public double? SalesPrice7 { get; set; }
        public double ?SalesPrice8 { get; set; }
        public double ?SalesPrice9 { get; set; }
        public double ?SalesPrice10 { get; set; }
        public double ?Price { get; set; }
        public double? Calories_Value { get; set; }
        public double? Portion_Persons { get; set; }
        public bool ?Is_Order { get; set; }
        public bool ?Is_Pre_Order { get; set; }
        public int? ProductId { get; set; }
        public int ?BranchId { get; set; }
        public int? CompanyId { get; set; }
        public ProductType? Type { get; set; }
        public int? Flags { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
