using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum.YumiEnums
{
    public enum YumiStatus
    {
        NewOrderReceived = 1,
        DriverAccept = 2,
        ChefAccept = 3,
        ChefStart = 4,
        ChefFinished = 5,
        DriverReceived = 6,
        ClientReceivedOrder = 7,
        SystemCancelChefDelayed = 8,
        SystemCancelDriverDelayed = 9,
        DriverDelayedCustomerWaitDriverOrCancel = 10,
        DriverPenalty = 11,
        ChefPenalty = 12,
        DriverBonus = 13,
        CustomerBonus = 14,
        CustomerRefund = 15,
        ChefReceivedMoney = 16,
        AccountApproved = 17,
        ContractApproved = 18,
        CustomerCancelChefDelayed = 19,
        CustomerCancelDriverDelayed = 20,
        CustomerWaitChefDelayed = 21,
        CustomerWaitDriverDelayed = 22,
        DriverReceivedMoney = 23,
        SystemCancelNoDriverAccept = 24,
    }
}
