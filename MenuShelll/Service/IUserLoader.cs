using MenuShell.Domain;
using System.Collections.Generic;

namespace MenuShell.Service
{
    interface IUserLoader
    {
        IDictionary<string, User> LoadUsers();
    }
}
