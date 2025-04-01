using System;

namespace Entity.Model
{
    public class NotificationDTO
    {
        public int IdNotification { get; set; }
        public int IdUser { get; set; }
        public int Title { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }
        public int NotificationType { get; set; }
    }
}
