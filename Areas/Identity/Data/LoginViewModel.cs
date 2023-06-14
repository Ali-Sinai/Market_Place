using System.ComponentModel.DataAnnotations;

namespace Market_Place.Areas.Identity.Data
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "رمزعبور")]
        public string Password { get; set; }

        [Display(Name = "مرا به یاد داشته باش")]
        public bool RememberMe { get; set; }
    }
}
