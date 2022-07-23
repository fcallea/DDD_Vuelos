using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Reservas;

namespace Vuelos.Domain.Repositories {
    public interface ReservaRepository : IRepository<Reserva, Guid> {
        Task UpdateAsync(Reserva obj);

        Task RemoveAsync(Reserva obj);
    }
}
