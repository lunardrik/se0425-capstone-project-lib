using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LIB
{
    public enum BookRegisterStatus
    {
        [Description("Mới")]
        NEW = 1,
        [Description("Chấp nhận")]
        APPROVED = 2,
        [Description("Từ chối")]
        REJECTED = 3
    }
}
