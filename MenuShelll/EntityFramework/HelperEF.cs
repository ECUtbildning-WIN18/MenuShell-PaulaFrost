using System;
using System.Collections.Generic;
using System.Linq;
using MenuShell.Domain;

namespace MenuShell.EntityFramework
{
    class HelperEF
    {
        public IList<User> GetUser()
        {
            using (var db = new MenuShellDbContext())
            {
                return db.Users.ToList();
            }
        }

        public void SaveUser(User user)
        {
            using (var db = new MenuShellDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void ListUsers()
        {
            using (var db = new MenuShellDbContext())
            {
                var userList = db.Users.ToList();

                foreach (var user in userList)
                {
                    Console.WriteLine($"{user.UserName}");
                }
            }
        }

        public void DeleteUserByUsername(string username)
        {
            using (var db = new MenuShellDbContext())
            {
                var foundUser = db.Users.First(x => x.UserName == username);

                if (foundUser == null) return;

                db.Users.Remove(foundUser);
                db.SaveChanges();
            }
        }

        
    }
}
