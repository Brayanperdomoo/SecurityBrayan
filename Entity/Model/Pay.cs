using System;

namespace Entity.Model
{
    public class PayDTO
    {
        public int IdPay { get; set; }
        public int IdReservation { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public double  PaymentMethod{ get; set; }
        public string PaymentReferefence { get; set; }
        public double Status { get; set; }
    }
}

