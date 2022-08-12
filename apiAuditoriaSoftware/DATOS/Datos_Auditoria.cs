using System;
namespace apiAuditoriaSoftware.DATOS
{
    public class Datos_Auditoria: AbsDataReadersP
    {
        public object auditarBaseDatos(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_auditar_base_datos", json);
        }

        internal object auditarChequeoDatosAnomalos(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_audit_chequeo_datos_anomalos", json);

        }

        internal object auditarActionForeignKeys(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_audit_obtener_action_foreign_keys", json);

        }

        internal object auditarObtenerTablas(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_audit_obtener_tablas", json);

        }

        internal object auditarObtenerTablasHuerfanas(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_audit_obtener_tablas_sin_relacion", json);

        }

        internal object auditarObtenerTodasRealaciones(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_audit_obtener_todas_relaciones", json);

        }

        internal object auditarObtenerTriggers(string cnn, string json)
        {
            return dataReaderStoreProcedure(cnn, "sp_audit_obtener_triggers", json);

        }
    }
}

