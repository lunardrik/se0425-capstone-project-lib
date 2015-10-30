using System.ComponentModel;

namespace LIB
{
    public enum CopyStatus
    {
        [Description("Có thể mượn")]
        AVAILABLE = 1,
        [Description("Đã được mượn")]
        NOT_AVAIABLE = 2,
        [Description("Mất")]
        LOST = 3,
        [Description("Hỏng")]
        DAMAGED = 4
    }
}