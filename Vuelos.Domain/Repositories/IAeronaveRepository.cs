using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aereonaves;

namespace Vuelos.Domain.Repositories
{
    public interface IAeronaveRepository : IRepository<Aeronave, Guid>
    {
        Task UpdateAsync(Aeronave obj);

        Task RemoveAsync(Aeronave obj);
    }
}
