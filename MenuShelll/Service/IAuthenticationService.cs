using MenuShell.Domain;

namespace MenuShell.Service
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
