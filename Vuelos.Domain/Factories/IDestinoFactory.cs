using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Destinos;

namespace Vuelos.Domain.Factories
{
    public interface IDestinoFactory
    {
        Destino Create(Guid AereopuertoIdOrigen, Guid AereopuertoIdDestino, decimal DistanciaMillas, TimeSpan TiempoMinutos);
    }
}
