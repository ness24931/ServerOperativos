using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Masa
{
    interface IUnidadMasa
    {
        decimal ValMiligramo { get; }
        decimal ValGramo { get; }
        decimal ValOnza { get; }
        decimal ValLibra { get; }
        decimal ValKilogramo { get; }
    }
}
