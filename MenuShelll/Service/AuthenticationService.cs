using MenuShell.Domain;
using System.Linq;

namespace MenuShell.Service
{
    class AuthenticationService : IAuthenticationService
    {
        public readonly IUserLoader _userLoader;

        public AuthenticationService()
        {
            _userLoader = new UserLoader();
        }

        public User Authenticate(string username, string password)
        {
            var userLoader = new UserLoader();

            var users = userLoader.LoadUsers();

            return users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }
    }
}