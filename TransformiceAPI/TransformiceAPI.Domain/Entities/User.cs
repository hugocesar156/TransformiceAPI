namespace TransformiceAPI.Domain.Entities
{
    public class User
    {
        public User(int id, string email, string password, string salt, DateTime lastAccess)
        {
            Id = id;
            Email = email;
            Password = password;
            Salt = salt;
            LastAccess = lastAccess;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime LastAccess { get; set; }
    }
}
