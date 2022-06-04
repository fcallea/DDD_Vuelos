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

        public Itinerario(Guid idPista, Guid idAeronave, int nroVuelo, DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            Id = Guid.NewGuid();
            IdPista = idPista;
            IdAeronave = idAeronave;
            NroVuelo = new NroVueloValue(nroVuelo);   
            FechaHoraDesde = new FechaValue(fechaHoraDesde);
            FechaHoraHasta = new FechaValue(fechaHoraHasta);
        }

        public void ConfirmarItinerario()
        {
            var evento = new ItinerarioAsignado(Id, IdPista, IdAeronave, NroVuelo, FechaHoraDesde, FechaHoraHasta);
            AddDomainEvent(evento);
        }
    }
}

