using System.Linq;
using MenuShell.Domain;

namespace MenuShell.EntityFramework
{
    class EFLogin
    {
        public User AuthenticateUser(string username, string password)
        {
            using (var db = new MenuShellDbContext())
            {
                foreach (var user in db.Users)
                {
                    if (username == user.UserName && password == user.Password)
                    {
                        return user;
                    }
                }

                return null;
            }
        }
    }
}
