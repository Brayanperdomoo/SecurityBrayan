namespace Entity.Model
{
    public class ProveedorServico
    {
        public int Idproveedor { get; set; }
        public int Iduser { get; set; }
        public int commercialname { get; set; }
        public string description { get; set; }
        public int address { get; set; }
        public int telephonecontact { get; set; }
        public bool bilingual { get; set; }
        public int languages { get; set; }
        public double averagerating { get; set; }
        public bool verified { get; set; }

    }
}
