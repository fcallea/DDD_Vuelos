using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Domain.Model.Itinerarios
{
    public class Itinerario : AggregateRoot<Guid>
    {
        public Guid IdPista { get; private set; }
        public Guid IdAeronave { get; private set; }
        public NroVueloValue NroVuelo { get; private set; }
        public FechaValue FechaHoraDesde { get; private set; }
        public FechaValue FechaHoraHasta { get; private set; }

        public Itinerario(Guid IdPista, Guid IdAeronave, NroVueloValue NroVuelo, FechaValue FechaHoraDesde, FechaValue FechaHoraHasta)
        {
            Id = Guid.NewGuid();
            this.IdPista = IdPista;
            this.IdAeronave = IdAeronave;
            this.NroVuelo = NroVuelo;   
            this.FechaHoraDesde = FechaHoraDesde;
            this.FechaHoraHasta = FechaHoraHasta;
        }

        public void ConfirmarItinerario()
        {
            var evento = new ItinerarioAsignado(Id, IdPista, IdAeronave, NroVuelo, FechaHoraDesde, FechaHoraHasta);
            AddDomainEvent(evento);
        }
    }
}

