using System.ComponentModel.DataAnnotations;

namespace SoapShop.BackEnd.Models.ViewModel
{
    public class CreateUserForm
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;
    }
}
