namespace MenuShell.Domain
{
    class User
    {
        public string UserName { get; }
        public string Password { get; }
        public string Role { get; }

        public User(string userName, string password, string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
