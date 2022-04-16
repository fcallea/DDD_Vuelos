using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Vuelos.Domain.Event;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Model
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public int NroVuelo;
        public ICollection<DetalleVuelo> Detalle { get; private set; }

        public Vuelo(int nroVuelo)
        {
            Id = Guid.NewGuid();
            NroVuelo = nroVuelo;
            Detalle = new List<DetalleVuelo>();
        }

        public void ConfirmarVuelo()
        {
            var evento = new CrearVuelo(Id, NroVuelo);
            AddDomainEvent(evento);
        }
    }
}
