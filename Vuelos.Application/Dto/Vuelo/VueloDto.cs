using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Application.Dto.Vuelo
{
    public class VueloDto
    {
        public Guid Id { get; set; }
        public Guid DestinoId { get; set; }
        public string NroVuelo { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraPartida { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public string TipoVuelo { get; set; }
        public Guid AeronaveEnPistaId { get; set; }

        public ICollection<Tripulante> Tripulantes { get; set; }
        public ICollection<Asiento> Asientos { get; set; }

        public VueloDto()
        {
            Tripulantes = new List<Tripulante>();
            Asientos = new List<Asiento>();
        }
    }
}
