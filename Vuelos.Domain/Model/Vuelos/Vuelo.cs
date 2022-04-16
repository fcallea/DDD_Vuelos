using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Vuelos.Domain.Event;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Tripulantes;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Model
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public int NroVuelo { get; private set; }
        public int CodAeronave { get; private set; }
        public DateTime Fecha { get; private set; }
        public VODestino Destino { get; private set; }
        public DateTime HoraPartida { get; private set; }
        public DateTime HoraLlegada { get; private set; }
        public int Millas { get; private set; }
        public ICollection<Tripulante> Tripulacion { get; private set; }

        public Vuelo(int nroVuelo)
        {
            Id = Guid.NewGuid();
            NroVuelo = nroVuelo;
            Tripulacion = new List<Tripulante>();
        }

        public void ConfirmarVuelo()
        {
            var evento = new CrearVuelo(Id, NroVuelo);
            AddDomainEvent(evento);
        }
    }
}
