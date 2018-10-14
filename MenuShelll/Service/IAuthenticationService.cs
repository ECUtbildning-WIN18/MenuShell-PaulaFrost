using MenuShell.Domain;

namespace MenuShell.Service
{
    public interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
