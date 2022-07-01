using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Masa
{
    public class Onza : IUnidadMasa
    {
        public decimal ValMiligramo => 28350m;
        public decimal ValGramo => 28.35m;
        public decimal ValOnza => decimal.One;
        public decimal ValLibra => 16m;
        public decimal ValKilogramo => 35.274m;
    }
}
