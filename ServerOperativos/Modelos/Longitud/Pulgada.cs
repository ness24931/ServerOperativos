using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Longitud
{
    public class Pulgada : IUnidadLongitud
    {
        public decimal ValCentimetro => 2.54m;

        public decimal ValKilometro => decimal.One / 39370m;

        public decimal ValMetro => decimal.One / 39.37m;

        public decimal ValPulgada => decimal.One;

        public decimal ValYarda => decimal.One / 36m;
    }
}
