using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class RentalDTO
    {
        // Database fields
        public string UserId { get; set; }

        public string Barcode { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public float Fine { get; set; }

        public RentalStatus Status { get; set; }

        // ++ 2012/03/14 DiepTN: Add
        public int ExpandCount { get; set; }
        // --

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }


        // GUI fields
        public string StatusFriendly
        {
            get { return EnumHelper.GetDescription(Status); }
        }

        // User info
        public string Username { get; set; }

        // Catalogue info
        public string BookTitle { get; set; }
        public float BookPrice { get; set; }
        public int ExpandLimit { get; set; }
        public int ExpandDateLimit { get; set; }
    }
}
