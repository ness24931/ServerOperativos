using ServerOperativos.Enums;
using ServerOperativos.Modelos;
using ServerOperativos.Modelos.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServerOperativos.LogicaNegocio.Convertidores
{
    public class ConvertidorTemperatura : IConvertidorMedida
    {
        public decimal Convertir(RequestObj request)
        {
            return this.ConvertirUnidad((UnidadTemperatura)request.FromUnidad, (UnidadTemperatura)request.ToUnidad, request.Valor);
        }

        private decimal ConvertirUnidad(UnidadTemperatura fromUnidad, UnidadTemperatura toUnidad, decimal valor)
        {
            var modelo = this.GetUnidad(fromUnidad);
            modelo.ValPivot = valor;
            decimal? valorU = GetValorUnidad(toUnidad, modelo);            
            if (valorU.HasValue)
            {
                return valorU.Value;
            }
            return decimal.Zero;
        }

        private decimal? GetValorUnidad(UnidadTemperatura unidad, IUnidadTemperatura UnidadTemperatura)
        {
            Type tipo = UnidadTemperatura.GetType();
            PropertyInfo prop = tipo.GetProperty("Val" + unidad.ToString());
            return prop.GetValue(UnidadTemperatura) as decimal?;
        }

        private IUnidadTemperatura GetUnidad(UnidadTemperatura unidad)
        {
            string nomModelo = "ServerOperativos.Modelos.Temperatura." + unidad.ToString();
            var tipo = Type.GetType(nomModelo, true);
            var obj = Activator.CreateInstance(tipo);
            return obj as IUnidadTemperatura;
        }
    }
}
