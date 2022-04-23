using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Personales
{
    public class Personal : AggregateRoot<Guid>   
    {
        public string Usuario { get; private set; }
        public Personal(string usuario)
        {
            Id = Guid.NewGuid();
            Usuario = usuario;
        }
    }
}
