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
        public Guid IdVuelo { get; }
        public int NroVuelo { get; }
        public DateTime FechaHoraPartida { get; }
        public DateTime FechaHoraLlegada { get; }        
        public decimal MillasVuelo { get; }
        public decimal TiempoVuelo { get; }

        public VueloCreado(Guid IdVuelo, int NroVuelo
        , DateTime FechaHoraPartida, DateTime FechaHoraLlegada
        , decimal MillasVuelo, decimal TiempoVuelo) : base(DateTime.Now)
        {
            this.IdVuelo = IdVuelo; 
            this.NroVuelo = NroVuelo;
            this.FechaHoraPartida = FechaHoraPartida;
            this.FechaHoraLlegada = FechaHoraLlegada;
            this.MillasVuelo = MillasVuelo;
            this.TiempoVuelo = TiempoVuelo;
        }
    }
}
