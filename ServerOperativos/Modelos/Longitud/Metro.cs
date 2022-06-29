using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Longitud
{
    public class Metro : IUnidadLongitud
    {
        public decimal ValCentimetro => 100m;

        public decimal ValKilometro => 1000m;

        public decimal ValMetro => decimal.One;

        public decimal ValPulgada => 39.37m;

        public decimal ValYarda => 1.094m;
    }
}
