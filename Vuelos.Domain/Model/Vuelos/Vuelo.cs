using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Model.Personales
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public Guid DestinoId { get; private set; }
        public string NroVuelo { get; private set; }
        public DateTime Fecha { get; private set; }
        public TimeSpan HoraPartida { get; private set; }
        public TimeSpan HoraLlegada { get; private set; }
        public string TipoVuelo { get; private set; }
        public Guid AeronaveEnPistaId { get; private set; }

        private readonly ICollection<Tripulante> _tripulante;
        public IReadOnlyCollection<Tripulante> Tripulantes
        {   get
            {
                return new ReadOnlyCollection<Tripulante>(_tripulante.ToList());
            }
        }

        private readonly ICollection<Asiento> _asiento;
        public IReadOnlyCollection<Asiento> Asientos
        {   get
            {
                return new ReadOnlyCollection<Asiento>(_asiento.ToList());
            }
        }


        private Vuelo() { }

        internal Vuelo(Guid DestinoId, string NroVuelo, DateTime Fecha, TimeSpan HoraPartida, TimeSpan HoraLlegada, string TipoVuelo, Guid AeronaveEnPistaId)
        {
            Id = Guid.NewGuid();
            this.DestinoId = DestinoId;
            this.NroVuelo = NroVuelo;
            this.Fecha = Fecha;
            this.HoraPartida = HoraPartida;
            this.HoraLlegada = HoraLlegada;
            this.TipoVuelo = TipoVuelo;
            this.AeronaveEnPistaId = AeronaveEnPistaId;
            _tripulante = new List<Tripulante>();
            _asiento = new List<Asiento>();
        }
    }
}
