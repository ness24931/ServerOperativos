using ServerOperativos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.LogicaNegocio
{
    public interface IConvertidorMedida
    {
        decimal Convertir(RequestObj request);
    }
}
