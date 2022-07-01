using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Masa
{
    public class Kilogramo :IUnidadMasa
    {
        public decimal ValMiligramo => 1000000m;
        public decimal ValGramo => 1000;
        public decimal ValOnza => 35.274m;
        public decimal ValLibra => 2.205m;
        public decimal ValKilogramo => decimal.One;
    }
}
