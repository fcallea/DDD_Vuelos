using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Application.Dto.Vuelo
{
    public class VueloDto
    {
        public Guid IdLugarDestino { get; set; }
        public Guid IdItinerario { get; set; }
        public Guid IdTripulacion { get; set; }
        public DateTime FechaHoraPartida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public string TipoVuelo { get; set; }
        public decimal MillasVuelo { get; set; }
        public ICollection<TripulanteDto> Tripulantes { get; set; }
        public Guid Id { get; internal set; }
        public NroVueloValue NroVuelo { get; internal set; }

        public VueloDto()
        {
            Tripulantes = new List<TripulanteDto>();
        }
    }
}
