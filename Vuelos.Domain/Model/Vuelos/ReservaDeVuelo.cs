using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos
{
    public class ReservaDeVuelo : Entity<Guid>
    {
        public Guid IdReserva { get; private set; }
        public Guid IdPasajero { get; private set; }

        internal ReservaDeVuelo(Guid IdReserva, Guid IdPasajero)
        {
            Id = Guid.NewGuid();
            this.IdReserva = IdReserva;
            this.IdPasajero = IdPasajero;
        }
    }
}
