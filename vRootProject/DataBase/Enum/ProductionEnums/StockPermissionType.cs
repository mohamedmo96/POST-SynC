using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum
{
    public enum StockPermissionType
    {
        ReceiveOrderPermission = 1,            //اذن استلام طلبية مشتريات
        DisposeOrderPermission = 2,            //اذن صرف طلبية مبيعات
        ReceivePermission = 3,                 //اذن استلام مشتريات مباشر
        DisposePermission = 4,                 //اذن صرف مبيعات مباشر
        ReceiveReturnPermission = 5,           //اذن استلام مرتجع مبيعات
        DisposeReturnPermission = 6,           //اذن صرف مرتجع مشتريات
        SettlmentIn = 7,                       //تسوية بالاضافة
        SettlmentOut = 8,                      //تسوية بالعجز
        ReplacementIn = 9,                     //المنتج البديل
        ReplacementOut = 10,                    //المنتج المستبدل
        TransportationFrom = 11,               //نقل من مخزن
        TransportationTo = 12,                 //نقل الي مخزن 
        openBalanceStock = 13,                 //رصيد افتتاحي للمخزون
    }
}
