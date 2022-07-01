using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Masa
{
    public class Gramo : IUnidadMasa
    {
        public decimal ValMiligramo => 1000m;
        public decimal ValGramo => decimal.One;
        public decimal ValOnza => 28.35m;
        public decimal ValLibra => 453.6m;
        public decimal ValKilogramo => 1000m;
    }
}
