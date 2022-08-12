using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using apiAuditoriaSoftware.ENTIDADES;
using Newtonsoft.Json;

namespace apiAuditoriaSoftware.DATOS
{
    public abstract class AbsDataReadersP
    {
        public object dataReaderStoreProcedure(string cnn, string store_procedure)
        {
            object result = "[]";

            try
            {
                SqlDataReader dReader = null;
                StringBuilder stringBuilder = new StringBuilder();

                dReader = DConexion.EjecutarDataReader(cnn, store_procedure);

                while (dReader.Read())
                {
                    stringBuilder.Append(dReader[0].ToString());
                }

                if (!dReader.IsClosed)
                {
                    dReader.Close();
                }

                if (stringBuilder != null && stringBuilder.ToString().Length > 0)
                { result = stringBuilder; }

            }

            catch (Exception ex)
            {
                List<RespuestaE> listErr = new List<RespuestaE>();
                RespuestaE obj = new RespuestaE();
                obj.Respuesta = ex.Message;
                listErr.Add(obj);
                result = JsonConvert.SerializeObject(listErr);
            }

            return result;

        }
        public object dataReaderStoreProcedure(string cnn, string store_procedure, string json)
        {
            object result = "[]";

            try
            {
                SqlDataReader dReader = null;
                StringBuilder stringBuilder = new StringBuilder();
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@json", json);

                dReader = DConexion.EjecutarDataReader(cnn, store_procedure, parameter);

                while (dReader.Read())
                {
                    stringBuilder.Append(dReader[0].ToString());
                }

                if (!dReader.IsClosed)
                {
                    dReader.Close();
                }

                if (stringBuilder != null && stringBuilder.ToString().Length > 0)
                { result = stringBuilder; }

            }

            catch (Exception ex)
            {
                List<RespuestaE> listErr = new List<RespuestaE>();
                RespuestaE obj = new RespuestaE();
                obj.Respuesta = ex.Message;
                listErr.Add(obj);
                result = JsonConvert.SerializeObject(listErr);
            }

            return result;

        }
    }
}

