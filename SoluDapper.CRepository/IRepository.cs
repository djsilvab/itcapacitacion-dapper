using System;
using System.Collections.Generic;
using System.Text;

namespace SoluDapper.CRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string query);
    }
}