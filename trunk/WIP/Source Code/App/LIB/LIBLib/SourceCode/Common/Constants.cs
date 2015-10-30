namespace LIB
{
    public class Constants
    {
        public static string SYSTEM_INFO = "Thông báo từ hệ thống";
        public static string SYSTEM_ERROR = "Có lỗi xảy ra!";
        public static string REQUEST_APPROVE = "Chấp nhận yêu cầu này?";
        public static string REQUEST_REJECT = "Từ chối yêu cầu này?";
        public static string REQUEST_DELETE = "Xóa yêu cầu này?";
        public static string REQUEST_SELECT = "Hãy chọn ít nhất một yêu cầu";
        public static string REQUEST_LOCK = "Yêu cầu này đã bị khóa!";
        public static string USER_INVALID = "Thẻ đọc giả này đã hết hạn";
        public static string RENTAL_INSERT_OK = "Cho mượn thành công!";
        public static string RENTAL_VALIDATE_USERID = "Mã đọc giả không hợp lệ!";
        public static string RENTAL_VALIDATE_BARCODE = "Mã sách không hợp lệ!";
        public static string RENTAL_VALIDATE_DUEDATE = "Ngày hết hạn phải lớn hơn ngày cho mượn!";
        public static string RENTAL_VALIDATE_EXPAND_DATE = "Ngày hết hạn mới phải lớn hơn ngày hết hạn cũ!";
        public static string RENTAL_EXPAND_OK = "Gia hạn thành công!";
        public static string RENTAL_SELECT= "Hãy chọn ít nhất một đề mục!";
        public static string RENTAL_LOCK = "Đề mục này đã khóa!";
        public static string RENTAL_EXPAND_LIMIT = "Đã đạt số lần gia hạn tối đa. Không thể gia hạn nữa!";
        public static string USER_EDIT_OK = "Sửa thông tin người dùng thành công!";
        public static string USER_INSERT_OK = "Thêm người dùng thành công!";
        public static string USER_VALIDATE_USERID = "Mã người dùng không hợp lệ!";
        public static string USER_VALIDATE_USERNAME = "Tên người dùng không hợp lệ!";
        public static string USER_VALIDATE_IDSN = "Số CMND không hợp lệ!";
        public static string USER_VALIDATE_PHONE = "Số điện thoại không hợp lệ!";
        public static string USER_VALIDATE_ADDRESS = "Địa chỉ không hợp lệ!";
        public static string USER_VALIDATE_EMAIL = "Email không hợp lệ";
        public static string USER_VALIDATE_EXPIRE_DATE = "Ngày hết hạn phải lớn hơn ngày cấp thẻ!";
        public static string USER_RESET_PASSWORD_CONFIRM = "Thiết lập lại mật mã?";
        public static string USER_RESET_PASSWORD_SUCCESS = "Thiết lập lại mật mã thành công!";
        public static string REQUEST_IMPORT = "Nhập dữ liệu thành công!";
        public static string REQUEST_NEW = "Yêu cầu mới";

        public static string Truncate(string inputString, int numberOfLetter)
        {
            var toLong = inputString.Length > numberOfLetter;
            var s = toLong ? inputString.Substring(0, numberOfLetter - 1) : inputString;
            s = toLong ? s.Substring(0, s.LastIndexOf(' ')) : s;
            return toLong ? s + "..." : s;
        }
    }
}