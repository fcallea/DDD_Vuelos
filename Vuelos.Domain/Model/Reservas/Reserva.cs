using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Reservas
{
    public class Reserva : AggregateRoot<Guid>
    {
        public Guid IdPasajero { get; private set; }

        public Reserva(Guid IdPasajero)
        {
            Id = Guid.NewGuid();
            this.IdPasajero = IdPasajero;
        }
    }
}
