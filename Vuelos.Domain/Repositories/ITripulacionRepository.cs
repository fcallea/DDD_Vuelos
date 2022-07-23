using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Tripulaciones;

namespace Vuelos.Domain.Repositories {
    public interface ITripulacionRepository : IRepository<Tripulacion, Guid> {
        Task UpdateAsync(Tripulacion obj);

        Task RemoveAsync(Tripulacion obj);
    }
}
