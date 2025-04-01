namespace Entity.Model
{
    public class ReservationDetailDTO
    {
        public int IdDetail { get; set; }
        public int IdReservation { get; set; }
        public int IdService { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime ServiceTime { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Subtotal { get; set; }
    }
}
