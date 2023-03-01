using System.Security.Claims;

namespace SoapShop.BackEnd.Extension
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetCurrentUserId(this ClaimsPrincipal user)
        {
            ArgumentNullException.ThrowIfNull(user);
            return user.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new InvalidOperationException("Current user Id is null");
        }
    }
}
