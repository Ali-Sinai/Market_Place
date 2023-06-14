using System.ComponentModel.DataAnnotations;

namespace Market_Place.Areas.Identity.Data
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "رمز های عبور همخوانی ندارند")]
        [Display(Name = "تکرار رمز عبور")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

    }
}
