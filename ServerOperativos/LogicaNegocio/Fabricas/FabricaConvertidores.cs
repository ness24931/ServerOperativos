using ServerOperativos.Enums;
using ServerOperativos.LogicaNegocio.Convertidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.LogicaNegocio.Fabricas
{
    public class FabricaConvertidores
    {
        public static IConvertidorMedida GetConvertidor(Medida medida)
        {
            switch (medida)
            {
                case Medida.Longitud:
                    return new ConvertidorLongitud();
                case Medida.Tiempo:
                    return new ConvertidorTiempo();
                case Medida.DatosInformacion:
                    return new ConvertidorDatosInformacion();
                case Medida.Masa:
                    return new ConvertidorMasa();
                case Medida.Temperatura:
                    return new ConvertidorTemperatura();
                default:
                    return null;
            }            
        }
    }
}
