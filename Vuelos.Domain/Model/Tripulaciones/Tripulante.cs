using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Tripulaciones {
    public class Tripulante : Entity<Guid> {
        public Guid IdTripulante { get; private set; }
        public Guid IdCargo { get; private set; }

        public Tripulante(Guid IdTripulante, Guid IdCargo) {
            Id = Guid.NewGuid();
            this.IdTripulante = IdTripulante;
            this.IdCargo = IdCargo;
        }
    }
}
