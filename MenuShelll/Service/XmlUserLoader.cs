using MenuShell.Domain;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MenuShell.Service
{
    class XMLUserLoader : IUserLoader 
    {
        public IDictionary<string, User> LoadUsers()
        {
            var users = new List<User>();

            var doc = XDocument.Load("Users.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;

                users.Add(new User(username, password, Role.Administrator));
            }

            return users; // ????
        }
    }
}
