using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.ReadModel {
    public class PistaReadModel {
        public Guid IdPista { get; set; }
        public AeropuertoReadModel Aeropuerto { get; set; }
        //public Guid IdAeropuerto { get; set; }
        public ICollection<ItinerarioReadModel> Itinerario { get; set; }
    }
}
