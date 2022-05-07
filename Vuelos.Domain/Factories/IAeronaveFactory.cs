﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;

namespace Vuelos.Domain.Factories
{
    public interface IAeronaveFactory
    {
        Aeronave Create(string Estado, int NroAsientos, string Marca, string Modelo, decimal CapacidadCarga, decimal CapacidadTanque);
    }
}
