using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Personales;

namespace Vuelos.Domain.Repositories
{
    public interface IVueloRepository : IRepository<Vuelo, Guid>
    {
        Task UpdateAsync(Vuelo obj);

    }
}
