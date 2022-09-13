using Global_Games.Data.Entities;
using Global_Games.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Global_Games.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserbyEmailAsync(string email);


        Task<IdentityResult> AddUserAsync(User user, string password);


        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> DeleteUserAsync(User user);

        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
    }
}
