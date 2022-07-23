using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Lugares {
    public class Origen : Entity<Guid> {
        public Origen() {
            Id = Guid.NewGuid();
        }
    }
}
