using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Infraestructure.EF.ReadModel;

namespace Vuelos.Infraestructure.EF.Config.ReadConfig
{
    public class VueloReadConfig :
          IEntityTypeConfiguration<ItinerarioReadModel>
    //, IEntityTypeConfiguration<AeropuertoReadModel>
    //, IEntityTypeConfiguration<PistaReadModel>
    //, IEntityTypeConfiguration<AeronaveReadModel>
    //, IEntityTypeConfiguration<LugarReadModel>
    //, IEntityTypeConfiguration<VueloReadModel>
    {

        /*
        public void Configure(EntityTypeBuilder<AeropuertoReadModel> builder)
        {
            builder.ToTable("Aeropuerto");
            builder.HasKey(x => x.IdAeropuerto);

            builder.Property(x => x.SecuencialVuelo)
            .HasColumnName("secuencialVuelo");

            builder.Property(x => x.Nombre)
            .HasMaxLength(500)
            .HasColumnName("nombre");

            builder.HasMany(x => x.Pista)
                .WithOne(x => x.Aeropuerto);
        }
        public void Configure(EntityTypeBuilder<PistaReadModel> builder)
        {
            builder.ToTable("Pista");
            builder.HasKey(x => x.IdPista);

            builder.HasMany(x => x.Itinerario)
                .WithOne(x => x.Pista);
        }

        public void Configure(EntityTypeBuilder<AeronaveReadModel> builder)
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

            builder.HasMany(x => x.Itinerario)
                .WithOne(x => x.Aeronave);
        }
        */

        public void Configure(EntityTypeBuilder<ItinerarioReadModel> builder)
        {
            builder.ToTable("Itinerario");
            builder.HasKey(x => x.IdItinerario);

            builder.Property(x => x.NroVuelo)
                .HasColumnName("nroVuelo");
            /*
            builder.Property(x => x.FechaHoraDesde)
                .HasColumnName("fechaHoraDesde")    
                .HasColumnType("datetime");

            builder.Property(x => x.FechaHoraHasta)
                .HasColumnName("fechaHoraHasta")
                .HasColumnType("datetime");
            */

            //builder.HasOne(s => s.Vuelo)
            //.WithOne(x => x.Itinerario);

            /*
            builder.Property(x => x.FechaHoraHasta)
            .HasColumnName("fechaHoraHasta")
            .HasColumnType("datetime");
                        
            .HasForeignKey<BlogImage>(b => b.BlogForeignKey);
            */
        }

        /*
        public void Configure(EntityTypeBuilder<VueloReadModel> builder)
        {
            builder.ToTable("Vuelo");
            builder.HasKey(x => x.IdVuelo);

            builder.Property(x => x.IdLugarOrigen)
                .HasMaxLength(500)
                .HasColumnName("idLugarOrigen");

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
        }

        public void Configure(EntityTypeBuilder<LugarReadModel> builder)
        {
            builder.ToTable("Lugar");
            builder.HasKey(x => x.IdLugar);

            builder.Property(x => x.IdLocalidad)
               .HasMaxLength(500)
               .HasColumnName("idLocalidad");

            builder.HasMany(x => x.LugarAeropuerto)
                .WithOne(x => x.Lugar);

            builder.HasMany(x => x.LugarVuelo)
                .WithOne(x => x.LugarDestino);
        }
        */
    }
}
