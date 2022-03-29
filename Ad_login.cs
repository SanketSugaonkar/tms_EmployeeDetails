using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Ad_login
    {
        [Required(ErrorMessage = "UserName is required")]
        public string Admin_Id { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Ad_Password { get; set; }
    }
}
