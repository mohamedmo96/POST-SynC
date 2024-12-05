using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum.ProductionEnums
{
    public enum PermissionStatus
    {
        RequestDoneAndInProgress = 1,        //تم الطلب وجاري التجهيز
        Prepared = 2,                        //تم التجهيز
        Sent = 3,                            //تم الارسال
        Received = 4                         //تم الاستلام
    }
}
