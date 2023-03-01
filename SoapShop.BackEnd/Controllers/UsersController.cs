using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SoapShop.BackEnd.Extension;
using SoapShop.BackEnd.Models;
using SoapShop.BackEnd.Models.ViewModel;
using System.Security.Claims;

namespace SoapShop.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<CreateUserForm>> PostUser(CreateUserForm user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userManager.CreateAsync(
                new ApplicationUser() { UserName = user.UserName, Email = user.Email /*, Goal = user.Goal*/},
                user.Password
            );

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            user.Password = null!;
            return CreatedAtAction(nameof(GetUser), new { userName = user.UserName }, user);
        }

        // GET: api/Users/username
        [HttpGet(nameof(GetUser))]
        public async Task<ActionResult<UserDetails>> GetUser(string username)
        {
            ApplicationUser? user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return NotFound();
            }

            return new UserDetails
            {
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                //Goal= user.Goal ?? string.Empty
            };
        }
    }
}
