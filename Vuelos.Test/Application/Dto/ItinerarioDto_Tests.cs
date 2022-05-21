﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Xunit;

namespace Vuelos.Test.Application.Dto
{
    public class ItinerarioDto_Tests
    {
        public Guid IdPista { get; set; }
        public Guid IdAeronave { get; set; }
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }

        [Fact]
        public void ItinerarioDto_CheckPropertiesValid()
        {
            var IdPista = Guid.NewGuid();
            var IdAeronave = Guid.NewGuid();
            DateTime FechaHoraDesde = DateTime.Now;
            DateTime FechaHoraHasta = DateTime.Now;

            var itinerario = new ItinerarioDto();

            Assert.Equal(Guid.Empty, itinerario.IdPista);
            Assert.Equal(Guid.Empty, itinerario.IdAeronave);
            Assert.Equal(DateTime.Now, itinerario.FechaHoraDesde);
            Assert.Equal(DateTime.Now, itinerario.FechaHoraDesde);

            itinerario.IdPista = IdPista;
            itinerario.IdAeronave = IdAeronave;
            itinerario.FechaHoraDesde = FechaHoraDesde;
            itinerario.FechaHoraHasta = FechaHoraHasta;

            Assert.Equal(IdPista, itinerario.IdPista);
            Assert.Equal(IdAeronave, itinerario.IdAeronave);
            Assert.Equal(FechaHoraDesde, itinerario.FechaHoraDesde);
            Assert.Equal(FechaHoraDesde, itinerario.FechaHoraDesde);

        }
    }
}