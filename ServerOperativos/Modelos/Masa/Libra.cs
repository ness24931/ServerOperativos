using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Masa
{
    public class Libra : IUnidadMasa
    {
        public decimal ValMiligramo => 453600m;
        public decimal ValGramo => 453.6m;
        public decimal ValOnza => 16m;
        public decimal ValLibra => decimal.One;
        public decimal ValKilogramo => 2.205m;
    }
}
