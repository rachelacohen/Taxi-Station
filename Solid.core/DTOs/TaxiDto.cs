using DotenetProject.Solid.Core.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.DTOs
{
    public class TaxiDto
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public Driver Driver { get; set; }
    }
}
