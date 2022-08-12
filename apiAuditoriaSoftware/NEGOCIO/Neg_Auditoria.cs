using System;
using apiAuditoriaSoftware.DATOS;

namespace apiAuditoriaSoftware.NEGOCIO
{
    public class Neg_Auditoria
    {
        public object auditarBaseDatos(string cnn, string json)
        {
            return new Datos_Auditoria().auditarBaseDatos(cnn, json);
        }

        internal object auditarChequeoDatosAnomalos(string cnn, string json)
        {
            return new Datos_Auditoria().auditarChequeoDatosAnomalos(cnn, json);

        }

        internal object auditarActionForeignKeys(string cnn, string json)
        {
            return new Datos_Auditoria().auditarActionForeignKeys(cnn, json);

        }

        internal object auditarObtenerTablas(string cnn, string json)
        {
            return new Datos_Auditoria().auditarObtenerTablas(cnn, json);

        }

        internal object auditarObtenerTablasHuerfanas(string cnn, string json)
        {
            return new Datos_Auditoria().auditarObtenerTablasHuerfanas(cnn, json);

        }

        internal object auditarObtenerTodasRealaciones(string cnn, string json)
        {
            return new Datos_Auditoria().auditarObtenerTodasRealaciones(cnn, json);

        }

        internal object auditarObtenerTriggers(string cnn, string json)
        {
            return new Datos_Auditoria().auditarObtenerTriggers(cnn, json);

        }
    }
}

