using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    internal class AvailabilityDTO
    {
        public int AvailabilityId { get; set; }
        public int Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
