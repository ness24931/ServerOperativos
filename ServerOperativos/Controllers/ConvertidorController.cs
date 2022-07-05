using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerOperativos.Enums;
using ServerOperativos.LogicaNegocio;
using ServerOperativos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServerOperativos.Controllers
{
    [EnableCors("AllowClient")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertidorController : ControllerBase
    {
        private int id;
        private readonly IWebHostEnvironment _env;

        public ConvertidorController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET api/<ConvertidorController>/5
        [HttpGet("{id}")]
        public string[] Get(Medida id)
        {
            switch (id)
            {
                case Medida.Longitud:
                    return Enum.GetNames(typeof(UnidadLongitud)).ToArray();
                case Medida.Masa:
                    return Enum.GetNames(typeof(UnidadMasa)).ToArray();
                case Medida.Temperatura:
                    return Enum.GetNames(typeof(UnidadTemperatura)).ToArray();
                case Medida.Tiempo:
                    return Enum.GetNames(typeof(UnidadTiempo)).ToArray();
            }
            return null;
        }

        // POST api/<ConvertidorController>
        [HttpPost]
        public decimal Post([FromBody] RequestObj value)
        {
            var res = Task.Run(() => ProcessRequest(value));
            return res.Result;
        }

        private decimal ProcessRequest(RequestObj value)
        {
            Convertidor convertidor = new Convertidor();
            var res = convertidor.Convertir(value);
            EscribirLog(++this.id, value.FromUnidad.ToString(), value.ToUnidad.ToString());
            return Decimal.Round(res, 5);
        }

        private void EscribirLog(int id, string uniFrom, string uniTo)
        {
            StreamWriter fileObj = new StreamWriter(Path.Combine(_env.ContentRootPath, "Logs", "Log.txt"), true);
            lock (fileObj)
            {                
                fileObj.WriteLine($"id = {AppDomain.GetCurrentThreadId()}, fromValue = {uniFrom}, toValue = {uniTo}");
                fileObj.Close();
            }
        }
    }
}
