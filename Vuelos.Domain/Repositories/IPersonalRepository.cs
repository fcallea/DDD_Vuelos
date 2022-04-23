using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Personales;

namespace Vuelos.Domain.Repositories
{
    public interface IPersonalRepository : IRepository<Personal, Guid>
    {
        Task UpdateAsync(Personal obj);

        Task RemoveAsync(Personal obj);
    }
}
