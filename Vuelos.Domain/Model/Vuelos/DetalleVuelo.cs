using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos
{
    public class DetalleVuelo : Entity<Guid>
    {
        public Guid VueloId { get; private set; }
        public DestinoValue Destino { get; private set; }
        public DateTime HoraSalida { get; private set; }
        public DateTime HoraLlegada { get; private set; }
        public int TripulacionID { get; private set; }

        internal DetalleVuelo(Guid vueloId, DestinoValue destino,
            DateTime horaSalida, DateTime horaLlegada, int tripulacionID)
        {
            VueloId = Guid.NewGuid();
            Destino = destino;
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            TripulacionID = tripulacionID;
        }
    }
}
