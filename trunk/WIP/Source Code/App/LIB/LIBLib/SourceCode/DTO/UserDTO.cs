using System;

namespace LIB
{
    public class UserDTO
    {
        public string UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string IDSN { get; set; }

        public DateTime IssuedDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        public UserStatus Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        // GUI fields
        public string RoleDescription { get; set; }
        public string StatusFriendly
        {
            get { return EnumHelper.GetDescription(Status); }
        }
    }
}
