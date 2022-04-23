using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Destinos
{
    public class Destino : AggregateRoot<Guid>
    {
        public Guid AereopuertoIdOrigen { get; private set; }
        public Guid AereopuertoIdDestino { get; private set; }
        public decimal DistanciaMillas { get; private set; }
        public TimeSpan TiempoMinutos { get; private set; }

        public Destino(Guid AereopuertoIdOrigen, Guid AereopuertoIdDestino, decimal DistanciaMillas, TimeSpan TiempoMinutos)
        {
            Id = Guid.NewGuid();
            this.AereopuertoIdOrigen = AereopuertoIdOrigen;
            this.AereopuertoIdDestino = AereopuertoIdDestino;
            this.DistanciaMillas  = DistanciaMillas;
            this.TiempoMinutos = TiempoMinutos;
        }  

    }
}
