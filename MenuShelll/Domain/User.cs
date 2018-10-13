namespace MenuShell.Domain
{
    class User
    {
        public string UserName { get; }
        public string Password { get; }
        public string Role { get; }
        
        public User(string username, string password, string role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
    }
}
