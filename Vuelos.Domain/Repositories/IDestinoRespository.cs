using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Destinos;

namespace Vuelos.Domain.Repositories
{
    public interface IDestinoRespository : IRepository<Destino, Guid>
    {
        Task UpdateAsync(Destino obj);

        Task RemoveAsync(Destino obj);
    }
}
