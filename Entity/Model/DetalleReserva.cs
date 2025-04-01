namespace Entity.Model
{
    public class DetalleReserva
    {
        public int IdDetalle { get; set; }
        public int Idreservation { get; set; }
        public int Idservice{ get; set; }
        public DateTime servicedate { get; set; }
        public DateTime servicetime { get; set; }
        public int numberofpeople { get; set; }
        public decimal subtotal { get; set; }
    }
}
