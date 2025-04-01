using System;

namespace Entity.Model
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public int Idsupplier { get; set; }
        public int IdCategory { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool baseprice { get; set; }
        public int duration { get; set; }
        public int maximumcapacity { get; set; }
        public bool available { get; set; }
        public string requirements { get; set; }
        public string includes { get; set; }
        public string doesnotinclude { get; set; }

    }

}