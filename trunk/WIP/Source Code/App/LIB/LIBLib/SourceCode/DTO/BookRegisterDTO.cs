using System;

namespace LIB
{
    public class BookRegisterDTO
    {
        public string UserId { get; set; }

        public string ISBN { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Note { get; set; }

        public BookRegisterStatus Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }


        // Datasource fields
        public string Username { get; set; }
        public string BookTitle { get; set; }
        public string StatusFriendly
        {
            get { return EnumHelper.GetDescription(Status); }
        }
        //public UserDTO UserDto { get; set; }
        //public CatalogueDTO CatalogueDto { get; set; }
    }
}
