using CoreLayer.Enum;
using CoreLayer.Enum.ProductionEnums;
using CoreLayer.Models.Business;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreLayer.Models.ProductTechnology.ProductActions
{
    public class TransactionFlow
    {
        public int ?TransactionFlowId { get; set; }
        public status ?Status { get; set; }
        public JournalType? TransactionType { get; set; }
        public PaymentType? PaymentType { get; set; }
        public double ?InvoicePrice { get; set; }
        public double ?InvoiceTax { get; set; }
        public double ?TotalPrice { get; set; }
        public double ?Tax { get; set; }
        public double ?ExtraDiscount { get; set; }
        public double ?ExtraTaxValue { get; set; }
        public double? AmountPaid { get; set; }
        public int? EmployeeShiftId { get; set; }
        public int? BranchId { get; set; }
        public string? BuddiesId { get; set; }
        public int? OrderId { get; set; }
        public int? StockPermissionId { get; set; }
        public int? InvoiceId { get; set; }
        public int? VisaId { get; set; }
        public int? WalletId { get; set; }
        public int? BankId { get; set; }
        public int? TreasuryId { get; set; }
        public double? TreasuryAmountPaid { get; set; }
        public double? BankAmountPaid { get; set; }
        public double? VisaAmountPaid { get; set; }
        public double? WalletAmountPaid { get; set; }
        public string? Note { get; set; }
        public string ?TransactionDateNote { get; set; }
        public string? Photo { get; set; }
        public string? Code { get; set; }
        public int ?OperationId { get; set; }
        public int? TransferredTreasuryId { get; set; }
        public int ?TransferredBankId { get; set; }
        public int ?EmployeeId { get; set; }
        public int? ShareCapitalId { get; set; }
        public int ?StockId { get; set; }
        public int ?TransferredStockId { get; set; }
        public double ?CustomerPaymentAmount { get; set; }
        public DateTime ?ScheduleDate { get; set; } 
        public DateTime? CreatedDate { get; set; } 
        public DateTime? OperationDate { get; set; } 
        public  bool ?SameDate { get; set; }
        public bool ?IsModified { get; set; } = false;
        public bool? IsDeleted { get; set; } = false;
        public int? DeletedId { get; set; }
        public int? ModifiedId { get; set; }
        public int? OriginalId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? NextTransactionId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string ?CreatedBy { get; set; }
        public string ?UpdatedBy { get; set; }
     
     
    }

}
