using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum.ProductionEnums
{
    public enum InvoiceType
    {
        PurchaseInvoice = 1,                    //فاتورة شراء 
        SalesInvoice = 2,                       // فاتورة مبيعات
        ReceiveReturnInvoice = 3,               //فاتورة مرتجع مبيعات
        DisposeReturnInvoice = 4,               //فاتورة مرتجع مشتريات
    }
}
