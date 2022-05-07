using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Lugares
{
    public class Destino : Entity<Guid>
    {
        public Destino()
        {
            Id = Guid.NewGuid();
        }
    }
}
