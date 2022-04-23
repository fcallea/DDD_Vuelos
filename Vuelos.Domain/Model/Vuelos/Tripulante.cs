using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos
{
    public class Tripulante: Entity<Guid>
    {
        public string Usuario { get; private set; }
        public string Cargo { get; private set; }

        internal Tripulante(string Usuario, string Cargo )
        {
            Id = Guid.NewGuid();
            this.Usuario = Usuario;
            this.Cargo = Cargo;
        }
    }
}
