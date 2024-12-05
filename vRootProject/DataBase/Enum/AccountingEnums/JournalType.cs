using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum
{
    public enum JournalType
    {
        #region مورد

        #region دفعة لمورد

        #region دفعة لمورد من خزنة
        PaymentToSupplierFromSafe = 1,
        UpdatePaymentToSupplierFromSafe = 4,
        DeletePaymentToSupplierFromSafe = 5,
        #endregion دفعة لمورد من خزنة

        #region دفعة لمورد من ينك
        PaymentToSupplierFromBank = 212,
        UpdatePaymentToSupplierFromBank = 3,
        DeletePaymentToSupplierFromBank = 213,
        #endregion دفعة لمورد من ينك

        #region دفعة لمورد من محفظه
        PaymentToSupplierFromWallet = 35,
        UpdatePaymentToSupplierFromWallet = 216,
        DeletePaymentToSupplierFromWallet = 217,
        #endregion دفعة لمورد من محفظه

        #endregion دفعة لمورد

        #region كاش من مورد
        CashFromSupplier = 2,
        UpdateCashFromSupplier =133 ,
        DeleteCashFromSupplier = 134,
        #endregion كاش من مورد

        #region خدمة من مورد
        ServiceFromSupplier = 75,
        UpdateServiceFromSupplier = 135,
        DeleteServiceFromSupplier = 136,
        #endregion خدمة من مورد

        #region دفع لمورد بالفيزا
        SupplierPaymentByVisa = 236,
        UpdateSupplierPaymentByVisa = 237,
        DeleteSupplierPaymentByVisa = 238,
        #endregion دفع لمورد بالفيزا

        #endregion مورد

        #region عميل
        #region دفعة من عميل

        #region دفعة من عميل لخزنة
        PaymentFromCustomerToSafe = 6,
        UpdatePaymentFromCustomerToSafe = 207,
        DeletePaymentFromCustomerToSafe = 208,
        #endregion دفعة من عميل لخزنة

        #region دفعة من عميل لبنك
        PaymentFromCustomerToBank = 7,
        UpdatePaymentFromCustomerToBank = 209,
        DeletePaymentFromCustomerToBank = 210,
        #endregion دفعة من عميل لبنك

        #region دفعة من عميل لمحفظة
        PaymentFromCustomerToWallet = 10,
        UpdatePaymentFromCustomerToWallet = 211,
        DeletePaymentFromCustomerToWallet = 214,
        #endregion دفعة من عميل لمحفظة

        #endregion دفعة من عميل

        #region دفعة لعميل 
        CashToCustomer = 8, 
        UpdateCashToCustomer = 139,
        DeleteCashToCustomer = 140,
        #endregion دفعة لعميل 

        #region دفع من عميل بالفيزا
        CustomerPaymentWithVisa = 76,
        UpdateCustomerPaymentWithVisa = 141,
        DeleteCustomerPaymentWithVisa = 142,
        #endregion دفع من عميل بالفيزا

        #region خدمة لعميل بتكاليف 
        CostEffectiveCustomerService = 72,
        UpdateCostEffectiveCustomerService = 143,
        DeleteCostEffectiveCustomerService = 144,
        #endregion خدمة لعميل بتكاليف 

        #region مصروف خدمة لعميل  
        CustomerServiceExpense = 73,
        UpdateCustomerServiceExpense = 145,
        DeleteCustomerServiceExpense = 146,
        #endregion مصروف خدمة لعميل  

        #region خدمة بدون تكاليف 
        NoCostService = 74,
        UpdateNoCostService = 137,
        DeleteNoCostService = 138,
        #endregion خدمة بدون تكاليف 

        #endregion عميل

        #region موظف
        AdvancePaymentFromSafeToEmployee = 12,
        UpdateAdvancePaymentFromSafeToEmployee = 147,
        DeleteAdvancePaymentFromSafeToEmployee = 148,
        #endregion موظف

        #region سلفه
        AdvancePaymentFromEmployeeToSafe = 164,
        UpdateAdvancePaymentFromEmployeeToSafe = 165,
        DeleteAdvancePaymentFromEmployeeToSafe = 166,
        #endregion سلفه

        #region تحويل من خزنة لخزنة
        TransferFromSafeToSafe = 13,
        UpdateTransferFromSafeToSafe = 149,
        DeleteTransferFromSafeToSafe = 150,
        #endregion تحويل من خزنة لخزنة

        #region ايداع
        #region ايداع من عميل لبنك
        DepositFromCustomerToBank = 14,
        UpdateDepositFromCustomerToBank = 151,
        DeleteDepositFromCustomerToBank = 152,
        #endregion ايداع من عميل لبنك

        #region ايداع من خزنة لبنك
        DepositFromSafeToBank = 15,
        UpdateDepositFromSafeToBank = 153,
        DeleteDepositFromSafeToBank = 154,
        #endregion ايداع من خزنة لبنك

        #endregion ايداع

        #region سحب
        #region سحب من بنك لمورد
        ToWithdrawFromBankToSupplier = 16,
        UpdateToWithdrawFromBankToSupplier = 155,
        DeleteToWithdrawFromBankToSupplier = 156,
        #endregion سحب من بنك لمورد

        #region سحب من بنك لخزنة
        ToWithdrawFromBankToSafe = 17,
        UpdateToWithdrawFromBankToSafe = 157,
        DeleteToWithdrawFromBankToSafe = 158,
        #endregion سحب من بنك لخزنة

        #endregion سحب

        #region رصيد افتتاحي
        #region رصيد افتتاحي لمورد
        OpeningBalanceForSupplier = 19,
        UpdateOpeningBalanceForSupplier = 18,
        DeleteOpeningBalanceForSupplier=189,
        #endregion رصيد افتتاحي لمورد

        #region رصيد افتتاحي لعميل 
        OpeningBalanceForCustomer = 20,
        UpdateOpeningBalanceForCustomer = 199,
        DeleteOpeningBalanceForCustomer = 200,
        #endregion رصيد افتتاحي لعميل 

        #region رصيد افتتاحي لمخزن
        OpeningBalanceForStore = 21,
        UpdateOpeningBalanceForStore = 201,
        DeleteOpeningBalanceForStore = 202,
        #endregion رصيد افتتاحي لمخزن

        #region رصيد افتتاحي لخزنة
        OpeningBalanceForSafe = 22,
        UpdateOpeningBalanceForSafe = 203,
        DeleteOpeningBalanceForSafe = 204,
        #endregion رصيد افتتاحي لخزنة

        #region رصيد افتتاحي لبنك
        OpeningBalanceForBank = 23,
        UpdateOpeningBalanceForBank = 205,
        DeleteOpeningBalanceForBank = 206,
        #endregion رصيد افتتاحي لبنك

        #endregion رصيد افتتاحي

        #region الخصم

        #region خصم مكتسب
        EarnedDiscount = 24,
        UpdateEarnedDiscount = 26,
        DeleteEarnedDiscount = 25,
        #endregion خصم مكتسب

        #region خصم مسموح به
        DiscountPermitted = 27,
        UpdateDiscountPermitted = 29,
        DeleteDiscountPermitted = 28,
        #endregion خصم مسموح به

        #endregion الخصم

        #region فاتورة

        #region فاتورة مبيعات

        #region فاتورة مبيعات نقدي
        CashSalesInvoice = 34,
        UpdateCashSalesInvoice = 88,
        DeleteCashSalesInvoice = 89,
        #endregion فاتورة مبيعات نقدي

        #region فاتورة مبيعات نقدي لعميل
        CashSalesInvoiceForCustomer = 36,
        UpdateCashSalesInvoiceForCustomer = 31,
        DeleteCashSalesInvoiceForCustomer = 32,
        #endregion فاتورة مبيعات نقدي لعميل

        #region دفعة فاتورة مبيعات نقدي لعميل
        CashSalesInvoicePaymentForCustomer = 65,
        UpdateCashSalesInvoicePaymentForCustomer = 92,
        DeleteCashSalesInvoicePaymentForCustomer = 93,
        #endregion دفعة فاتورة مبيعات نقدي لعميل

        #region فاتورة مبيعات اجل لعميل
        DebitSalesInvoiceForCustomer = 30,
        UpdateDebitSalesInvoiceForCustomer = 94,
        DeleteDebitSalesInvoiceForCustomer = 95,
        #endregion فاتورة مبيعات اجل لعميل

        #region دفعة فاتورة مبيعات اجل لعميل
        DebitSalesInvoicePaymentForCustomer = 66,
        UpdateDebitSalesInvoicePaymentForCustomer = 96,
        DeleteDebitSalesInvoicePaymentForCustomer = 97,
        #endregion دفعة فاتورة مبيعات اجل لعميل

        #endregion فاتورة مبيعات

        #region فاتورة مشتريات

        #region فاتورة مشتريات نقدي
        CashPurchaseInvoice = 42,
        UpdatePurchaseInvoice = 46,
        DeletePurchaseInvoice = 47,
        #endregion فاتورة مشتريات نقدي

        #region فاتورة مشتريات نقدي لمورد
        CashPurchaseInvoiceForSupplier = 44,
        UpdateCashPurchaseInvoiceForSupplier = 80,
        DeleteCashPurchaseInvoiceForSupplier = 81,
        #endregion فاتورة مشتريات نقدي لمورد

        #region دفعة فاتورة مشتريات نقدي لمورد
        CashPurchaseInvoicePaymentForSupplier = 43,
        UpdateCashPurchaseInvoicePaymentForSupplier = 82,
        DeleteCashPurchaseInvoicePaymentForSupplier = 83,
        #endregion دفعة فاتورة مشتريات نقدي لمورد

        #region فاتورة مشتريات اجل لمورد 
        DebitPurchasesInvoiceForSupplier = 45,
        UpdateDebitPurchasesInvoiceForSupplier = 84,
        DeleteDebitPurchasesInvoiceForSupplier = 85,
        #endregion فاتورة مشتريات اجل لمورد

        #region دفعة فاتورة مشتريات اجل لمورد
        DebitPurchasesInvoicePaymentForSupplier = 67,
        UpdateDebitPurchasesInvoicePaymentForSupplier = 86,
        DeleteDebitPurchasesInvoicePaymentForSupplier = 87,
        #endregion دفعة فاتورة مشتريات اجل لمورد

        #endregion فاتورة مشتريات

        #endregion فاتورة

        #region مرتجع فاتورة

        #region مرتجع مبيعات

        #region فاتورة مرتجع مبيعات
        ReturnedSalesInvoice = 37,
        UpdateReturnedSalesInvoice = 38,
        DeleteReturnedSalesInvoice = 39,
        #endregion فاتورة مرتجع مبيعات

        #region فاتورة دفعة من عميل لمرتجع مبيعات
        SalesReturnPayment = 123,
        UpdateSalesReturnPayment = 124,
        DeleteSalesReturnPayment = 40,
        #endregion فاتورة دفعة من عميل لمرتجع مبيعات

        #region فاتورة مرتجع مبيعات نقدي بدون عميل 
        ReturnedSalesInvoiceCashWithoutCustomer = 127,
        UpdateReturnedSalesInvoiceCashWithoutCustomer = 128,
        DeleteReturnedSalesInvoiceCashWithoutCustomer = 129,
        #endregion فاتورة مرتجع مبيعات نقدي بدون عميل 

        #endregion مرتجع مبيعات

        #region مرتجع مشتريات

        #region فاتورة مرتجع مشتريات
        ReturnedPurchasesInvoice = 49,
        UpdateReturnedPurchasesInvoice = 50,
        DeleteReturnedPurchasesInvoice = 51,
        #endregion فاتورة مرتجع مشتريات

        #region فاتورة دفعة لمورد من مرتجع مشتريات
        ReturnedPurchasesPayment = 125,
        UpdateReturnedPurchasesPayment = 126,
        DeleteReturnedPurchasesPayment = 52,
        #endregion فاتورة دفعة لمورد من مرتجع مشتريات

        #endregion مرتجع مشتريات

        #endregion مرتجع فاتورة

        #region مصروفات

        #region مصروفات من خزنة
        ExpensesFromSafe = 53,
        UpdateExpensesFromSafe = 55,
        DeleteExpensesFromSafe = 57,
        #endregion مصروفات من خزنة

        #region مصروفات من بنك
        ExpensesFromBank = 54,
        UpdateExpensesFromBank = 56,
        DeleteExpensesFromBank = 58,
        #endregion مصروفات من بنك

        #region مصروفات من فيزا
        ExpensesFromVisa = 90,
        UpdateExpensesFromVisa = 91,
        DeleteExpensesFromVisa = 160,
        #endregion مصروفات من فيزا

        #region مصروفات من محفظة
        ExpensesFromWallet = 161,
        UpdateExpensesFromWallet = 162,
        DeleteExpensesFromWallet = 163,
        #endregion مصروفات من محفظة

        #region سحب جاري الشريك
        PartnerCurrentCheckout = 108,
        UpdatePartnerCurrentCheckout = 109,
        DeletePartnerCurrentCheckout = 110,
        #endregion سحب جاري الشريك

        #region ايداع جاري الشريك
        PartnerCurrentDeposit = 130,
        UpdatePartnerCurrentDeposit = 131,
        DeletePartnerCurrentDeposit = 132,
        #endregion ايداع جاري الشريك

        #endregion مصروفات

        #region ايرادات
        #region ايرادات الى خزنة
        RevenueToSafe = 117,
        UpdateRevenueToSafe = 118,
        DeleteRevenueToSafe = 119,
        #endregion ايرادات الى خزنة
        #region ايرادات الى بنك
        RevenueToBank = 120,
        UpdateRevenueToBank = 121,
        DeleteRevenueToBank = 122,
        #endregion ايرادات الى بنك
        #endregion ايرادات

        #region تحويل من مخزن لمخزن
        TransferFromStoreToStore = 59,
        UpdateTransferFromStoreToStore = 197,
        DeleteTransferFromStoreToStore = 198,
        #endregion

        #region تبديل منتجات
        ExchangeProducts = 60,
        UpdateExchangeProducts = 195,
        DeleteExchangeProducts = 196,
        #endregion

        #region تسوية بالاضافة
        PlusSettelment = 61,
        UpdatePlusSettelment = 193,
        DeletePlusSettelment = 194,
        #endregion

        #region تسوية بالعجز
        DeficitSettelment = 62,
        UpdateDeficitSettelment = 191,
        DeleteDeficitSettelment = 192,
        #endregion

        #region تحويل من بنك لبنك
        TransferFromBankToBank = 63,
        UpdateTransferFromBankToBank = 215,
        DeleteTransferFromBankToBank = 190,
        #endregion تحويل من بنك لبنك

        #region تقفيل وردية
        ShiftClose = 64,
        UpdateShiftClose=98,
        DeleteShiftClose=99,
        #endregion تقفيل وردية

        #region اوراق قبض 

        #region اوراق قبض الشركة
        CompanyReceiptPapers = 68,
        UpdateCompanyReceiptPapers=100,
        DeleteCompanyReceiptPapers=101,
        #endregion اوراق قبض الشركة

        #region استلام اوراق قبض الشركة
        ReceiveCompanyReceiptPapers = 69,
        UpdateReceiveCompanyReceiptPapers=102,
        DeleteReceiveCompanyReceiptPapers=103,
        #endregion استلام اوراق قبض الشركة

        #endregion اوراق قبض 

        #region اوراق دفع

        #region اوراق دفع الشركة
        CompanyPayPapers = 70,
        UpdateCompanyPayPapers=104,
        DeleteCompanyPayPapers=105,
        #endregion اوراق دفع الشركة

        #region سداد اوراق دفع الشركة
        PayCompanyPayPapers = 71,
        UpdatePayCompanyPayPapers=106,
        DeletePayCompanyPayPapers=107,
        #endregion سداد اوراق دفع الشركة

        #endregion اوراق دفع

        #region صيانة

        #region قيمة صيانة
        Maintenance = 77,
        UpdateMaintenance = 111,
        DeleteMaintenance = 112,
        #endregion قيمة صيانة

        #region دفعة من صيانة
        MaintenanceDeposit = 78, 
        UpdateMaintenanceDeposit = 113,
        DeleteMaintenanceDeposit = 114,
        #endregion دفعة من صيانة

        #region تكاليف صيانة
        MaintenanceCost = 79,
        UpdateMaintenanceCost = 115,
        DeleteMaintenanceCost = 116,
        #endregion تكاليف صيانة

        #region  استرداد دفعة العميل
        RefundCustomerPayment = 180,
        UpdateRefundCustomerPayment = 181,
        DeleteRefundCustomerPayment = 182,
        #endregion استرداد دفعة العميل
        #endregion صيانة

        EmptyJournalType = 212,

        #region غرامات و تعويضات

        #region غرامة الشيف لأوردر ديلفري
        DeliveryChefPenalty = 218,
        UpdateDeliveryChefPenalty = 219,
        DeleteDeliveryChefPenalty = 220,
        #endregion غرامة الشيف لأوردر ديلفري

        #region غرامة السائق لأوردر ديلفري
        DeliveryDriverPenalty = 221,
        UpdateDeliveryDriverPenalty = 222,
        DeleteDeliveryDriverPenalty = 223,
        #endregion غرامة السائق لأوردر ديلفري

        #region غرامة الشيف لأوردر استلام
        PickupChefPenalty = 224,
        UpdatePickupChefPenalty = 225,
        DeletePickupChefPenalty = 226,
        #endregion غرامة الشيف لأوردر استلام

        #region غرامة السائق
        WaitDriverPenalty = 233,
        UpdateWaitDriverPenalty = 234,
        DeleteWaitDriverPenalty = 235,
        #endregion غرامة السائق

        #endregion غرامات و تعويضات

        #region خدمات yumi

        #region خدمة للشيف
        ChefService = 227,
        UpdateChefService = 228,
        DeleteChefService = 229,
        #endregion خدمة للشيف

        #region خدمة للسائق
        DriverService = 230,
        UpdateDriverService = 231,
        DeleteDriverService = 232,
        #endregion خدمة للسائق

        #endregion

        // last journal type 238
    }
    public class JournalTypesParentId
    {
        public (string, string) GetDebitAndCreditParents(JournalType JournalType)
        {
            string DebitParentId = null;
            string CreditParentId = null;

            #region مورد
            #region دفعة لمورد
            #region دفعة لمورد من خزنة

            if (JournalType.PaymentToSupplierFromSafe == JournalType ||
                JournalType.UpdatePaymentToSupplierFromSafe == JournalType ||
                JournalType.DeletePaymentToSupplierFromSafe == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.2"; // خزنة
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة لمورد من خزنة

            #region دفعة لمورد من ينك
            if (JournalType.PaymentToSupplierFromBank == JournalType ||
                JournalType.UpdatePaymentToSupplierFromBank == JournalType ||
                JournalType.DeletePaymentToSupplierFromBank == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.1"; // البنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة لمورد من ينك

            #region دفعة لمورد من محفظة
            if (JournalType.PaymentToSupplierFromWallet == JournalType ||
                JournalType.UpdatePaymentToSupplierFromWallet == JournalType ||
                JournalType.DeletePaymentToSupplierFromWallet == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.3"; // المحافظ
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة لمورد من محفظة
            #endregion دفعة لمورد

            #region كاش من مورد
            if (JournalType.CashFromSupplier == JournalType||
                JournalType.UpdateCashFromSupplier == JournalType ||
                JournalType.DeleteCashFromSupplier == JournalType )
            {
                DebitParentId = "1.2.1.2"; // خزنة
                CreditParentId = "2.2.3.1"; // الموردين
                return (DebitParentId, CreditParentId);
            }
            #endregion كاش من مورد

            #region خدمة من مورد
            if (JournalType.ServiceFromSupplier == JournalType||
                JournalType.UpdateServiceFromSupplier == JournalType ||
                JournalType.DeleteServiceFromSupplier == JournalType )
            {
                DebitParentId = "3.1"; // المشتريات
                CreditParentId = "2.2.3.1"; // الموردين
                return (DebitParentId, CreditParentId);
            }
            #endregion خدمة من مورد

            #region دفع لمورد بالفيزا
            if (JournalType.SupplierPaymentByVisa == JournalType ||
                JournalType.UpdateSupplierPaymentByVisa == JournalType ||
                JournalType.DeleteSupplierPaymentByVisa == JournalType
                )
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.1" + "5"; //  مصروفات والبنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion دفع لمورد بالفيزا

            #endregion مورد

            #region عميل
            #region دفعة من عميل
            #region دفعة من عميل لخزنة
            if (JournalType.PaymentFromCustomerToSafe == JournalType||
                JournalType.UpdatePaymentFromCustomerToSafe == JournalType ||
                JournalType.DeletePaymentFromCustomerToSafe == JournalType )
            {
                DebitParentId = "1.2.1.2";// خزنة
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة من عميل لخزنة

            #region دفعة من عميل لبنك
            if (JournalType.PaymentFromCustomerToBank == JournalType ||
                JournalType.UpdatePaymentFromCustomerToBank == JournalType ||
                JournalType.DeletePaymentFromCustomerToBank == JournalType)
            {
                DebitParentId = "1.2.1.1" + "5"; //  مصروفات والبنوك
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة من عميل لبنك

            #region دفعة من عميل لمحفظة
            if (JournalType.PaymentFromCustomerToWallet == JournalType ||
                JournalType.UpdatePaymentFromCustomerToWallet == JournalType ||
                JournalType.DeletePaymentFromCustomerToWallet == JournalType)
            {
                DebitParentId = "1.2.1.3"; // المحافظ
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة من عميل لمحفظة
            #endregion دفعة من عميل

            #region دفعة لعميل 
            if (JournalType.CashToCustomer == JournalType||
                JournalType.UpdateCashToCustomer == JournalType ||
                JournalType.DeleteCashToCustomer == JournalType )
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // العملاء 
                CreditParentId = "1.2.1.2"; // خزنة
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة لعميل 

            #region دفع من عميل بالفيزا
            if (JournalType.CustomerPaymentWithVisa == JournalType||
                JournalType.UpdateCustomerPaymentWithVisa == JournalType ||
                JournalType.DeleteCustomerPaymentWithVisa == JournalType 
                )
            {
                DebitParentId = "1.2.1.1" + "5"; //  مصروفات والبنوك
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion دفع من عميل بالفيزا

            #region خدمة لعميل بتكاليف 
            if (JournalType.CostEffectiveCustomerService == JournalType ||
                JournalType.UpdateCostEffectiveCustomerService == JournalType ||
                JournalType.DeleteCostEffectiveCustomerService == JournalType )
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                CreditParentId = "4.1"; // المبيعات
                return (DebitParentId, CreditParentId);
            }
            #endregion خدمة لعميل بتكاليف 

            #region مصروف خدمة لعميل  
            if (JournalType.CustomerServiceExpense == JournalType||
                JournalType.UpdateCustomerServiceExpense == JournalType ||
                JournalType.DeleteCustomerServiceExpense == JournalType )
            {
                DebitParentId = "5"; // مصروفات
                CreditParentId = "1.2.1.2"; // الصناديق
                return (DebitParentId, CreditParentId);
            }
            #endregion مصروف خدمة لعميل  

            #region خدمة بدون تكاليف 
            if (JournalType.NoCostService == JournalType||
                JournalType.UpdateNoCostService == JournalType ||
                JournalType.DeleteNoCostService == JournalType )
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                CreditParentId = "4.1"; // المبيعات
                return (DebitParentId, CreditParentId);
            }
            #endregion خدمة بدون تكاليف 

            #endregion عميل

            #region موظف
            if (JournalType.AdvancePaymentFromSafeToEmployee == JournalType||
                JournalType.UpdateAdvancePaymentFromSafeToEmployee == JournalType ||
                JournalType.DeleteAdvancePaymentFromSafeToEmployee == JournalType )
            {
                DebitParentId = "2.2.3.2"; // الموظفين
                CreditParentId = "1.2.1.2"; // خزنة
            }
            #endregion موظف

            #region سلفه
            if (JournalType.AdvancePaymentFromEmployeeToSafe == JournalType ||
                JournalType.UpdateAdvancePaymentFromEmployeeToSafe == JournalType ||
                JournalType.DeleteAdvancePaymentFromEmployeeToSafe == JournalType)
            {
                DebitParentId = "1.2.1.2"; // خزنة
                CreditParentId = "2.2.3.2"; // الموظفين
            }
            #endregion سلفه

            #region فاتورة

            #region فاتورة مشتريات 

            #region فاتورة مشتريات نقدي
            if (JournalType.CashPurchaseInvoice == JournalType|| 
                JournalType.UpdatePurchaseInvoice == JournalType||
                JournalType.DeletePurchaseInvoice == JournalType)
            {
                DebitParentId = "3.1"; // المشتريات
                CreditParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // البنوك والصناديق والفيزا والمحفظة
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مشتريات نقدي

            #region فاتورة مشتريات نقدي لمورد
            if (JournalType.CashPurchaseInvoiceForSupplier == JournalType|| 
                JournalType.UpdateCashPurchaseInvoiceForSupplier == JournalType|| 
                JournalType.DeleteCashPurchaseInvoiceForSupplier == JournalType)
            {
                DebitParentId = "3.1"; // المشتريات 
                CreditParentId = "2.2.3.1"; // الموردين
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مشتريات نقدي لمورد

            #region دفعة فاتورة مشتريات نقدي لمورد
            if (JournalType.CashPurchaseInvoicePaymentForSupplier == JournalType||
                JournalType.UpdateCashPurchaseInvoicePaymentForSupplier == JournalType||
                JournalType.DeleteCashPurchaseInvoicePaymentForSupplier == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // البنوك والصناديق والفيزا والمحفظة
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مشتريات نقدي لمورد بدفعة

            #region فاتورة مشتريات اجل لمورد 
            if (JournalType.DebitPurchasesInvoiceForSupplier == JournalType||
                JournalType.UpdateDebitPurchasesInvoiceForSupplier == JournalType||
                JournalType.DeleteDebitPurchasesInvoiceForSupplier == JournalType)
            {
                DebitParentId = "3.1"; // المشتريات
                CreditParentId = "2.2.3.1"; // الموردين
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مشتريات اجل لمورد

            #region دفعة فاتورة مشتريات اجل لمورد
            if (JournalType.DebitPurchasesInvoicePaymentForSupplier == JournalType||
                JournalType.UpdateDebitPurchasesInvoicePaymentForSupplier == JournalType||
               JournalType.DeleteDebitPurchasesInvoicePaymentForSupplier == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // البنوك والصناديق والفيزا والمحفظة
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة فاتورة مشتريات اجل لمورد

            #endregion فاتورة مشتريات

            #region فاتورة مبيعات 

            #region فاتورة مبيعات نقدي
            if (JournalType.CashSalesInvoice == JournalType||
                JournalType.UpdateCashSalesInvoice == JournalType||
                JournalType.DeleteCashSalesInvoice == JournalType)
            {
                DebitParentId = "5" + "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // خزنة و بنك و فيزا و محفظة 
                CreditParentId = "4.1"; // المبيعات
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مبيعات نقدي

            #region فاتورة مبيعات نقدي لعميل
            if (JournalType.CashSalesInvoiceForCustomer == JournalType||
                JournalType.UpdateCashSalesInvoiceForCustomer == JournalType||
                JournalType.DeleteCashSalesInvoiceForCustomer == JournalType)
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // عميل 
                CreditParentId = "4.1"; // مبيعات
            }
            #endregion فاتورة مبيعات نقدي لعميل

            #region دفعة فاتورة مبيعات نقدي لعميل
            if (JournalType.CashSalesInvoicePaymentForCustomer == JournalType|| 
                JournalType.UpdateCashSalesInvoicePaymentForCustomer == JournalType||
                JournalType.DeleteCashSalesInvoicePaymentForCustomer == JournalType)
            {
                DebitParentId = "5" + "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // خزنة و بنك و فيزا و محفظة 
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // عميل
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة فاتورة مبيعات نقدي لعميل

            #region فاتورة مبيعات اجل لعميل
            if (JournalType.DebitSalesInvoiceForCustomer == JournalType||
                JournalType.UpdateDebitSalesInvoiceForCustomer == JournalType||
                JournalType.DeleteDebitSalesInvoiceForCustomer == JournalType)
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2";  // العملاء
                CreditParentId = "4.1"; // المبيعات
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مبيعات

            #region دفعة فاتورة مبيعات اجل لعميل
            if (JournalType.DebitSalesInvoicePaymentForCustomer == JournalType||
                JournalType.UpdateDebitSalesInvoicePaymentForCustomer == JournalType||
                JournalType.DeleteDebitSalesInvoicePaymentForCustomer == JournalType)
            {
                DebitParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // خزنة و بنك و فيزا و محفظة 
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // عميل
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة فاتورة مبيعات اجل لعميل

            #endregion فاتورة مبيعات
            #endregion فاتورة

            #region مرتجع فاتورة

            #region مرتجع مبيعات

            #region فاتورة مرتجع مبيعات
            if (JournalType.ReturnedSalesInvoice == JournalType||
                JournalType.UpdateReturnedSalesInvoice == JournalType||
                JournalType.DeleteReturnedSalesInvoice == JournalType)
            {
                DebitParentId = "3.2"; // مرتجع مبيعات
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مرتجع مبيعات

            #region فاتورة دفعة من عميل لمرتجع مبيعات
            if (JournalType.SalesReturnPayment == JournalType||
                JournalType.UpdateSalesReturnPayment == JournalType||
                JournalType.DeleteSalesReturnPayment == JournalType)
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                CreditParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // خزنة و بنك و فيزا و محفظة 
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة دفعة من عميل لمرتجع مبيعات

            #region فاتورة مرتجع مبيعات نقدي بدون عميل 
            if (JournalType.ReturnedSalesInvoiceCashWithoutCustomer == JournalType ||
                JournalType.UpdateReturnedSalesInvoiceCashWithoutCustomer == JournalType ||
                JournalType.DeleteReturnedSalesInvoiceCashWithoutCustomer == JournalType)
            {
                DebitParentId = "3.2"; // مرتجع مبيعات
                CreditParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // خزنة و بنك و فيزا و محفظة 
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مرتجع مبيعات نقدي بدون عميل 

            #endregion مرتجع مبيعات

            #region مرتجع مشتريات
            #region فاتورة مرتجع مشتريات
            if (JournalType.ReturnedPurchasesInvoice == JournalType||
                JournalType.UpdateReturnedPurchasesInvoice == JournalType||
                JournalType.DeleteReturnedPurchasesInvoice == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "4.2"; // مرتجع مشتريات
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة مرتجع مشتريات

            #region فاتورة دفعة لمورد من مرتجع مشتريات
            if (JournalType.ReturnedPurchasesPayment == JournalType||
                JournalType.UpdateReturnedPurchasesPayment == JournalType||
                JournalType.DeleteReturnedPurchasesPayment == JournalType)
            {
                DebitParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // خزنة و بنك و فيزا و محفظة 
                CreditParentId = "2.2.3.1"; // الموردين
                return (DebitParentId, CreditParentId);
            }
            #endregion فاتورة دفعة لمورد من مرتجع مشتريات
            #endregion مرتجع مشتريات

            #endregion مرتجع فاتورة

            #region تقفيل وردية
            if (JournalType.ShiftClose == JournalType||
                JournalType.UpdateShiftClose == JournalType||
                JournalType.DeleteShiftClose == JournalType)
            {
                DebitParentId = "1.2.1.2"; // الصناديق
                CreditParentId = "1.2.1.2"; // الصناديق
                return (DebitParentId, CreditParentId);
            }
            #endregion تقفيل وردية

            #region اوراق قبض 

            #region اوراق قبض الشركة
            if (JournalType.CompanyReceiptPapers == JournalType||
                JournalType.UpdateCompanyReceiptPapers == JournalType||
                JournalType.DeleteCompanyReceiptPapers == JournalType)
            {
                DebitParentId = "1.2.2"; //اوراق قبض الشركة
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // عميل 
            }
            #endregion اوراق قبض الشركة

            #region استلام اوراق قبض الشركة
            if (JournalType.ReceiveCompanyReceiptPapers == JournalType||
                JournalType.UpdateReceiveCompanyReceiptPapers == JournalType||
                JournalType.DeleteReceiveCompanyReceiptPapers == JournalType)
            {
                DebitParentId = "1.2.1.1" + "1.2.1.2"; // الصناديق او البنوك
                CreditParentId = "1.2.2"; //اوراق قبض الشركة
            }
            #endregion استلام اوراق قبض الشركة

            #endregion اوراق قبض 

            #region اوراق دفع

            #region اوراق دفع الشركة
            if (JournalType.CompanyPayPapers == JournalType||
                JournalType.UpdateCompanyPayPapers == JournalType||
                JournalType.DeleteCompanyPayPapers == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "2.2.3"; //اوراق دفع الشركة
            }
            #endregion اوراق دفع الشركة

            #region سداد اوراق دفع الشركة
            if (JournalType.PayCompanyPayPapers == JournalType||
                JournalType.UpdatePayCompanyPayPapers == JournalType||
                JournalType.DeletePayCompanyPayPapers == JournalType)
            {
                DebitParentId = "2.2.3"; //اوراق دفع الشركة
                CreditParentId = "1.2.1.1"; // البنوك
            }
            #endregion سداد اوراق دفع الشركة

            #endregion اوراق دفع

            #region الخصم

            #region خصم مسموح به
            if (JournalType.DiscountPermitted == JournalType||
                JournalType.UpdateDiscountPermitted == JournalType||
                JournalType.DeleteDiscountPermitted == JournalType)
            {
                DebitParentId = "5"; // خصم مسموح به
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion خصم مسموح به

            #region خصم مكتسب
            if (JournalType.EarnedDiscount == JournalType||
                JournalType.UpdateEarnedDiscount == JournalType||
                JournalType.DeleteEarnedDiscount == JournalType)
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "2.3"; // خصم مكتسب
                return (DebitParentId, CreditParentId);
            }
            #endregion خصم مكتسب

            #endregion الخصم

            #region مصروفات

            #region مصروفات من خزنة
            if (JournalType.ExpensesFromSafe == JournalType||
                JournalType.UpdateExpensesFromSafe == JournalType||
                JournalType.DeleteExpensesFromSafe == JournalType)
            {
                DebitParentId = "5"; // المصروفات
                CreditParentId = "1.2.1.2"; // خزنة
                return (DebitParentId, CreditParentId);
            }
            #endregion مصروفات من خزنة

            #region مصروفات من بنك
            if (JournalType.ExpensesFromBank == JournalType||
                JournalType.UpdateExpensesFromBank == JournalType||
                JournalType.DeleteExpensesFromBank == JournalType)
            {
                DebitParentId = "5"; // المصروفات
                CreditParentId = "1.2.1.1"; // البنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion مصروفات من بنك

            #region مصروفات من فيزا
            if (JournalType.ExpensesFromVisa == JournalType ||
                JournalType.UpdateExpensesFromVisa == JournalType ||
                JournalType.DeleteExpensesFromVisa == JournalType)
            {
                DebitParentId = "5"; // المصروفات
                CreditParentId = "1.2.1.1"; // البنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion مصروفات من فيزا

            #region مصروفات من محفظة
            if (JournalType.ExpensesFromWallet == JournalType ||
                JournalType.UpdateExpensesFromWallet == JournalType ||
                JournalType.DeleteExpensesFromWallet == JournalType)
            {
                DebitParentId = "5"; // المصروفات
                CreditParentId = "1.2.1.3"; // المحافظ
                return (DebitParentId, CreditParentId);
            }
            #endregion مصروفات من محفظة

            #region سحب جاري الشريك
            if (JournalType.PartnerCurrentCheckout == JournalType||
                JournalType.UpdatePartnerCurrentCheckout == JournalType||
                JournalType.DeletePartnerCurrentCheckout == JournalType)
            {
                DebitParentId = "2.3.3"; // جاري الشريك
                CreditParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3" ; // محفظة + خزنة + بنك + فيزا
                return (DebitParentId, CreditParentId);
            }
            #endregion حساب جاري الشريك

            #region ايداع جاري الشريك
            if (JournalType.PartnerCurrentDeposit == JournalType ||
                JournalType.UpdatePartnerCurrentDeposit == JournalType ||
                JournalType.DeletePartnerCurrentDeposit == JournalType)
            {
                DebitParentId = "1.2.1.2" + "1.2.1.1" + "1.2.1.3"; // محفظة + خزنة + بنك + فيزا
                CreditParentId = "2.3.3"; // جاري الشريك
                return (DebitParentId, CreditParentId);
            }
            #endregion ايداع جاري الشريك
            #endregion مصروفات

            #region صيانة

            #region قيمة صيانة
            if (JournalType.Maintenance == JournalType||
                JournalType.UpdateMaintenance == JournalType||
                JournalType.DeleteMaintenance == JournalType)
            {
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                CreditParentId = "4.1"; // المبيعات
                return (DebitParentId, CreditParentId);
            }
            #endregion قيمة صيانة

            #region دفعة من صيانة
            if (JournalType.MaintenanceDeposit == JournalType||
                JournalType.UpdateMaintenanceDeposit == JournalType||
                JournalType.DeleteMaintenanceDeposit == JournalType)
            {
                DebitParentId = "1.2.1.2"; // خزنة
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion دفعة من صيانة

            #region تكاليف صيانة
            if (JournalType.MaintenanceCost == JournalType||
                JournalType.UpdateMaintenanceCost == JournalType||
                JournalType.DeleteMaintenanceCost == JournalType)
            {
                DebitParentId = "5"; // مصروفات
                CreditParentId = "1.2.1.2"; // الصناديق
                return (DebitParentId, CreditParentId);
            }
            #endregion تكاليف صيانة

            #region استرداد دفعة العميل
            if (JournalType.RefundCustomerPayment == JournalType ||
                JournalType.UpdateRefundCustomerPayment == JournalType ||
                JournalType.DeleteRefundCustomerPayment == JournalType)
            {
                CreditParentId = "1.2.1.2"; // خزنة
                DebitParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion استرداد دفعة العميل

            #endregion صيانة

            #region ايرادات
            #region ايرادات الى خزنة
            if (JournalType.RevenueToSafe == JournalType ||
                JournalType.UpdateRevenueToSafe == JournalType ||
                JournalType.DeleteRevenueToSafe == JournalType)
            {
                DebitParentId = ""; // 
                CreditParentId = ""; // 
                return (DebitParentId, CreditParentId);
            }
            #endregion ايرادات الى خزنة

            #region ايرادات الى بنك
            if (JournalType.RevenueToBank == JournalType ||
                JournalType.UpdateRevenueToBank == JournalType ||
                JournalType.DeleteRevenueToBank == JournalType)
            {
                DebitParentId = ""; // 
                CreditParentId = ""; // 
                return (DebitParentId, CreditParentId);
            }
            #endregion ايرادات الى بنك
            #endregion ايرادات

            #region تحويل من خزنة لخزنة
            if (JournalType.TransferFromSafeToSafe == JournalType ||
                JournalType.UpdateTransferFromSafeToSafe == JournalType ||
                JournalType.DeleteTransferFromSafeToSafe == JournalType )
            {
                DebitParentId = "1.2.1.2"; // الصناديق
                CreditParentId = "1.2.1.2"; // الصناديق
                return (DebitParentId, CreditParentId);
            }
            #endregion تحويل من خزنة لخزنة

            #region تحويل من مخزن لمخزن
            if (JournalType.TransferFromStoreToStore == JournalType ||
                JournalType.UpdateTransferFromStoreToStore == JournalType ||
                JournalType.DeleteTransferFromStoreToStore == JournalType )
            {
                DebitParentId = "1.2.4"; // مخزن
                CreditParentId = "1.2.4"; // مخزن
                return (DebitParentId, CreditParentId);
            }
            #endregion تحويل من مخزن لمخزن

            #region تحويل من بنك لبنك
            if (JournalType.TransferFromBankToBank == JournalType ||
                JournalType.UpdateTransferFromBankToBank == JournalType ||
                JournalType.DeleteTransferFromBankToBank == JournalType )
            {
                DebitParentId = "1.2.1.1"; // البنوك
                CreditParentId = "1.2.1.1"; // البنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion تحويل من بنك لبنك

            #region ايداع
            #region ايداع من عميل لبنك
            if (JournalType.DepositFromCustomerToBank == JournalType||
                JournalType.UpdateDepositFromCustomerToBank == JournalType ||
                JournalType.DeleteDepositFromCustomerToBank == JournalType )
            {
                DebitParentId = "1.2.1.1"; // البنوك
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // العملاء
                return (DebitParentId, CreditParentId);
            }
            #endregion ايداع من عميل لبنك

            #region ايداع من خزنة لبنك
            if (JournalType.DepositFromSafeToBank == JournalType||
                JournalType.UpdateDepositFromSafeToBank == JournalType ||
                JournalType.DeleteDepositFromSafeToBank == JournalType )
            {
                DebitParentId = "1.2.1.1"; // البنوك
                CreditParentId = "1.2.1.2";// خزنة
                return (DebitParentId, CreditParentId);
            }
            #endregion ايداع من خزنة لبنك

            #endregion ايداع

            #region سحب
            #region سحب من بنك لمورد 
            if (JournalType.ToWithdrawFromBankToSupplier == JournalType||
                JournalType.UpdateToWithdrawFromBankToSupplier == JournalType ||
                JournalType.DeleteToWithdrawFromBankToSupplier == JournalType )
            {
                DebitParentId = "2.2.3.1"; // الموردين
                CreditParentId = "1.2.1.1"; // البنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion سحب من بنك لمورد 

            #region سحب من بنك لخزنة
            if (JournalType.ToWithdrawFromBankToSafe == JournalType||
                JournalType.UpdateToWithdrawFromBankToSafe == JournalType ||
                JournalType.DeleteToWithdrawFromBankToSafe == JournalType )
            {
                DebitParentId = "1.2.1.2";// خزنة
                CreditParentId = "1.2.1.1"; // البنوك
                return (DebitParentId, CreditParentId);
            }
            #endregion سحب من بنك لخزنة

            #endregion سحب

            #region تبديل منتجات
            if (JournalType.ExchangeProducts == JournalType ||
                JournalType.UpdateExchangeProducts == JournalType ||
                JournalType.DeleteExchangeProducts == JournalType )
            {
                DebitParentId = "1.2.4" + "2.3.2"; // مخزن + الارباح والخسائر
                CreditParentId = "1.2.4" + "2.3.2"; // مخزن + الارباح والخسائر
                return (DebitParentId, CreditParentId);
            }
            #endregion تبديل منتجات

            #region تسوية بالاضافة
            if (JournalType.PlusSettelment == JournalType ||
                JournalType.UpdatePlusSettelment == JournalType ||
                JournalType.DeletePlusSettelment == JournalType )
            {
                DebitParentId = "1.2.4"; // مخزن
                CreditParentId = "2.3.2"; // الارباح والخسائر
                return (DebitParentId, CreditParentId);
            }
            #endregion

            #region تسوية بالعجز
            if (JournalType.DeficitSettelment == JournalType||
                JournalType.UpdateDeficitSettelment == JournalType ||
                JournalType.DeleteDeficitSettelment == JournalType )
            {
                DebitParentId = "2.3.2"; // الارباح والخسائر
                CreditParentId = "1.2.4"; //مخزن 
                return (DebitParentId, CreditParentId);
            }
            #endregion

            #region رصيد افتتاحي 
            #region لمورد رصيد افتتاحي
            if (JournalType.OpeningBalanceForSupplier == JournalType ||
                JournalType.UpdateOpeningBalanceForSupplier == JournalType ||
                JournalType.DeleteOpeningBalanceForSupplier == JournalType )
            {
                DebitParentId = "2.3.1" + "2.2.3.1"; //   الموردين + راس المال
                CreditParentId = "2.3.1" + "2.2.3.1"; // الموردين + راس المال
            }
            #endregion لمورد رصيد افتتاحي

            #region لعميل رصيد افتتاحي
            if (JournalType.OpeningBalanceForCustomer == JournalType ||
                JournalType.UpdateOpeningBalanceForCustomer == JournalType ||
                JournalType.DeleteOpeningBalanceForCustomer == JournalType )
            {
                DebitParentId = "2.3.1" + "1.2.2.1" + "1.2.2.2"; // عميل + راس المال
                CreditParentId = "2.3.1" + "1.2.2.1" + "1.2.2.2"; // عميل + راس المال
            }
            #endregion لعميل رصيد افتتاحي

            #region لمخزن رصيد افتتاحي
            if (JournalType.OpeningBalanceForStore == JournalType||
                JournalType.UpdateOpeningBalanceForStore == JournalType ||
                JournalType.DeleteOpeningBalanceForStore == JournalType )
            {
                DebitParentId = "2.3.1" + "1.2.4"; //مخزن + راس المال
                CreditParentId = "2.3.1" + "1.2.4"; //مخزن + راس المال
            }
            #endregion لمخزن رصيد افتتاحي

            #region لخزنة رصيد افتتاحي
            if (JournalType.OpeningBalanceForSafe == JournalType||
                JournalType.UpdateOpeningBalanceForSafe == JournalType ||
                JournalType.DeleteOpeningBalanceForSafe == JournalType )
            {
                DebitParentId = "2.3.1" + "1.2.1.2"; //خزنة + راس المال
                CreditParentId = "2.3.1" + "1.2.1.2"; //خزنة + راس المال
            }
            #endregion لخزنة رصيد افتتاحي

            #region لبنك رصيد افتتاحي
            if (JournalType.OpeningBalanceForBank == JournalType ||
                JournalType.UpdateOpeningBalanceForBank == JournalType ||
                JournalType.DeleteOpeningBalanceForBank == JournalType )
            {
                DebitParentId = "2.3.1" + "1.2.1.1"; //بنك +راس المال
                CreditParentId = "2.3.1" + "1.2.1.1"; //بنك + راس المال
            }
            #endregion لبنك رصيد افتتاحي

            #endregion رصيد افتتاحي 

            #region غرامات وتعويضات

            #region غرامة الشيف لأوردر ديلفري
            if (JournalType.DeliveryChefPenalty == JournalType ||
                JournalType.UpdateDeliveryChefPenalty == JournalType ||
                JournalType.DeleteDeliveryChefPenalty == JournalType)
            {
                DebitParentId = "2.2.3.8"; // شيف 
                CreditParentId = "1.2.2.1" + "1.2.2.2" + "2.2.3.9" + "1.2.1.2"; // خزنة و عميل و سائق 
                return (DebitParentId, CreditParentId);
            }
            #endregion غرامة الشيف لأوردر ديلفري

            #region غرامة السائق لأوردر ديلفري
            if (JournalType.DeliveryDriverPenalty == JournalType ||
                JournalType.UpdateDeliveryDriverPenalty == JournalType ||
                JournalType.DeleteDeliveryDriverPenalty == JournalType)
            {
                DebitParentId = "2.2.3.9"; // سائق 
                CreditParentId = "1.2.2.1" + "1.2.2.2" + "2.2.3.8"; //  عميل و شيف
                return (DebitParentId, CreditParentId);
            }
            #endregion غرامة السائق لأوردر ديلفري

            #region غرامة الشيف لأوردر استلام
            if (JournalType.PickupChefPenalty == JournalType ||
                JournalType.UpdatePickupChefPenalty == JournalType ||
                JournalType.DeletePickupChefPenalty == JournalType)
            {
                DebitParentId = "2.2.3.8"; // شيف 
                CreditParentId = "1.2.2.1" + "1.2.2.2" + "1.2.1.2"; // خزنة و عميل  
                return (DebitParentId, CreditParentId);
            }
            #endregion غرامة الشيف لأوردر استلام

            #region غرامة السائق
            if (JournalType.WaitDriverPenalty == JournalType ||
                JournalType.UpdateWaitDriverPenalty == JournalType ||
                JournalType.DeleteWaitDriverPenalty == JournalType)
            {
                DebitParentId = "2.2.3.9"; // سائق 
                CreditParentId = "1.2.2.1" + "1.2.2.2"; // عميل  
                return (DebitParentId, CreditParentId);
            }
            #endregion غرامة السائق

            #endregion غرامات وتعويضات

            #region خدمات yumi

            #region خدمة للشيف
            if (JournalType.ChefService == JournalType ||
                JournalType.UpdateChefService == JournalType ||
                JournalType.DeleteChefService == JournalType)
            {
                DebitParentId = "3.1"; // المشتريات
                CreditParentId = "2.2.3.8"; // شيف 
                return (DebitParentId, CreditParentId);
            }
            #endregion خدمة للشيف

            #region خدمة للسائق
            if (JournalType.DriverService == JournalType ||
                JournalType.UpdateDriverService == JournalType ||
                JournalType.DeleteDriverService == JournalType)
            {
                DebitParentId = "3.1"; // المشتريات
                CreditParentId = "2.2.3.9"; // سائق 
                return (DebitParentId, CreditParentId);
            }
            #endregion خدمة للسائق

            #endregion خدمات yumi

            return (DebitParentId, CreditParentId);
        }
    }
    public static class ReturnJournalTypes
    {
        public static JournalType GetDeletedJournalTypeByOriginalJournalType(JournalType journalType)
        {
            switch (journalType)
            {             
                case JournalType.PaymentToSupplierFromSafe:
                    return JournalType.DeletePaymentToSupplierFromSafe;
                case JournalType.PaymentToSupplierFromBank:
                    return JournalType.DeletePaymentToSupplierFromBank;
                case JournalType.PaymentToSupplierFromWallet:
                    return JournalType.DeletePaymentToSupplierFromWallet;
                case JournalType.CashFromSupplier:
                    return JournalType.DeleteCashFromSupplier;
                case JournalType.ServiceFromSupplier:
                    return JournalType.DeleteServiceFromSupplier;
                case JournalType.PaymentFromCustomerToSafe:
                    return JournalType.DeletePaymentFromCustomerToSafe;
                case JournalType.PaymentFromCustomerToBank:
                    return JournalType.DeletePaymentFromCustomerToBank;
                case JournalType.PaymentFromCustomerToWallet:
                    return JournalType.DeletePaymentFromCustomerToWallet;
                case JournalType.CashToCustomer:
                    return JournalType.DeleteCashToCustomer;
                case JournalType.CustomerPaymentWithVisa:
                    return JournalType.DeleteCustomerPaymentWithVisa;
                case JournalType.CostEffectiveCustomerService:
                    return JournalType.DeleteCostEffectiveCustomerService;
                case JournalType.CustomerServiceExpense:
                    return JournalType.DeleteCustomerServiceExpense;
                case JournalType.NoCostService:
                    return JournalType.DeleteNoCostService;
                case JournalType.AdvancePaymentFromSafeToEmployee:
                    return JournalType.DeleteAdvancePaymentFromSafeToEmployee;
                case JournalType.AdvancePaymentFromEmployeeToSafe:
                    return JournalType.DeleteAdvancePaymentFromEmployeeToSafe;
                case JournalType.TransferFromSafeToSafe:
                    return JournalType.DeleteTransferFromSafeToSafe;
                case JournalType.DepositFromCustomerToBank:
                    return JournalType.DeleteDepositFromCustomerToBank;
                case JournalType.DepositFromSafeToBank:
                    return JournalType.DeleteDepositFromSafeToBank;
                case JournalType.ToWithdrawFromBankToSupplier:
                    return JournalType.DeleteToWithdrawFromBankToSupplier;
                case JournalType.ToWithdrawFromBankToSafe:
                    return JournalType.DeleteToWithdrawFromBankToSafe;
                case JournalType.OpeningBalanceForSupplier:
                    return JournalType.DeleteOpeningBalanceForSupplier;
                case JournalType.OpeningBalanceForCustomer:
                    return JournalType.DeleteOpeningBalanceForCustomer;
                case JournalType.OpeningBalanceForStore:
                    return JournalType.DeleteOpeningBalanceForStore;
                case JournalType.CashPurchaseInvoice:
                    return JournalType.DeletePurchaseInvoice;
                case JournalType.DebitSalesInvoicePaymentForCustomer:
                    return JournalType.DeleteDebitSalesInvoicePaymentForCustomer;
                case JournalType.DebitSalesInvoiceForCustomer:
                    return JournalType.DeleteDebitSalesInvoiceForCustomer;
                case JournalType.CashSalesInvoicePaymentForCustomer:
                    return JournalType.DeleteCashSalesInvoicePaymentForCustomer;
                case JournalType.CashSalesInvoiceForCustomer:
                    return JournalType.DeleteCashSalesInvoiceForCustomer;
                case JournalType.CashSalesInvoice:
                    return JournalType.DeleteCashSalesInvoice;
                case JournalType.DiscountPermitted:
                    return JournalType.DeleteDiscountPermitted;
                case JournalType.EarnedDiscount:
                    return JournalType.DeleteEarnedDiscount;
                case JournalType.OpeningBalanceForBank:
                    return JournalType.DeleteOpeningBalanceForBank;
                case JournalType.OpeningBalanceForSafe:
                    return JournalType.DeleteOpeningBalanceForSafe;
                case JournalType.CashPurchaseInvoiceForSupplier:
                    return JournalType.DeleteCashPurchaseInvoiceForSupplier;
                case JournalType.CashPurchaseInvoicePaymentForSupplier:
                    return JournalType.DeleteCashPurchaseInvoicePaymentForSupplier;
                case JournalType.DebitPurchasesInvoiceForSupplier:
                    return JournalType.DeleteDebitPurchasesInvoiceForSupplier;
                case JournalType.DebitPurchasesInvoicePaymentForSupplier:
                    return JournalType.DeleteDebitPurchasesInvoicePaymentForSupplier;
                case JournalType.ReturnedSalesInvoice:
                    return JournalType.DeleteReturnedSalesInvoice;
                case JournalType.SalesReturnPayment:
                    return JournalType.DeleteSalesReturnPayment;
                case JournalType.ReturnedSalesInvoiceCashWithoutCustomer:
                    return JournalType.DeleteReturnedSalesInvoiceCashWithoutCustomer;
                case JournalType.ReturnedPurchasesInvoice:
                    return JournalType.DeleteReturnedPurchasesInvoice;
                case JournalType.ReturnedPurchasesPayment:
                    return JournalType.DeleteReturnedPurchasesPayment;
                case JournalType.ExpensesFromSafe:
                    return JournalType.DeleteExpensesFromSafe;
                case JournalType.ExpensesFromVisa:
                    return JournalType.DeleteExpensesFromVisa;
                case JournalType.ExpensesFromBank:
                    return JournalType.DeleteExpensesFromBank;
                case JournalType.ExpensesFromWallet:
                    return JournalType.DeleteExpensesFromWallet;
                case JournalType.PartnerCurrentCheckout:
                    return JournalType.DeletePartnerCurrentCheckout;
                case JournalType.PartnerCurrentDeposit:
                    return JournalType.DeletePartnerCurrentDeposit;
                case JournalType.RevenueToSafe:
                    return JournalType.DeleteRevenueToSafe;
                case JournalType.RevenueToBank:
                    return JournalType.DeleteRevenueToBank;
                case JournalType.TransferFromStoreToStore:
                    return JournalType.DeleteTransferFromStoreToStore;
                case JournalType.ExchangeProducts:
                    return JournalType.DeleteExchangeProducts;
                case JournalType.PlusSettelment:
                    return JournalType.DeletePlusSettelment;
                case JournalType.DeficitSettelment:
                    return JournalType.DeleteDeficitSettelment;
                case JournalType.TransferFromBankToBank:
                    return JournalType.DeleteTransferFromBankToBank;
                case JournalType.ShiftClose:
                    return JournalType.DeleteShiftClose;
                case JournalType.CompanyReceiptPapers:
                    return JournalType.DeleteCompanyReceiptPapers;
                case JournalType.ReceiveCompanyReceiptPapers:
                    return JournalType.DeleteReceiveCompanyReceiptPapers;
                case JournalType.CompanyPayPapers:
                    return JournalType.DeleteCompanyPayPapers;
                case JournalType.PayCompanyPayPapers:
                    return JournalType.DeletePayCompanyPayPapers;
                case JournalType.Maintenance:
                    return JournalType.DeleteMaintenance;
                case JournalType.MaintenanceDeposit:
                    return JournalType.DeleteMaintenanceDeposit;
                case JournalType.MaintenanceCost:
                    return JournalType.DeleteMaintenanceCost;
                case JournalType.RefundCustomerPayment:
                    return JournalType.DeleteRefundCustomerPayment;
                case JournalType.DeliveryChefPenalty:
                    return JournalType.DeleteDeliveryChefPenalty;
                case JournalType.DeliveryDriverPenalty:
                    return JournalType.DeleteDeliveryDriverPenalty;
                case JournalType.PickupChefPenalty:
                    return JournalType.DeletePickupChefPenalty;
                case JournalType.ChefService:
                    return JournalType.DeleteChefService;
                case JournalType.DriverService:
                    return JournalType.DeleteDriverService;
                case JournalType.WaitDriverPenalty:
                    return JournalType.DeleteWaitDriverPenalty;
                case JournalType.SupplierPaymentByVisa:
                    return JournalType.DeleteSupplierPaymentByVisa;
                default:
                    return JournalType.EmptyJournalType;
            }
        }
        public static JournalType GetUpdatedJournalTypeByOriginalJournalType(JournalType journalType)
        {
            switch (journalType)
            {
                case JournalType.PaymentToSupplierFromSafe:
                    return JournalType.UpdatePaymentToSupplierFromSafe;
                case JournalType.PaymentToSupplierFromBank:
                    return JournalType.UpdatePaymentToSupplierFromBank;
                case JournalType.PaymentToSupplierFromWallet:
                    return JournalType.UpdatePaymentToSupplierFromWallet;
                case JournalType.CashFromSupplier:
                    return JournalType.UpdateCashFromSupplier;
                case JournalType.ServiceFromSupplier:
                    return JournalType.UpdateServiceFromSupplier;
                case JournalType.PaymentFromCustomerToSafe:
                    return JournalType.UpdatePaymentFromCustomerToSafe;
                case JournalType.PaymentFromCustomerToBank:
                    return JournalType.UpdatePaymentFromCustomerToBank;
                case JournalType.PaymentFromCustomerToWallet:
                    return JournalType.UpdatePaymentFromCustomerToWallet;
                case JournalType.CashToCustomer:
                    return JournalType.UpdateCashToCustomer;
                case JournalType.CustomerPaymentWithVisa:
                    return JournalType.UpdateCustomerPaymentWithVisa;
                case JournalType.CostEffectiveCustomerService:
                    return JournalType.UpdateCostEffectiveCustomerService;
                case JournalType.CustomerServiceExpense:
                    return JournalType.UpdateCustomerServiceExpense;
                case JournalType.NoCostService:
                    return JournalType.UpdateNoCostService;
                case JournalType.AdvancePaymentFromSafeToEmployee:
                    return JournalType.UpdateAdvancePaymentFromSafeToEmployee;
                case JournalType.AdvancePaymentFromEmployeeToSafe:
                    return JournalType.UpdateAdvancePaymentFromEmployeeToSafe;
                case JournalType.TransferFromSafeToSafe:
                    return JournalType.UpdateTransferFromSafeToSafe;
                case JournalType.DepositFromCustomerToBank:
                    return JournalType.UpdateDepositFromCustomerToBank;
                case JournalType.DepositFromSafeToBank:
                    return JournalType.UpdateDepositFromSafeToBank;
                case JournalType.ToWithdrawFromBankToSupplier:
                    return JournalType.UpdateToWithdrawFromBankToSupplier;
                case JournalType.ToWithdrawFromBankToSafe:
                    return JournalType.UpdateToWithdrawFromBankToSafe;
                case JournalType.OpeningBalanceForSupplier:
                    return JournalType.UpdateOpeningBalanceForSupplier;
                case JournalType.OpeningBalanceForCustomer:
                    return JournalType.UpdateOpeningBalanceForCustomer;
                case JournalType.OpeningBalanceForStore:
                    return JournalType.UpdateOpeningBalanceForStore;
                case JournalType.CashPurchaseInvoice:
                    return JournalType.UpdatePurchaseInvoice;
                case JournalType.DebitSalesInvoicePaymentForCustomer:
                    return JournalType.UpdateDebitSalesInvoicePaymentForCustomer;
                case JournalType.DebitSalesInvoiceForCustomer:
                    return JournalType.UpdateDebitSalesInvoiceForCustomer;
                case JournalType.CashSalesInvoicePaymentForCustomer:
                    return JournalType.UpdateCashSalesInvoicePaymentForCustomer;
                case JournalType.CashSalesInvoiceForCustomer:
                    return JournalType.UpdateCashSalesInvoiceForCustomer;
                case JournalType.CashSalesInvoice:
                    return JournalType.UpdateCashSalesInvoice;
                case JournalType.DiscountPermitted:
                    return JournalType.UpdateDiscountPermitted;
                case JournalType.EarnedDiscount:
                    return JournalType.UpdateEarnedDiscount;
                case JournalType.OpeningBalanceForBank:
                    return JournalType.UpdateOpeningBalanceForBank;
                case JournalType.OpeningBalanceForSafe:
                    return JournalType.UpdateOpeningBalanceForSafe;
                case JournalType.CashPurchaseInvoiceForSupplier:
                    return JournalType.UpdateCashPurchaseInvoiceForSupplier;
                case JournalType.CashPurchaseInvoicePaymentForSupplier:
                    return JournalType.UpdateCashPurchaseInvoicePaymentForSupplier;
                case JournalType.DebitPurchasesInvoiceForSupplier:
                    return JournalType.UpdateDebitPurchasesInvoiceForSupplier;
                case JournalType.DebitPurchasesInvoicePaymentForSupplier:
                    return JournalType.UpdateDebitPurchasesInvoicePaymentForSupplier;
                case JournalType.ReturnedSalesInvoice:
                    return JournalType.UpdateReturnedSalesInvoice;
                case JournalType.SalesReturnPayment:
                    return JournalType.UpdateSalesReturnPayment;
                case JournalType.ReturnedSalesInvoiceCashWithoutCustomer:
                    return JournalType.UpdateReturnedSalesInvoiceCashWithoutCustomer;
                case JournalType.ReturnedPurchasesInvoice:
                    return JournalType.UpdateReturnedPurchasesInvoice;
                case JournalType.ReturnedPurchasesPayment:
                    return JournalType.UpdateReturnedPurchasesPayment;
                case JournalType.ExpensesFromSafe:
                    return JournalType.UpdateExpensesFromSafe;
                case JournalType.ExpensesFromVisa:
                    return JournalType.UpdateExpensesFromVisa;
                case JournalType.ExpensesFromBank:
                    return JournalType.UpdateExpensesFromBank;
                case JournalType.ExpensesFromWallet:
                    return JournalType.UpdateExpensesFromWallet;
                case JournalType.PartnerCurrentCheckout:
                    return JournalType.UpdatePartnerCurrentCheckout;
                case JournalType.PartnerCurrentDeposit:
                    return JournalType.UpdatePartnerCurrentDeposit;
                case JournalType.RevenueToSafe:
                    return JournalType.UpdateRevenueToSafe;
                case JournalType.RevenueToBank:
                    return JournalType.UpdateRevenueToBank;
                case JournalType.TransferFromStoreToStore:
                    return JournalType.UpdateTransferFromStoreToStore;
                case JournalType.ExchangeProducts:
                    return JournalType.UpdateExchangeProducts;
                case JournalType.PlusSettelment:
                    return JournalType.UpdatePlusSettelment;
                case JournalType.DeficitSettelment:
                    return JournalType.UpdateDeficitSettelment;
                case JournalType.TransferFromBankToBank:
                    return JournalType.UpdateTransferFromBankToBank;
                case JournalType.ShiftClose:
                    return JournalType.UpdateShiftClose;
                case JournalType.CompanyReceiptPapers:
                    return JournalType.UpdateCompanyReceiptPapers;
                case JournalType.ReceiveCompanyReceiptPapers:
                    return JournalType.UpdateReceiveCompanyReceiptPapers;
                case JournalType.CompanyPayPapers:
                    return JournalType.UpdateCompanyPayPapers;
                case JournalType.PayCompanyPayPapers:
                    return JournalType.UpdatePayCompanyPayPapers;
                case JournalType.Maintenance:
                    return JournalType.UpdateMaintenance;
                case JournalType.MaintenanceDeposit:
                    return JournalType.UpdateMaintenanceDeposit;
                case JournalType.MaintenanceCost:
                    return JournalType.UpdateMaintenanceCost;
                case JournalType.RefundCustomerPayment:
                    return JournalType.UpdateRefundCustomerPayment;
                case JournalType.DeliveryChefPenalty:
                    return JournalType.UpdateDeliveryChefPenalty;
                case JournalType.DeliveryDriverPenalty:
                    return JournalType.UpdateDeliveryDriverPenalty;
                case JournalType.PickupChefPenalty:
                    return JournalType.UpdatePickupChefPenalty;
                case JournalType.ChefService:
                    return JournalType.UpdateChefService;
                case JournalType.DriverService:
                    return JournalType.UpdateDriverService;
                case JournalType.WaitDriverPenalty:
                    return JournalType.UpdateWaitDriverPenalty;
                case JournalType.SupplierPaymentByVisa:
                    return JournalType.UpdateSupplierPaymentByVisa;
                default:
                    return JournalType.EmptyJournalType;
            }
        }
    }
}
