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

            //if (fromUnidad < toUnidad)
            //{
            //    decimal pivot = (((int)toUnidad + 1) * 60);
            //    return valor / pivot;
            //}
            //if (toUnidad < fromUnidad)
            //{
            //    int pivot = (((int)toUnidad + 1) * 60);
            //    return valor * pivot;
            //}
            //return decimal.One;
        }
        private decimal? GetValorUnidad(UnidadTiempo unidad, IUnidadTiempo unidadTiempo)
        {
            Type tipo = unidadTiempo.GetType();
            PropertyInfo prop = tipo.GetProperty("Val" + unidad.ToString());
            return prop.GetValue(unidadTiempo) as decimal?;
            //MethodInfo method = tipo.GetMethod("Val" + unidad.ToString());
            //return method.Invoke(unidadTiempo, null) as decimal?;


            //switch (unidad)
            //{
            //    case UnidadTiempo.Segundo:
            //        return MethodInfo.Invoke()
            //    case UnidadTiempo.Minuto:
            //        break;
            //    case UnidadTiempo.Hora:
            //        break;
            //    case UnidadTiempo.Dia:
            //        break;
            //    case UnidadTiempo.Mes:
            //        break;
            //    default:
            //        break;
            //}
        }

        private IUnidadTiempo GetUnidad(UnidadTiempo unidad)
        {
            string nomModelo = "ServerOperativos.Modelos.Tiempo." + unidad.ToString();            
            var tipo = Type.GetType(nomModelo,true);
            var obj = Activator.CreateInstance(tipo);
            return obj as IUnidadTiempo;

            //switch (unidad)
            //{
            //    case UnidadTiempo.Segundo:
            //        return new Segundos();
            //    case UnidadTiempo.Minuto:
            //        return new Segundos();
            //    case UnidadTiempo.Hora:
            //        break;
            //    case UnidadTiempo.Dia:
            //        break;
            //    case UnidadTiempo.Mes:
            //        break;
            //    default:
            //        return null;
            //}
        }
    }
}
