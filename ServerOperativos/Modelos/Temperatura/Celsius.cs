using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Temperatura
{
    public class Celsius : IUnidadTemperatura
    {
        private decimal _valPivot;
        public decimal ValKelvin => this._valPivot + 273.15m;//valor + valkevin

        public decimal ValFahrenheit => (this._valPivot * (9m / 5m)) + 32m; //(23 °C × 9/5) + 32

        public decimal ValCelsius => decimal.One;
        public decimal ValPivot
        {
            set
            {
                this._valPivot = value;
            }
        }
    }
}
