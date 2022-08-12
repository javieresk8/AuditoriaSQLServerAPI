using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using apiAuditoriaSoftware.ENTIDADES;
using apiAuditoriaSoftware.NEGOCIO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiAuditoriaSoftware.Controllers
{
    [Route("api/[controller]")]
    public class AuditoriaController : Controller
    {
        String cnn = "Data Source=localhost,1433;Initial Catalog=";
        String cnn_p2 = ";Persist Security Info=True;User ID=sa;Password=javieresk8@-";
        // GET api/values/5
        [HttpGet("getDatosAnomalos/{NombreBase}")]
        public IEnumerable<String> GetDatosAnomalos(String NombreBase)
        {
            string[] result = new string[1];
            string value;
            cnn = cnn + NombreBase + cnn_p2;
            BaseDatos baseDatos = new BaseDatos(NombreBase);
            value = JsonConvert.SerializeObject(baseDatos);
            result[0] = new Neg_Auditoria().auditarChequeoDatosAnomalos(cnn, value).ToString();
            return result;
        }

        [HttpGet("getActionFK/{NombreBase}")]
        public IEnumerable<String> GetActionsFK(String NombreBase)
        {
            string[] result = new string[1];
            string value;
            cnn = cnn + NombreBase + cnn_p2;
            BaseDatos baseDatos = new BaseDatos(NombreBase);
            value = JsonConvert.SerializeObject(baseDatos);
            result[0] = new Neg_Auditoria().auditarActionForeignKeys(cnn, value).ToString();
            escribirLog(result);
            return result;
        }

        [HttpGet("getTablas/{NombreBase}")]
        public IEnumerable<String> GetTablas(String NombreBase)
        {
            string[] result = new string[1];
            string value;
            cnn = cnn + NombreBase + cnn_p2;
            BaseDatos baseDatos = new BaseDatos(NombreBase);
            value = JsonConvert.SerializeObject(baseDatos);
            result[0] = new Neg_Auditoria().auditarObtenerTablas(cnn, value).ToString();
            escribirLog(result);
            return result;
        }

        [HttpGet("getTablasHuerfanas/{NombreBase}")]
        public IEnumerable<String> GetTablasHuerfanas(String NombreBase)
        {
            string[] result = new string[1];
            string value;
            cnn = cnn + NombreBase + cnn_p2;
            BaseDatos baseDatos = new BaseDatos(NombreBase);
            value = JsonConvert.SerializeObject(baseDatos);
            result[0] = new Neg_Auditoria().auditarObtenerTablasHuerfanas(cnn, value).ToString();
            escribirLog(result);
            return result;
        }

        [HttpGet("getTodasRelaciones/{NombreBase}")]
        public IEnumerable<String> GetTodasRelaciones(String NombreBase)
        {
            string[] result = new string[1];
            string value;
            cnn = cnn + NombreBase + cnn_p2;
            BaseDatos baseDatos = new BaseDatos(NombreBase);
            value = JsonConvert.SerializeObject(baseDatos);
            result[0] = new Neg_Auditoria().auditarObtenerTodasRealaciones(cnn, value).ToString();
            escribirLog(result);
            return result;
        }

        [HttpGet("getTriggers/{NombreBase}")]
        public IEnumerable<String> GetTrigers(String NombreBase)
        {
            string[] result = new string[1];
            string value;
            cnn = cnn + NombreBase + cnn_p2;
            BaseDatos baseDatos = new BaseDatos(NombreBase);
            value = JsonConvert.SerializeObject(baseDatos);
            result[0] = new Neg_Auditoria().auditarObtenerTriggers(cnn, value).ToString();
            escribirLog(result);
            return result;
        }

        public void escribirLog(string[] registro)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // users/nombreUsuario
            Console.WriteLine("Mi path es: " + docPath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "log_auditoria.txt"), true))
            {
                outputFile.WriteLine(registro[0] + DateTime.Now.ToString());
            }
        }


    }
}

