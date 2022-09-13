using Global_Games.Data.Entities;
using Global_Games.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Global_Games.Data
{
    public class SeedDb
    {
        private readonly DataContext _contex;
        private readonly IUserHelper _userHelper;
        private Random _random;

        public SeedDb(DataContext contex, IUserHelper userHelper)
        {
            _contex = contex;
            _userHelper = userHelper;
            _random = new Random();
        }

        

        

        public async Task SeedAsync()
        {
            await _contex.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserbyEmailAsync("ngoncalorsilva@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Nuno",
                    LastName = "Silva",
                    Email = "ngoncalorsilva@gmail.com",
                    UserName = "ngoncalorsilva@gmail.com",
                    PhoneNumber = "212344555"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!_contex.Newsletters.Any())
            {

                _contex.Newsletters.Add(new Newsletter
                {
                   Id = 1,
                   Email = "teste@gmail.com",
                   User = user
                });

                _contex.Budgets.Add(new Budget
                {
                    Id = 1,
                    Name = "Maria",
                    Message = "Quero mais info.",
                    Email = "teste@gmail.com",
                    User = user
                });
            }



        }
    }
}
