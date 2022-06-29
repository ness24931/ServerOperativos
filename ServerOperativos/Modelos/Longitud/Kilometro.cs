using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Longitud
{
    public class Kilometro : IUnidadLongitud
    {
        public decimal ValCentimetro => 100000m;

        public decimal ValKilometro => decimal.One;

        public decimal ValMetro => 1000m;

        public decimal ValPulgada => 39370m;

        public decimal ValYarda => 1094m;
    }
}
