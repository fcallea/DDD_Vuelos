using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Vuelo
{
    public class TripulanteDto
    {
        public Guid VueloId { get; set; }
        public string Usuario { get; set; }
        public string Cargo { get; set; }
    }
}
