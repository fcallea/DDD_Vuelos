using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public record VueloCreado : DomainEvent
    {
        public Guid VueloId { get; }
        public Guid DestinoId { get; }
        public string NroVuelo { get; }
        public DateTime Fecha { get; }
        public TimeSpan HoraPartida { get; }
        public TimeSpan HoraLlegada { get; }
        public string TipoVuelo { get; }
        public Guid AeronaveEnPistaId { get; }

        public VueloCreado(Guid vueloId, Guid destinoId, string nroVuelo, DateTime fecha, TimeSpan horaPartida, TimeSpan horaLlegada, string tipoVuelo, Guid aeronaveEnPistaId) : base(DateTime.Now)
        {
            VueloId = vueloId;
            DestinoId = destinoId;
            NroVuelo = nroVuelo;
            Fecha = fecha;
            HoraPartida = horaPartida;
            HoraLlegada = horaLlegada;
            TipoVuelo = tipoVuelo;  
            AeronaveEnPistaId = aeronaveEnPistaId;  
        }
    }
}
