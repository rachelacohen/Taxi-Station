using DotenetProject.Solid.Core.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Source { get; set; }      
        public string Destination { get; set; }
        public string CustPhone { get; set; }
        public DateTime Order_time { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
