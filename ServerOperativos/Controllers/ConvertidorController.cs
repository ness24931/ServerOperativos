using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ServerOperativos.Enums;
using ServerOperativos.LogicaNegocio;
using ServerOperativos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerOperativos.Controllers
{
    [EnableCors("AllowClient")]
    [Route("api/[controller]")]    
    [ApiController]    
    public class ConvertidorController : ControllerBase
    {
        // GET: api/<ConvertidorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
            Convertidor convertidor = new Convertidor();
            var res = convertidor.Convertir(value);
            return Decimal.Round(res, 5);
        }

        // PUT api/<ConvertidorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConvertidorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
