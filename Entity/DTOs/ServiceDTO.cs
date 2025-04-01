using System;

namespace Entity.Model
{
    public class ServiceDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool BasePrice { get; set; }
        public int Duration { get; set; }
        public int MaximumCapacity { get; set; }
        public string Requirements { get; set; }
    }

}