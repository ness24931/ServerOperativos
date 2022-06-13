using ServerOperativos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Modelos
{
    public class UnidadMedida
    {
        public string ValorOriginal { get; set; }
        public string ValorNuevo { get; set; }

        public Medida Medida { get; set; }

        public int Unidad { get; set; }

    }
}
