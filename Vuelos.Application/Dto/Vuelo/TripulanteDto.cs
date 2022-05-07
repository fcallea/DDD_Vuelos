using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Vuelo
{
    public class TripulanteDto
    {
        public Guid IdTripulante { get; set; }
        public Guid IdCargo { get; set; }

        public TripulanteDto()
        {
            ;
        }
    }
}
