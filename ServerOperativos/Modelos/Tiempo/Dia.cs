using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public class Dia : IUnidadTiempo
    {
        public decimal ValSegundo => 86400m;
        public decimal ValMinuto => 1440m;
        public decimal ValHora => 24m;
        public decimal ValDia => 1m;
        public decimal ValMes => 1m / 30m;
    }
}
