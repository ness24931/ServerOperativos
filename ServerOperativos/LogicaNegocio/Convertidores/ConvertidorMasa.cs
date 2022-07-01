using ServerOperativos.Enums;
using ServerOperativos.Modelos;
using ServerOperativos.Modelos.Masa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServerOperativos.LogicaNegocio.Convertidores
{
    public class ConvertidorMasa : IConvertidorMedida
    {
        public decimal Convertir(RequestObj request)
        {
            return this.ConvertirUnidad((UnidadMasa)request.FromUnidad, (UnidadMasa)request.ToUnidad, request.Valor);
        }

        private decimal ConvertirUnidad(UnidadMasa fromUnidad, UnidadMasa toUnidad, decimal valor)
        {
            var modelo = this.GetUnidad(fromUnidad);
            decimal? valorU = GetValorUnidad(toUnidad, modelo);
            decimal result = decimal.Zero;
            if (valorU.HasValue)
            {
                if (fromUnidad < toUnidad)
                {
                    result = valor / valorU.Value;
                }
                else
                {
                    result = valor * valorU.Value;
                }
            }
            return result;
        }

        private decimal? GetValorUnidad(UnidadMasa unidad, IUnidadMasa UnidadMasa)
        {
            Type tipo = UnidadMasa.GetType();
            PropertyInfo prop = tipo.GetProperty("Val" + unidad.ToString());
            return prop.GetValue(UnidadMasa) as decimal?;
        }

        private IUnidadMasa GetUnidad(UnidadMasa unidad)
        {
            string nomModelo = "ServerOperativos.Modelos.Masa." + unidad.ToString();
            var tipo = Type.GetType(nomModelo, true);
            var obj = Activator.CreateInstance(tipo);
            return obj as IUnidadMasa;
        }
    }
}
