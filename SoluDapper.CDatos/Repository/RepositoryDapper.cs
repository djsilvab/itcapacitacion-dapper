using Dapper;
using SoluDapper.CDatos.Contrato;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Npgsql;
using System.Data;

namespace SoluDapper.CDatos.Repository
{    
    public class RepositoryDapper<T> : IRepository<T> where T : class
    {       
        public IEnumerable<T> GetAll(string query)
        {
            using (var connection = new Helper.HelperConn().GetConnection)
            {
                return connection.Query<T>(query).ToList();
            }          
        }

        public int SaveData(string query, T data)
        {
            using (var connection = new Helper.HelperConn().GetConnection)
            {
                return connection.Execute(query, data);
            }
        }
      
    }
}