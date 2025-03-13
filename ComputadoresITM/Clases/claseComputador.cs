using ComputadoresITM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ComputadoresITM.Clases
{
    public class claseComputador
    {

        private DBComputadoresITMEntities dbComputadoresITM = new DBComputadoresITMEntities();
        public Computador computador { get; set; }

        public string Insertar()
        {
            try
            {
                dbComputadoresITM.Computadors.Add(computador);
                dbComputadoresITM.SaveChanges();
                return "Computador registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar el computador" + ex.Message;
            }
        }
        public string Actualizar()
        {
            Computador Computador = Consultar(computador.idcomputador);
            if (Computador == null)
            {
                return "El ID del computador no es valido";
            }
            dbComputadoresITM.Computadors.AddOrUpdate(computador);
            dbComputadoresITM.SaveChanges();
            return "El computador ha sido actualizado correctamente";
        }

        public Computador Consultar(int id)
        {
            Computador computador = dbComputadoresITM.Computadors.FirstOrDefault(e => e.idcomputador == id);
            return computador;
        }

        public List<Computador> ConsultarTodos()
        {
            return dbComputadoresITM.Computadors.OrderBy(e => e.idcomputador).ToList();
        }

        public string Eliminar(int id)
        {
            try
            {
                Computador Computador = Consultar(id);
                if (Computador == null)
                {
                    return "El ID del computador no es valido";
                }

                dbComputadoresITM.Computadors.Remove(Computador);
                dbComputadoresITM.SaveChanges();
                return "El computador ha sido eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el computador:" + ex.Message;
            }
        }
        public List<Computador> ConsultarPorMarcaProcesador(string marcaProcesador)
        {
            return dbComputadoresITM.Computadors.Where(e => e.marcaprocesador == marcaProcesador).OrderBy(e => e.idcomputador).ToList();
        }

        public List<Computador> ConsultarPorNumeroDeProcesadores(short numeroProcesadores)
        {
            return dbComputadoresITM.Computadors.Where(e => e.procesadores == numeroProcesadores).OrderBy(e => e.idcomputador).ToList();
        }
    }
}