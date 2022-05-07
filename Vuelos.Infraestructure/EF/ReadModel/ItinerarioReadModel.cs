using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Infraestructure.EF.ReadModel
{
    public class ItinerarioReadModel
    {
        public Guid IdItinerario { get; set; }
        public PistaReadModel Pista { get; set; }
        //public Guid IdPista { get; set; }
        public AeronaveReadModel Aeronave { get; set; }
        //public Guid IdAeronave { get; set; }
        public string NroVuelo { get; set; }
        public FechaValue FechaHoraDesde { get; set; }
        public FechaValue FechaHoraHasta { get; set; }
        public VueloReadModel Vuelo { get; set; }
    }
}
