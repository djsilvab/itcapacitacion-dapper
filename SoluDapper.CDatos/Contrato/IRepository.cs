using System;
using System.Collections.Generic;
using System.Text;

namespace SoluDapper.CDatos.Contrato
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string query);

        int SaveData(string query, T data);
    }
}