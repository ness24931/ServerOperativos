using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Temperatura
{
    public interface IUnidadTemperatura
    {
        decimal ValKelvin { get; }
        decimal ValFahrenheit { get; }
        decimal ValCelsius { get; }
        decimal ValPivot { set; }
    }
}
