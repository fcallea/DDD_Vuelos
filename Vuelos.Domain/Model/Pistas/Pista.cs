using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Pistas
{
    internal class Pista : AggregateRoot<Guid>
    {
        public Pista()
        {
            Id = Guid.NewGuid();
        }
    }
}
