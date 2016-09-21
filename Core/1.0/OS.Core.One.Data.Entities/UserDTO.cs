using OS.Core.One.Business.Entities;

namespace OS.Core.One.Data.Entities
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public UserDTO()
        {
        }

        public UserDTO(User domain)
        {
            Id = domain.Id;
            Email = domain.Email;
            FirstName = domain.FirstName;
            LastName = domain.LastName;
            UserName = domain.UserName;
            Password = domain.Password;
        }

        public User ToDomain()
        {
            return new User
            {
                Id = Id,
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                UserName = UserName,
                Password = Password
            };
        }
    }
}
