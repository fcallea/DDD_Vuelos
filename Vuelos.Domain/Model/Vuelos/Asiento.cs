using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos
{
    public class Asiento : Entity<Guid>
    {
        public int Fila { get; private set; }
        public int Columna { get; private set; }
        public string Tipo { get; private set; }
        public bool EsDisponible { get; private set; }

        internal Asiento(int Fila, int Columna, string Tipo, bool EsDisponible)
        {
            Id = Guid.NewGuid();
            this.Fila = Fila;
            this.Columna = Columna;
            this.Tipo = Tipo;
            this.EsDisponible = EsDisponible;
        }
    }
}
