using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    internal class Reservations
    {
        public int ReservationsId { get; set; }
        public int ReservationDate { get; set; }
        public decimal Total { get; set; }
        public string SpecialNotes { get; set; }
    }
}
