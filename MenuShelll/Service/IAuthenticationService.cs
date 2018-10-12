using MenuShell.Domain;

namespace MenuShelll.Service
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
