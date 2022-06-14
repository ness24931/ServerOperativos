using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos.Tiempo
{
    public class Hora : IUnidadTiempo
    {
        public decimal ValSegundo => 3600m;
        public decimal ValMinuto => 60m;
        public decimal ValHora => 1m;
        public decimal ValDia => 1m / 24m;
        public decimal ValMes => 1m / 730m;
    }
}
