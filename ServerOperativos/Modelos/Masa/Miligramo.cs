using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Masa
{
    public class Miligramo : IUnidadMasa
    {
        public decimal ValMiligramo => decimal.One;
        public decimal ValGramo => 1000;
        public decimal ValOnza => 28350m;
        public decimal ValLibra => 453600m;
        public decimal ValKilogramo => 1000000m;
    }
}
