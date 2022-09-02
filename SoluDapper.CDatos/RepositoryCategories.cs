using SoluDapper.CEntidades;
using SoluDapper.CDatos.Contrato;
using SoluDapper.CDatos.Helper;
using SoluDapper.CDatos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoluDapper.CDatos
{
    public class RepositoryCategories
    {
        //private readonly string connString;        
        private readonly IRepository<Category> repository;

        public RepositoryCategories()
        {           
            this.repository = new RepositoryDapper<Category>();
        }

        public List<Category> GetCategories()
        {            
            var query = "SELECT * FROM \"Categories\"";
            return repository.GetAll(query).ToList();
        }

        public int Insert(Category data)
        {
            var query = "INSERT INTO \"Categories\"(\"CategoryName\") VALUES(@CategoryName)";
            return repository.SaveData(query,data);
        }
    }
}