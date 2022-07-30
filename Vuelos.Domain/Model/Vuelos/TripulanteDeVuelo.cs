using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos {
    public class TripulanteDeVuelo : Entity<Guid> {
        public Guid IdTripulante { get; private set; }
        public Guid IdCargo { get; private set; }

        public Guid IdCargo2 { get; private set; }

        internal TripulanteDeVuelo(Guid IdTripulante, Guid IdCargo) {
            Id = Guid.NewGuid();
            this.IdTripulante = IdTripulante;
            this.IdCargo = IdCargo;
        }
    }
}
