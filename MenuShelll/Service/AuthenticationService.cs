using MenuShell.Domain;

namespace MenuShell.Service
{
    class AuthenticationService : IAuthenticationService
    {
        private readonly IUserLoader _userLoader;

        public AuthenticationService(IUserLoader userLoader)
        {
            _userLoader = userLoader;
        }

        public User Authenticate(string username, string password)
        {
            User user = null;

            var users =_userLoader.LoadUsers();

            if (users.ContainsKey(username) && users[username].Password == password)
            {
                user = users[username];
            }

            return user;
        }
    }
}