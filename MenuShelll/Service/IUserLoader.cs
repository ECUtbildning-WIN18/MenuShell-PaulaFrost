using MenuShell.Domain;
using System.Collections.Generic;

namespace MenuShell.Service
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}
