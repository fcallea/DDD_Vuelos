using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Xunit;

namespace Vuelos.Test.Application.Dto
{
    public class VueloDto_Tests
    {
        [Fact]
        public void VueloDto_CheckPropertiesValid()
        {
            var IdLugarDestino = Guid.NewGuid();
            var IdItinerario = Guid.NewGuid();
            var IdTripulacion = Guid.NewGuid();
            DateTime FechaHoraPartida = DateTime.Now;
            DateTime FechaHoraLlegada = DateTime.Now;
            String TipoVuelo = "COMERCIAL";
            decimal MillasVuelo = new decimal(0.0);
            int nroVuelo = 123;

            var vuelo = new VueloDto();


            Assert.Equal(Guid.Empty, vuelo.IdLugarDestino);
            Assert.Equal(Guid.Empty, vuelo.IdItinerario);
            Assert.Equal(Guid.Empty, vuelo.IdTripulacion);
            Assert.NotNull((object)vuelo.FechaHoraPartida);
            Assert.NotNull((object)vuelo.FechaHoraLlegada);
            Assert.Null(vuelo.TipoVuelo);
            Assert.Equal(new decimal(0.0), vuelo.MillasVuelo);
            Assert.NotNull(vuelo.Tripulantes);

            vuelo.IdLugarDestino = IdLugarDestino;
            vuelo.IdItinerario = IdItinerario;
            vuelo.IdTripulacion = IdTripulacion;
            vuelo.FechaHoraPartida = FechaHoraPartida; 
            vuelo.FechaHoraLlegada = FechaHoraLlegada;
            vuelo.TipoVuelo = TipoVuelo;
            vuelo.MillasVuelo = MillasVuelo;
            vuelo.NroVuelo = nroVuelo;

            Assert.Equal(IdLugarDestino, vuelo.IdLugarDestino);
            Assert.Equal(IdItinerario, vuelo.IdItinerario);
            Assert.Equal(IdTripulacion, vuelo.IdTripulacion);
            Assert.NotNull((object)FechaHoraPartida);
            Assert.NotNull((object)FechaHoraLlegada);
            Assert.Equal(TipoVuelo, vuelo.TipoVuelo);
            Assert.Equal(MillasVuelo, vuelo.MillasVuelo);
            Assert.NotNull((object)vuelo.Id);
            Assert.Equal(nroVuelo,vuelo.NroVuelo);
        }
    }
}
