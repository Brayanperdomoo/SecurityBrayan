using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string TradeName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Language { get; set; }
        public string Qualifications { get; set; }
    }
}
