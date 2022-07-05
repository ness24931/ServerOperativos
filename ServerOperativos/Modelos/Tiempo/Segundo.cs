using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public class Segundo : IUnidadTiempo
    {
        public decimal ValSegundo => decimal.One;
        public decimal ValMinuto => 60m;
        public decimal ValHora => 3600m;
        public decimal ValDia => 86400m;
        public decimal ValMes => 2628000m;
    }
}
