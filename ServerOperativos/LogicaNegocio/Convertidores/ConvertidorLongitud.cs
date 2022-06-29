using ServerOperativos.Enums;
using ServerOperativos.Modelos;
using ServerOperativos.Modelos.Longitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServerOperativos.LogicaNegocio.Convertidores
{
    public class ConvertidorLongitud : IConvertidorMedida
    {
        public decimal Convertir(RequestObj request)
        {
            return this.ConvertirUnidad((UnidadLongitud)request.FromUnidad, (UnidadLongitud)request.ToUnidad, request.Valor);
        }

        private decimal ConvertirUnidad(UnidadLongitud fromUnidad, UnidadLongitud toUnidad, decimal valor)
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

        private decimal? GetValorUnidad(UnidadLongitud unidad, IUnidadLongitud UnidadLongitud)
        {
            Type tipo = UnidadLongitud.GetType();
            PropertyInfo prop = tipo.GetProperty("Val" + unidad.ToString());
            return prop.GetValue(UnidadLongitud) as decimal?;
        }

        private IUnidadLongitud GetUnidad(UnidadLongitud unidad)
        {
            string nomModelo = "ServerOperativos.Modelos.Longitud." + unidad.ToString();
            var tipo = Type.GetType(nomModelo, true);
            var obj = Activator.CreateInstance(tipo);
            return obj as IUnidadLongitud;
        }
    }
}
