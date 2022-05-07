using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.ReadModel
{
    public class AeronaveReadModel
    {
        public Guid Id { get; set; }
        public string Estado { get; set; }
        public int NroAsientos { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal CapacidadCarga { get; set; }
        public decimal CapacidadTanque { get; set; }
        public ICollection<ItinerarioReadModel> Itinerario { get; set; }
    }
}
