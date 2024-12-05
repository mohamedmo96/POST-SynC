namespace vRootProject.Custom.Mongo.InvoiceMongo.InvoiceDto
{
    public class InvoiceTotalsDto
    {
        public int NetInvoicesCount { get; set; }
        public double InvoiceDiscountTotal { get; set; }
        public double DeliveryAreaPriceTotal { get; set; }
        public double DeliveryCostPriceTotal { get; set; }
        public double ServicePriceTotal { get; set; }
        public double InvoiceTaxTotal { get; set; }
    }

}
