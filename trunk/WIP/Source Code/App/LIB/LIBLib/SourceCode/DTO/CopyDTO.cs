using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIB
{
    public class CopyDTO
    {
        public String Barcode { get; set; }
        public String ISBN { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public String StatusString
        {
            get
            {
                return EnumHelper.GetDescription((CopyStatus)Status);
            }
        }
    }
}
