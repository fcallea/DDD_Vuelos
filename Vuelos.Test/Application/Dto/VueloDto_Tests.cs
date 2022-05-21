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
            string TipoVuelo = "COMERCIAL";
            decimal MillasVuelo = new decimal(0.0);
            var Tripulantes = new TripulanteDto();
            string NroVuelo = "V01";


            var vuelo = new VueloDto();


            Assert.Equal(Guid.Empty, vuelo.IdLugarDestino);
            Assert.Equal(Guid.Empty, vuelo.IdItinerario);
            Assert.Equal(Guid.Empty, vuelo.IdTripulacion);
            Assert.Equal(DateTime.Now, vuelo.FechaHoraPartida);
            Assert.Equal(DateTime.Now, vuelo.FechaHoraLlegada);
            Assert.Equal("COMERCIAL", vuelo.TipoVuelo);
            Assert.Equal(new decimal(0.0), vuelo.MillasVuelo);
            Assert.Null(vuelo.Tripulantes);

            vuelo.IdLugarDestino = IdLugarDestino;
            vuelo.IdItinerario = IdItinerario;
            vuelo.IdTripulacion = IdTripulacion;
            vuelo.FechaHoraPartida = FechaHoraPartida; 
            vuelo.FechaHoraLlegada = FechaHoraLlegada;
            vuelo.TipoVuelo = TipoVuelo;
            vuelo.MillasVuelo = MillasVuelo;
            vuelo.NroVuelo = NroVuelo;

            Assert.Equal(IdLugarDestino, vuelo.IdLugarDestino);
            Assert.Equal(IdItinerario, vuelo.IdItinerario);
            Assert.Equal(IdTripulacion, vuelo.IdTripulacion);
            Assert.Equal(FechaHoraPartida, vuelo.FechaHoraPartida);
            Assert.Equal(FechaHoraLlegada, vuelo.FechaHoraLlegada);
            Assert.Equal(TipoVuelo, vuelo.TipoVuelo);
            Assert.Equal(MillasVuelo, vuelo.MillasVuelo);
            Assert.Equal(NroVuelo, vuelo.NroVuelo);
        }
    }
}
