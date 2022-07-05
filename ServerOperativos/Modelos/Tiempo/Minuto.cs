using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public class Minuto : IUnidadTiempo
    {
        public decimal ValSegundo => 60m;
        public decimal ValMinuto => decimal.One;
        public decimal ValHora => 60m;
        public decimal ValDia => 1440m;
        public decimal ValMes => 43800m;
    }
}
