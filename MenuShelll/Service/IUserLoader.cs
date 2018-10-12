using MenuShell.Domain;
using System.Collections.Generic;

namespace MenuShelll.Service
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}
