namespace MenuShell.Domain
{
    public class User
    {
        public string UserName { get; }
        public string Password { get; }
        public Role Role { get; }
        
        public User(string username, string password, Role role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
    }
}
