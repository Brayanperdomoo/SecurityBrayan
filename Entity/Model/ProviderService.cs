namespace Entity.Model
{
    public class ProviderServiceDTO
    {
        public int IdProvider { get; set; }
        public int IdUser { get; set; }
        public int CommercialName { get; set; }
        public string Description { get; set; }
        public int Address { get; set; }
        public int TelephoneContact { get; set; }
        public bool Bilingual { get; set; }
        public int Languages { get; set; }
        public double Averagerating { get; set; }
        public bool Verified { get; set; }

    }
}
