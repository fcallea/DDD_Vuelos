using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Application.UseCases.Command.Vuelos.CrearVuelo;
using Xunit;

namespace Vuelos.Test.Application.UsesCases.Command.Vuelos.CrearVuelo
{
    public class CrearVueloCommand_Test
    {
        [Fact]
        public void CrearVueloCommand_DataValid()
        {
            Guid idLugarOrigen = Guid.NewGuid();    
            Guid idLugarDestino = Guid.NewGuid(); 
            Guid idItinerario = Guid.NewGuid();
            Guid idTripulacion = Guid.NewGuid();    
            DateTime fechaHoraPartida = DateTime.Now;
            DateTime fechaHoraLlegada = DateTime.Now;
            String tipoVuelo = (String)"COMERCIAL";
            decimal millasVuelo = new decimal(20.1);
            Guid id = Guid.NewGuid();
            int nroVuelo = 123;
            VueloDto vuelo =
                new()
                {
                    IdLugarOrigen    = idLugarOrigen
                    ,IdLugarDestino   = idLugarDestino
                    ,IdItinerario     = idItinerario
                    ,IdTripulacion    = idTripulacion
                    ,FechaHoraPartida = fechaHoraPartida
                    ,FechaHoraLlegada = fechaHoraLlegada
                    ,TipoVuelo        = tipoVuelo
                    ,MillasVuelo      = millasVuelo
                    ,Id               = id
                    ,NroVuelo         = nroVuelo
                };

            var command = new CrearVueloCommand(vuelo);

            Assert.Equal(idLugarOrigen, command.Vuelo.IdLugarOrigen);
            Assert.Equal(idLugarDestino, command.Vuelo.IdLugarDestino);
            Assert.Equal(idItinerario, command.Vuelo.IdItinerario);
            Assert.Equal(idTripulacion, command.Vuelo.IdTripulacion);
            Assert.Equal(fechaHoraPartida, command.Vuelo.FechaHoraPartida);
            Assert.Equal(fechaHoraLlegada, command.Vuelo.FechaHoraLlegada);
            Assert.Equal(tipoVuelo, command.Vuelo.TipoVuelo);
            Assert.Equal(millasVuelo, command.Vuelo.MillasVuelo);
            Assert.Equal(id, command.Vuelo.Id);
            Assert.Equal(nroVuelo, command.Vuelo.NroVuelo);

        }


        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (CrearVueloCommand)Activator.CreateInstance(typeof(CrearVueloCommand), true);
            Assert.Null(command.Vuelo);
        }
    }
}
