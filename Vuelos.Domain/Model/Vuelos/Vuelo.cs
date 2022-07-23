using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Domain.Model.Vuelos {
    public class Vuelo : AggregateRoot<Guid> {
        public Guid IdLugarOrigen { get; private set; }
        public Guid IdLugarDestino { get; private set; }
        public Guid IdItinerario { get; private set; }
        public Guid IdAeronave { get; private set; }
        public NroVueloValue NroVuelo { get; private set; }
        public FechaValue FechaHoraPartida { get; private set; }
        public FechaValue FechaHoraLlegada { get; private set; }
        public TipoVueloValue TipoVuelo { get; private set; }
        public decimal MillasVuelo { get; private set; }
        public decimal TiempoVuelo { get; private set; }
        public int StockAsientos { get; private set; }

        public Guid IdTripulacion { get; private set; }

        private readonly ICollection<TripulanteDeVuelo> _Tripulacion;
        public IReadOnlyCollection<TripulanteDeVuelo> Tripulantes {
            get {
                return new ReadOnlyCollection<TripulanteDeVuelo>(_Tripulacion.ToList());
            }
        }

        private readonly ICollection<ReservaDeVuelo> _Reserva;
        public IReadOnlyCollection<ReservaDeVuelo> Reservas {
            get {
                return new ReadOnlyCollection<ReservaDeVuelo>(_Reserva.ToList());
            }
        }

        private Vuelo() { }

        public Vuelo(
          Guid IdLugarOrigen, Guid IdLugarDestino
        , Guid IdItinerario, Guid IdAeronave, int NroVuelo
        , Guid IdTripulacion
        , DateTime FechaHoraPartida, DateTime FechaHoraLlegada
        , String TipoVuelo
        , decimal MillasVuelo, decimal TiempoVuelo) {
            Id = Guid.NewGuid();
            this.IdLugarOrigen = IdLugarOrigen;
            this.IdLugarDestino = IdLugarDestino;
            this.IdItinerario = IdItinerario;
            this.IdAeronave = IdAeronave;
            this.NroVuelo = new NroVueloValue(NroVuelo);
            this.FechaHoraPartida = new FechaValue(FechaHoraPartida);
            this.FechaHoraLlegada = new FechaValue(FechaHoraLlegada);
            this.TipoVuelo = new TipoVueloValue(TipoVuelo);
            this.MillasVuelo = MillasVuelo;
            this.TiempoVuelo = TiempoVuelo;
            this.IdTripulacion = IdTripulacion;
            _Tripulacion = new List<TripulanteDeVuelo>();
            _Reserva = new List<ReservaDeVuelo>();
        }

        public void ConsolidarVuelo() {
            var evento = new VueloCreado(Id, NroVuelo, FechaHoraPartida, FechaHoraLlegada, MillasVuelo, TiempoVuelo);
            AddDomainEvent(evento);
        }
    }
}
