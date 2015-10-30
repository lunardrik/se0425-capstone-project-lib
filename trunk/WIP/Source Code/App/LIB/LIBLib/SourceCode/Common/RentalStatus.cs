using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LIB
{
    public enum RentalStatus
    {
        [Description("Đang mượn")]
        NEW = 1,
        [Description("Đã trả")]
        FISNISHED = 2,
        [Description("Mất sách")]
        LOST = 3,
        [Description("Hỏng sách")]
        DAMAGED = 4
    }
}
