namespace OS.Core.One.Business.Entities
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Profession { get; set; }
        public string Avatar { get; set; }
    }
}
