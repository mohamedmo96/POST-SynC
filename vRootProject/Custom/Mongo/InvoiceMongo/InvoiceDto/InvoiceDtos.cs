using CoreLayer.Enum.ProductionEnums;

namespace vRootProject.Custom.Mongo.InvoiceMongo.InvoiceDto
{
    public class InvoiceDtos
    {
        public int? InvoiceId { get; set; }
        public int? FlagByDateCompany { get; set; }
        public int? EmployeeShiftId { get; set; }
        public InvoiceStatus? InvoiceType { get; set; }
        public PermissionStatus? Status { get; set; }

        public string ? Employee { get; set; }
        public string ?Buddies { get; set; } 
        public string ?ClientPhone { get; set; }
        public string ? Client { get; set; }
        public double? TotalPrice { get; set; }
        public double? InvoiceDiscount { get; set; }
        public double? DeliveryAreaPrice { get; set; }
        public double? ServicePrice { get; set; }
        public double? FinalPrice { get; set; }
    }

}
