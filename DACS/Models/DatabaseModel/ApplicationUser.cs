using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DACS.Models.DatabaseModel
{
    public class ApplicationUser: IdentityUser
    {
        //Đây là thông tin user cần để đưa vào hệ thống
        [Required]
        [Length(1, 50, ErrorMessage = "Họ tên không quá 50 ký tự hoặc không để trống")]
        public string FullName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        //Cho phép null trường địa chỉ để có thể nhập vào sau khi đăng ký tài khoảng
        public string? Address { get; set; }
    }
}
