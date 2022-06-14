using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public class Mes : IUnidadTiempo
    {
        public decimal ValSegundo => 2629800m;
        public decimal ValMinuto => 43830m;
        public decimal ValHora => 730.5m;
        public decimal ValDia => 30m;
        public decimal ValMes => decimal.One;
    }
}
