using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Lugares;

namespace Vuelos.Domain.Repositories
{
    public interface ILugarRespository : IRepository<Lugar, Guid>
    {
        Task UpdateAsync(Destino obj);

        Task RemoveAsync(Destino obj);
    }
}
