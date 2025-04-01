using System;

namespace Entity.Model
{
    public class UserDTO
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Status { get; set; }
        public string UserType { get; set; }
    }
}
