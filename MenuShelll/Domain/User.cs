namespace MenuShell.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User()
        {

        }

        public User(string username, string password, Role role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
    }
}
