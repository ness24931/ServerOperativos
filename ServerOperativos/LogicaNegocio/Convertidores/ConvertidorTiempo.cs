using ServerOperativos.Enums;
using ServerOperativos.Modelos;
using ServerOperativos.Modelos.Tiempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServerOperativos.LogicaNegocio.Convertidores
{
    public class ConvertidorTiempo : IConvertidorMedida
    {
        public decimal Convertir(RequestObj request)
        {
            return this.ConvertirUnidad((UnidadTiempo)request.FromUnidad, (UnidadTiempo)request.ToUnidad, request.Valor);
        }

        private decimal ConvertirUnidad(UnidadTiempo fromUnidad, UnidadTiempo toUnidad, decimal valor)
        {
            var modelo = this.GetUnidad(fromUnidad);
            decimal? valorU = GetValorUnidad(toUnidad, modelo);
            if (valorU.HasValue)
            {
                return valorU.Value;
            }
            return decimal.Zero;
        }

        private decimal? GetValorUnidad(UnidadTiempo unidad, IUnidadTiempo unidadTiempo)
        {
            Type tipo = unidadTiempo.GetType();
            PropertyInfo prop = tipo.GetProperty("Val" + unidad.ToString());
            return prop.GetValue(unidadTiempo) as decimal?;
        }

        private IUnidadTiempo GetUnidad(UnidadTiempo unidad)
        {
            string nomModelo = "ServerOperativos.Modelos.Tiempo." + unidad.ToString();
            var tipo = Type.GetType(nomModelo, true);
            var obj = Activator.CreateInstance(tipo);
            return obj as IUnidadTiempo;
        }
    }
}
