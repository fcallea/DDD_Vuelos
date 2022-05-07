using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Itinerarios
{
    public class Itinerario : AggregateRoot<Guid>
    {
        public Guid IdPista { get; private set; }
        public Guid IdAeronave { get; private set; }
        public string NroVuelo { get; private set; }
        public DateTime FechaHoraDesde { get; private set; }
        public DateTime FechaHoraHasta { get; private set; }

        public Itinerario(Guid IdPista, Guid IdAeronave, string NroVuelo, DateTime FechaHoraDesde, DateTime FechaHoraHasta)
        {
            Id = Guid.NewGuid();
            this.IdPista = IdPista;
            this.IdAeronave = IdAeronave;
            this.NroVuelo = NroVuelo;   
            this.FechaHoraDesde = FechaHoraDesde;
            this.FechaHoraHasta = FechaHoraHasta;
        }
    }
}

