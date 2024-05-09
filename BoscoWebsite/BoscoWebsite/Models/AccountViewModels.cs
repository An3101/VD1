using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoscoWebsite.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Không được để trống")]
        //[Display(Name = "UserName")]
        [Display(Name = "Tên đăng nhập")]
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        [Display(Name = "Ghi nhớ")]
        public bool RememberMe { get; set; }
    }
    public class CreatedAccountViewModel
    {
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Họ tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        public string Role { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Mật khẩu phải dài hơn 2 ký tự", MinimumLength = 6)]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Display(Name = "Nhập lại mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu và mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }
    }
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Không được để trống")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải dài hơn 2 ký tự", MinimumLength = 6)]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Mật khẩu")]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Display(Name = "Nhập lại mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu và mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Mật khẩu phải dài hơn 2 ký tự ", MinimumLength = 6)]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Display(Name = "Nhập lại mật khẩu")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Compare("Password", ErrorMessage = "Mật khẩu và mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
