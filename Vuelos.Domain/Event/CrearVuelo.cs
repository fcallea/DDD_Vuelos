using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public class CrearVuelo : DomainEvent
    {
        public Guid VueloId { get; }
        public int NroVuelo { get; }

        public CrearVuelo(Guid vueloId,
            int nroVuelo) : base(DateTime.Now)
        {
            VueloId = vueloId;
            NroVuelo = nroVuelo;

        }
    }
}
