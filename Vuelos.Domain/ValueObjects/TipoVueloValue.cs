using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.ValueObjects
{
    public record TipoVueloValue
    {
        public string Value { get; }
        public TipoVueloValue(string value)
        {            
            if (Value!="COMERCIAL")
            {
                throw new BussinessRuleValidationException("Tipo de Vuelo no Permitido");
            }
            Value = value;
        }

        public static implicit operator string(TipoVueloValue value)
        {
            return value.Value;
        }

        public static implicit operator TipoVueloValue(string value)
        {
            return new TipoVueloValue(value);
        }


    }
}
