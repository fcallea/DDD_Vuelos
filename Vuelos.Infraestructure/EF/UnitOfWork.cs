using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Repositories;

namespace Vuelos.Infraestructure.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task Commit()
        {
            return Task.CompletedTask;
        }
    }
}
