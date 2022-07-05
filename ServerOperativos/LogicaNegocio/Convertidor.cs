using ServerOperativos.LogicaNegocio.Fabricas;
using ServerOperativos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace ServerOperativos.LogicaNegocio
{
    public class Convertidor
    {
        public decimal Convertir(RequestObj request)
        {
            var convertidor = FabricaConvertidores.GetConvertidor(request.Medida);
            return convertidor.Convertir(request);
        }
    }
}
