using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity.DTO
{
    public class DestinationActivityDTO
    {
        public int DestinationActivityId { get; set; }
        public string Name { get; set; }
    }
}