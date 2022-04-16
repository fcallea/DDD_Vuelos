using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Aeronaves
{
    public class Aeronave : AggregateRoot<Guid>
    {
        public Aeronave()
        {
            Id = Guid.NewGuid();
        }

    }
}
