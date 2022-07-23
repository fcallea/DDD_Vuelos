using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Infraestructure.EF.ReadModel {
    public class VueloReadModel {
        public Guid IdVuelo { get; set; }
        public Guid IdLugarOrigen { get; set; }
        public LugarReadModel LugarDestino { get; set; }
        //public Guid IdLugarDestino { get; set; }
        public ItinerarioReadModel Itinerario { get; set; }
        //public Guid IdItinerario { get; set; }
        public FechaValue FechaHoraPartida { get; set; }
        public FechaValue FechaHoraLlegada { get; set; }
        public string TipoVuelo { get; set; }
        public decimal MillasVuelo { get; set; }
        public decimal TiempoVuelo { get; set; }
        public int StockAsientos { get; set; }
    }
}
