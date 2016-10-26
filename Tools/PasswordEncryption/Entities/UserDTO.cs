namespace PasswordEncryption.Entities
{
    public class UserDTO
    {
        public int iEmployeeId { get; set; }

        public string strLoginName { get; set; }

        public string strPassword { get; set; }

        public string Salt { get; set; }
    }
}
