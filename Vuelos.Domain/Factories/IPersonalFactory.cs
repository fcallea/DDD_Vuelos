using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Personales;

namespace Vuelos.Domain.Factories
{
    public interface IPersonalFactory
    {
        Personal Create(string Usuario);
    }
}
