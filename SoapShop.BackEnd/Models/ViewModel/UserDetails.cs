using System.ComponentModel.DataAnnotations;

namespace SoapShop.BackEnd.Models.ViewModel
{
    public class UserDetails
    {
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
