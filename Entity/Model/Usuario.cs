using System;

namespace Entity.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string firstname { get; set; }

        public string lastname  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string phonenumber { get; set; }
        public DateTime registrationdate { get; set; }
        public bool status { get; set; }
        public string usertype { get; set; }
    }
}
