using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Aereonaves
{
    public class Pista : Entity<Guid>
    {
        internal Pista()
        {
            Id = Guid.NewGuid();
        }
    }
}
