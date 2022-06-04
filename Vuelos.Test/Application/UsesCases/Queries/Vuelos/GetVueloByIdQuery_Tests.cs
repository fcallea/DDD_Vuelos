using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById;
using Xunit;

namespace Vuelos.Test.Application.UsesCases.Queries.Vuelos
{
    public class GetVueloByIdQuery_Tests
    {
        [Fact]
        public void GetVueloByIdQuery_DataValid()
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
                    IdLugarOrigen = idLugarOrigen,
                    IdLugarDestino = idLugarDestino,
                    IdItinerario = idItinerario,
                    IdTripulacion = idTripulacion,
                    FechaHoraPartida = fechaHoraPartida,
                    FechaHoraLlegada = fechaHoraLlegada,
                    TipoVuelo = tipoVuelo,
                    MillasVuelo = millasVuelo,
                    Id = id,
                    NroVuelo = nroVuelo
                };

            var command = new GetVueloByIdQuery(id);

            Assert.Equal(id, command.Id);
        }


        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (GetVueloByIdQuery)Activator.CreateInstance(typeof(GetVueloByIdQuery), true);
            Assert.Null((object)command.Id);
        }
    }
}
