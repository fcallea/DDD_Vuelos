using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Tripulaciones
{
    public class Tripulacion : AggregateRoot<Guid>
    {
        public Guid TripulacionId { get; private set; }
        private readonly ICollection<Tripulacion> _Tripulantes;
        public IReadOnlyCollection<Tripulacion> Tripulantes
        {
            get
            {
                return new ReadOnlyCollection<Tripulacion>(_Tripulantes.ToList());
            }
        }

        public Tripulacion()
        {
            _Tripulantes = new List<Tripulacion>();
        }
    }
}
