namespace MenuShell.Domain
{
    class SystemAdministrator : User
    {
        public SystemAdministrator(string username, string password, string role, User user) 
            :base(username, password, role)
        {

        }
    }
}
