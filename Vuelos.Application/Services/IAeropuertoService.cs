﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    internal interface IAeropuertoService
    {
        Task<string> GenerarNroVueloAsync();
    }
}