using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos
{
    public class AeronaveEnPista : Entity<Guid>
    {
        public Guid AeropuertoId { get; private set; }
        public Guid PistaId { get; private set; }
        public Guid AeronaveId { get; private set; }

        internal AeronaveEnPista(Guid AeropuertoId, Guid PistaId, Guid AeronaveId)
        {
            Id = Guid.NewGuid();
            this.AeropuertoId = AeropuertoId;
            this.PistaId = PistaId;
            this.AeronaveId = AeronaveId;

        }

    }
}
