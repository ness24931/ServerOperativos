using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Longitud
{
    public class Yarda : IUnidadLongitud
    {
        public decimal ValCentimetro => 91.44m;

        public decimal ValKilometro => decimal.One / 1094m;

        public decimal ValMetro => decimal.One / 1.094m;

        public decimal ValPulgada => 36m;

        public decimal ValYarda => decimal.One;
    }
}
