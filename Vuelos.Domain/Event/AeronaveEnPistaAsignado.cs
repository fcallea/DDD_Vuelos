using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public record AeronaveEnPistaAsignado : DomainEvent
    {
        public Guid AeronaveEnPistaId { get; }
        public Guid AeropuertoId { get; }
        public Guid PistaId { get;  }
        public Guid AeronaveId { get;  }

        public AeronaveEnPistaAsignado(Guid AeronaveEnPistaId, Guid AeropuertoId, Guid PistaId, Guid AeronaveId) : base(DateTime.Now)
        {
            this.AeronaveEnPistaId = AeronaveEnPistaId;
            this.AeropuertoId = AeropuertoId;
            this.PistaId = PistaId;
            this.AeronaveId = AeronaveId;
        }
    }
}
