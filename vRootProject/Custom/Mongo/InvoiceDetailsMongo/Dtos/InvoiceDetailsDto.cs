namespace vRootProject.Custom.Mongo.InvoiceDetailsMongo.Dtos
{
    public class InvoiceDetailsDto
    {
        public int ?InvoiceType { get; set; }
        public string? CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public double? FinalPrice { get; set; }
        public string? ProductName { get; set; }
        public string? ProductVariantName { get; set; }
        public double? Quantity { get; set; }
        public double? ProductVariantPrice { get; set; }
        public double? TotalProductVariantFinalPrice { get; set; }
    }

}
