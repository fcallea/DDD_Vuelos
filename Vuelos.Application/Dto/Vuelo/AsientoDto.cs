using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Vuelo
{
    public class AsientoDto
    {
        public Guid VueloId { get; set; }   
        public int Fila { get; set; }
        public int Columna { get; set; }
        public string Tipo { get; set; }
        public bool EsDisponible { get; set; }
    }
}
