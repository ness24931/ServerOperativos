using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Longitud
{
    interface IUnidadLongitud
    {
        decimal ValCentimetro { get; }
        decimal ValKilometro { get; }
        decimal ValMetro { get; }
        decimal ValPulgada { get; }
        decimal ValYarda { get; }
    }
}
