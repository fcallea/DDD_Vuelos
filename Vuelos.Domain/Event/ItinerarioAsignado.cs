using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public record ItinerarioAsignado : DomainEvent
    {
        public Guid IdItinerario { get; }
        public Guid IdPista { get; }
        public Guid IdAeronave { get; }
        public int NroVuelo { get; }
        public DateTime FechaHoraDesde { get; }
        public DateTime FechaHoraHasta { get; }


        public ItinerarioAsignado(Guid IdItinerario, Guid IdPista
        , Guid IdAeronave, int NroVuelo
        , DateTime FechaHoraDesde, DateTime FechaHoraHasta) : base(DateTime.Now)
        {
            this.IdItinerario = IdItinerario;
            this.IdPista = IdPista;
            this.IdAeronave = IdAeronave;
            this.NroVuelo = NroVuelo;
            this.FechaHoraDesde = FechaHoraDesde;
            this.FechaHoraHasta = FechaHoraHasta;
        }
    }
}
