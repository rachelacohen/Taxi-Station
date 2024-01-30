using DotenetProject.Solid.Core.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.DTOs
{
    public class DriverDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TaxiId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
