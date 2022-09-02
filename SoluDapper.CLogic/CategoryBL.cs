using SoluDapper.CEntidades;
using SoluDapper.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoluDapper.CLogic
{  
    public class CategoryBL
    {   
        public List<Category> GetCategories()
        {
            return new RepositoryCategories().GetCategories();
        }

        public int InsertCategories(string nombre)
        {
            var category = new Category { CategoryName = nombre };
            return new RepositoryCategories().Insert(category);
        }

    }
}