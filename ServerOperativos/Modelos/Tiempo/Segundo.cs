using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public class Segundo : IUnidadTiempo
    {
        public decimal ValSegundo => decimal.One;
        public decimal ValMinuto => 1m / 60m;
        public decimal ValHora => 1m / 3600m;
        public decimal ValDia => 1m / 86400m;
        public decimal ValMes => 0.0380257m;
    }
}
