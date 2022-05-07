using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Aeropuertos;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Model.Lugares;
using Vuelos.Domain.Model.Tripulaciones;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Infraestructure.EF.Config.WriteConfig
{
    public class VueloWriteConfig :
          IEntityTypeConfiguration<Aeropuerto>
        , IEntityTypeConfiguration<Pista>
        , IEntityTypeConfiguration<Aeronave>
        , IEntityTypeConfiguration<Itinerario>
        , IEntityTypeConfiguration<Vuelo>
        , IEntityTypeConfiguration<Lugar>
    {

        public void Configure(EntityTypeBuilder<Aeropuerto> builder)
        {
            builder.ToTable("Aeropuerto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdLugar)
            .HasMaxLength(500)
            .HasColumnName("idLugar");

            builder.Property(x => x.SecuencialVuelo)
            .HasColumnName("secuencialVuelo");

            builder.Property(x => x.Nombre)
            .HasMaxLength(500)
            .HasColumnName("nombre");

            builder.HasMany(typeof(Pista), "_pistas");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Pistas);

        }

        public void Configure(EntityTypeBuilder<Pista> builder)
        {
            builder.ToTable("Pista");
            builder.HasKey(x => x.Id);

            builder.HasMany(typeof(Itinerario), "_Itinerarios");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Itinerarios);
        }

        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");

            builder.Property(x => x.NroAsientos)
                .HasColumnName("nroAsientos");

            builder.Property(x => x.Marca)
               .HasMaxLength(20)
               .HasColumnName("marca");

            builder.Property(x => x.Modelo)
               .HasMaxLength(20)
               .HasColumnName("modelo");

            builder.Property(x => x.CapacidadCarga)
                .HasColumnName("capacidadCarga")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.CapacidadTanque)
                .HasColumnName("capacidadTanque")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.HasMany(typeof(Itinerario), "_Itinerarios");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Itinerarios);
        }


        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.ToTable("Itinerario");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdPista)
                .HasMaxLength(500)
                .HasColumnName("idPista");

            builder.Property(x => x.IdAeronave)
                .HasMaxLength(500)
                .HasColumnName("idAeronave");

            builder.Property(x => x.NroVuelo)
                .HasMaxLength(20)
                .HasColumnName("nroVuelo");

            builder.Property(x => x.FechaHoraDesde)
                .HasColumnName("fechaHoraDesde")
                .HasColumnType("datetime");

            builder.Property(x => x.FechaHoraHasta)
                .HasColumnName("fechaHoraHasta")
                .HasColumnType("datetime");

            builder.Ignore(x => x.DomainEvents);
        }

        public void Configure(EntityTypeBuilder<Vuelo> builder)
        {
            builder.ToTable("Vuelo");
            builder.HasKey(x => x.Id);

            /*
            var nroPedidoConverter = new ValueConverter<NumeroPedido, string>(
                nroPedidoValue => nroPedidoValue.Value,
                nroPedido => new NumeroPedido(nroPedido)
            );

            builder.Property(x => x.NroPedido)
                .HasConversion(nroPedidoConverter)
                .HasColumnName("nroPedido")
                .HasMaxLength(6);
            */

            builder.Property(x => x.IdLugarOrigen)
                .HasMaxLength(500)
                .HasColumnName("idLugarOrigen");

            builder.Property(x => x.IdLugarDestino)
                .HasMaxLength(500)
                .HasColumnName("idLugarDestino");

            builder.Property(x => x.IdItinerario)
                .HasMaxLength(500)
                .HasColumnName("idItinerario");

            builder.Property(x => x.FechaHoraPartida)
                .HasColumnName("fechaHoraPartida")
                .HasColumnType("datetime");

            builder.Property(x => x.FechaHoraLlegada)
                .HasColumnName("fechaHoraLlegada")
                .HasColumnType("datetime");

            builder.Property(x => x.TipoVuelo)
               .HasMaxLength(20)
               .HasColumnName("tipoVuelo");

            builder.Property(x => x.MillasVuelo)
                .HasColumnName("millasVuelo")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.TiempoVuelo)
                .HasColumnName("tiempoVuelo")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.StockAsientos)
                .HasColumnName("stockAsientos");

            builder.HasMany(typeof(Tripulacion), "_Tripulacion");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Tripulantes);
        }

        public void Configure(EntityTypeBuilder<Lugar> builder)
        {
            builder.ToTable("Lugar");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdLocalidad)
               .HasMaxLength(500)
               .HasColumnName("idLocalidad");

            builder.HasMany(typeof(Aeropuerto), "_Aeropuertos");
            builder.HasMany(typeof(Vuelo), "_Vuelos");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Aeropuertos);
            builder.Ignore(x => x.Vuelos);
        }
        /*
        public void Configure(EntityTypeBuilder<Tripulacion> builder)
        {
            builder.ToTable("Tripulacion");
            builder.HasKey(x => x.Id);
        }
        */
    }
}