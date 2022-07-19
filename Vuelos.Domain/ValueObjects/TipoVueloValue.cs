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
            /*
            if (Value!="COMERCIAL")
            {
                String msg = (String)"Tipo de Vuelo no Permitido";
                throw new BussinessRuleValidationException(msg);
            }
            */
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
