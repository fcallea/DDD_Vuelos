using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public record AsientoAsignadoAgregado : DomainEvent
    {
        public Guid AsientoId { get; }
        public int Fila { get; }
        public int Columna { get; }
        public string Tipo { get; }
        public bool EsDisponible { get; }
        public AsientoAsignadoAgregado(Guid asientoId, int fila, int columna, string tipo) : base(DateTime.Now)
        {
            AsientoId = asientoId;
            this.Fila = fila;
            this.Columna = columna;
            this.Tipo = tipo;
            this.EsDisponible = true;
        }
    }
}
