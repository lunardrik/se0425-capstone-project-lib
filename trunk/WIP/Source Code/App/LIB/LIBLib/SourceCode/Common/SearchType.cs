using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LIB
{
    public enum SearchType
    {
        [Description("Tìm Kiếm Đơn Giản")]
        BASIC_SEARCH = 0,
        [Description("Tìm Kiếm Chi Tiết")]
        DETAIL_SEARCH = 1,
        [Description("Tìm Kiếm Nâng Cao")]
        ADVANCE_SEARCH = 2
    }
}
