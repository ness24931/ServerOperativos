using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Longitud
{
    public class Centimetro : IUnidadLongitud
    {
        public decimal ValCentimetro => decimal.One;

        public decimal ValKilometro => 100000m;

        public decimal ValMetro => 100m;

        public decimal ValPulgada => 2.54m;

        public decimal ValYarda => 91.44m;
    }
}
