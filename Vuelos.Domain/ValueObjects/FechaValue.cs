using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.ValueObjects
{
    public record FechaValue
    {
        public DateTime Value { get; }
        public FechaValue(DateTime value)
        {
            if (value < DateTime.Now)
            {
                throw new BussinessRuleValidationException("La fecha no puede ser a la anterior");
            }
            Value = value;
        }

        public static implicit operator DateTime(FechaValue value)
        {
            return value.Value;
        }

        public static implicit operator FechaValue(DateTime value)
        {
            return new FechaValue(value);
        }


    }
}
