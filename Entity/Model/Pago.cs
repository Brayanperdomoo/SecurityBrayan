using System;

namespace Entity.Model
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int Idreservation { get; set; }
        public decimal amount { get; set; }
        public DateTime paymentdate { get; set; }
        public double  paymentmethod{ get; set; }
        public string paymentreferefence { get; set; }
        public double status { get; set; }
    }
}

