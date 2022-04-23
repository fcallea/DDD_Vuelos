using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public record DestinoCreado : DomainEvent
    {
        public Guid DestinoId { get; }
        public Guid AereopuertoIdOrigen { get; }
        public Guid AereopuertoIdDestino { get; }
        public decimal DistanciaMillas { get; }
        public TimeSpan TiempoMinutos { get; }

        public DestinoCreado(Guid DestinoId, Guid AereopuertoIdOrigen, Guid AereopuertoIdDestino, decimal DistanciaMillas, TimeSpan TiempoMinutos) : base(DateTime.Now)
        {
            this.DestinoId = DestinoId;
            this.AereopuertoIdOrigen = AereopuertoIdOrigen;
            this.AereopuertoIdDestino = AereopuertoIdDestino;
            this.DistanciaMillas = DistanciaMillas;
            this.TiempoMinutos = TiempoMinutos;
        }
    }
}
