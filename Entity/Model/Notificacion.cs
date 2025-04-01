using System;

namespace Entity.Model
{
    public class Notificacion
    {
        public int IdNotificacion { get; set; }
        public int IdUsuario { get; set; }
        public int titulo { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fechacreacion { get; set; }
        
        public int tiponotificacion { get; set; }
    }
}
