using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aereonaves;

namespace Vuelos.Domain.Model.Aereopuertos
{
    public class Aeropuerto : AggregateRoot<Guid>
    {
        public string Pais { get; private set; }
        public string Localidad { get; private set; }
        public string Nombre { get; private set; }

        private readonly ICollection<Pista> _pista;

        public IReadOnlyCollection<Pista> Pista
        {
            get
            {
                return new ReadOnlyCollection<Pista>(_pista.ToList());
            }
        }

        public Aeropuerto(string pais, string localidad, string nombre)
        {
            Id = Guid.NewGuid();
            Pais = pais;
            Localidad = localidad;
            Nombre = nombre;
            _pista = new List<Pista>();
        }
    }
}
