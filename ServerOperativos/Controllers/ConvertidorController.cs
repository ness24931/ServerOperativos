using Microsoft.AspNetCore.Mvc;
using ServerOperativos.LogicaNegocio;
using ServerOperativos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerOperativos.Controllers
{
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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConvertidorController>
        [HttpPost]
        public decimal Post([FromBody] RequestObj value)
        {
            Convertidor convertidor = new Convertidor();
            var res = convertidor.Convertir(value);
            return res;
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
