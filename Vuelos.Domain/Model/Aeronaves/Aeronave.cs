using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Itinerarios;

namespace Vuelos.Domain.Model.Aeronaves
{
    public class Aeronave : AggregateRoot<Guid>
    {
        public string Estado { get; private set; }
        public int NroAsientos { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public decimal CapacidadCarga { get; private set; }
        public decimal CapacidadTanque { get; private set; }

        private readonly ICollection<Itinerario> _Itinerarios;
        public IReadOnlyCollection<Itinerario> Itinerarios
        {
            get
            {
                return new ReadOnlyCollection<Itinerario>(_Itinerarios.ToList());
            }
        }

        public Aeronave(string Estado, int NroAsientos, string Marca, string Modelo, decimal CapacidadCarga, decimal CapacidadTanque)
        {
            Id = Guid.NewGuid();
            this.Estado = Estado;
            this.NroAsientos = NroAsientos;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.CapacidadCarga = CapacidadCarga;
            this.CapacidadTanque = CapacidadTanque;

            _Itinerarios = new List<Itinerario>();
        }
    }
}
