using System;

namespace Entity.Model
{
    public class ServiceDTO
    {
        public int IdService { get; set; }
        public int IdSupplier { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool BasePrice { get; set; }
        public int Duration { get; set; }
        public int MaximumCapacity { get; set; }
        public bool Available { get; set; }
        public string Requirements { get; set; }
        public bool Includes { get; set; }
    }

}