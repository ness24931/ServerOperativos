using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Temperatura
{
    public class Fahrenheit : IUnidadTemperatura
    {
        private decimal _valPivot;
        public decimal ValKelvin => (this._valPivot - 32m) * (5m / 9m) + 273.15m;//(23 °F − 32) × 5/9 + 273.15

        public decimal ValFahrenheit => decimal.One;

        public decimal ValCelsius => (this._valPivot - 32m) * (5m / 9m);//(23 °F − 32) × 5/9
        public decimal ValPivot
        {
            set
            {
                this._valPivot = value;
            }
        }
    }
}
