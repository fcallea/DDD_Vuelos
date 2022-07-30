using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Vuelo {
    public class ItinerarioDto {
        public Guid IdPista { get; set; }
        public Guid IdAeronave { get; set; }
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }
    }
}
