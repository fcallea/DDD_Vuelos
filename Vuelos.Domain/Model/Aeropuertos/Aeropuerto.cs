using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Aeropuertos {
    public class Aeropuerto : AggregateRoot<Guid> {
        public Guid IdLugar { get; private set; }
        public int SecuencialVuelo { get; private set; }
        public string Nombre { get; private set; }

        private readonly ICollection<Pista> _pistas;
        public IReadOnlyCollection<Pista> Pistas {
            get {
                return new ReadOnlyCollection<Pista>(_pistas.ToList());
            }
        }

        public Aeropuerto(Guid IdLugar, string Nombre) {
            Id = Guid.NewGuid();
            this.IdLugar = IdLugar;
            this.Nombre = Nombre;
            this.SecuencialVuelo = 1;
            _pistas = new List<Pista>();
        }
    }
}
