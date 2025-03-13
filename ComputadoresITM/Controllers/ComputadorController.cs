using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ComputadoresITM.Clases;
using ComputadoresITM.Models;

namespace ComputadoresITM.Controllers
{    [RoutePrefix("api/Computadores")]
    public class ComputadoresController : ApiController
    {

        [HttpGet]
        [Route("Consultar")]
        public Computador Consultar(int id)
        {
            claseComputador computador = new claseComputador();
            return computador.Consultar(id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Computador> ConsultarTodos()
        {
            claseComputador computador = new claseComputador();
            return computador.ConsultarTodos();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Computador computador)
        {
            claseComputador Computador = new claseComputador();
            Computador.computador = computador;
            return Computador.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Computador computador)
        {
            claseComputador Computador = new claseComputador();
            Computador.computador = computador;
            return Computador.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            claseComputador computador = new claseComputador();
            return computador.Eliminar(id);
        }

        [HttpGet]
        [Route("ConsultarPorMarcaProcesador")]
        public List<Computador> ConsultarPorMarcaProcesador(string marcaProcesador)
        {
            claseComputador computador = new claseComputador();
            return computador.ConsultarPorMarcaProcesador(marcaProcesador);
        }

        [HttpGet]
        [Route("ConsultarPorNumeroDeProcesadores")]
        public List<Computador> ConsultarPorNumeroDeProcesadores(short numeroDeProcesadores)
        {
            claseComputador computador = new claseComputador();
            return computador.ConsultarPorNumeroDeProcesadores(numeroDeProcesadores);
        }
    }
}