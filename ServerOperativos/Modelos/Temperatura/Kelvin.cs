using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Temperatura
{
    public class Kelvin : IUnidadTemperatura
    {
        private decimal _valPivot;
        public decimal ValKelvin => decimal.One;

        public decimal ValFahrenheit => (this._valPivot - 273.15m) * 9m / 5m + 32m;//(23 K − 273.15) × 9/5 + 32;

        public decimal ValCelsius => this._valPivot - 273.15m; //23 K − 273.15
        public decimal ValPivot
        {
            set
            {
                this._valPivot = value;
            }
        }
    }
}
