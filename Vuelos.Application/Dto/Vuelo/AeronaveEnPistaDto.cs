using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Vuelo
{
    public class AeronaveEnPistaDto
    {
        public Guid VueloId { get; set; }
        public Guid AeropuertoId { get; set; }
        public Guid PistaId { get; set; }
        public Guid AeronaveId { get; set; }
    }
}
