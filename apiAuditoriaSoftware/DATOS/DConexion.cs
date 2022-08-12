using Microsoft.ApplicationBlocks.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace apiAuditoriaSoftware.DATOS
{
    public static class DConexion
    {
        public static SqlDataReader EjecutarDataReader(string key, string SP, SqlParameter[] parametros)
        {
            return SqlHelper.ExecuteReader(key, CommandType.StoredProcedure, SP, parametros);
        }

        public static SqlDataReader EjecutarDataReader(string key, string SP)
        {
            return SqlHelper.ExecuteReader(key, CommandType.StoredProcedure, SP);
        }

        public static DataSet DataSet(string key, string SP)
        {
            return SqlHelper.ExecuteDataset(key, CommandType.StoredProcedure, SP);
        }

        public static DataSet DataSet(string key, string SP, SqlParameter[] parametros)
        {
            return SqlHelper.ExecuteDataset(key, CommandType.StoredProcedure, SP, parametros);
        }

        public static Int32 EjecutarNomQuery(string key, string SP, SqlParameter[] parametros)
        {
            return SqlHelper.ExecuteNonQuery(key, CommandType.StoredProcedure, SP, parametros);
        }

    }
}

