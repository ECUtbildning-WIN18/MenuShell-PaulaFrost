using System;
using MenuShell.Domain;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MenuShell.Service
{
    class XMLUserLoader : IUserLoader 
    {
        public IDictionary<string, User> LoadUsers()
        {
            var users = new Dictionary<string, User>();

            var doc = XDocument.Load("Users.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;

                Enum.TryParse(role, out Role roleResult);

                users.Add(username, new User(username, password, roleResult));
            }

            return users;
        }
    }
}
