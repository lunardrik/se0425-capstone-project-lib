using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LIB
{
    public enum UserStatus
    {
        [Description("Đang hoạt động")]
        ACTIVE = 1,
        [Description("Khóa")]
        PASSIVE = 2,
    }
}
