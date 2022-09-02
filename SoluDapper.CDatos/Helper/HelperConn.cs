using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SoluDapper.CDatos.Helper
{
    public struct TipoMotorSQL
    {
        public const string SQLServer = "SQLServer";
        public const string PostgreSQL = "PostgreSQL";
    }

    public class HelperConn : IDisposable
    {
        public IDbConnection GetConnection { get; }

        public HelperConn()
        {
            var _connString = new Helper.HelperDb("DefaultConnection").GetConnectionString();
            var _provider = new Helper.HelperDb("Provider").GetConnectionString();

            switch (_provider)
            {
                case TipoMotorSQL.SQLServer:
                    GetConnection = new SqlConnection(_connString);
                    break;

                case TipoMotorSQL.PostgreSQL:
                    GetConnection = new NpgsqlConnection(_connString);
                    break;

            }
        }

        public void Dispose()
        {
            GetConnection.Dispose();
        }
    }
}
