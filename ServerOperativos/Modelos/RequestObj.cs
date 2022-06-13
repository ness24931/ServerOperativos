using ServerOperativos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos
{
    public class RequestObj
    {
        public int Valor { get; set; }
        public Medida Medida { get; set; }
        public int Unidad { get; set; }
    }
}
