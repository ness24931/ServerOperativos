using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public interface IUnidadTiempo
    {
        decimal ValSegundo { get; }
        decimal ValMinuto { get; }
        decimal ValHora { get; }
        decimal ValDia { get; }
        decimal ValMes { get; }
    }
}
