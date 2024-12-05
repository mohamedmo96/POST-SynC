using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum.YumiEnums
{
    public enum System_Action_Type
    {
        ChefReceivedPickupOrder = 0,
        ChefReceivedPickupPre_Order = 1,    
        ChefReceivedDeliveryOrder = 2,
        DriverOnTheWayOrder = 3,
        ChefReceivedDeliveryPre_Order = 4,
        DriverOnTheWayPre_Order = 5,
        WaitDriverAcceptDeliveryOrder = 6,
        WaitDriverDeliveryPre_Order = 7,
        CustomerWaitDriverOrder = 8,
        CustomerWaitDriverPre_Order = 9,
    }
}
