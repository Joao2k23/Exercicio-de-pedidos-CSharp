using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_fixação___seção_9.Entities.Enums;

namespace Exercício_de_fixação___seção_9.Entities.Enums
{
     enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
