using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Infraestructure.MemoryRepository
{
    public class MemoryDatabase
    {
        private readonly List<Vuelo> _vuelos;

        public List<Vuelo> Vuelos
        {
            get { return _vuelos; }
        }

        public MemoryDatabase()
        {
            _vuelos = new List<Vuelo>();
        }

    }
}
