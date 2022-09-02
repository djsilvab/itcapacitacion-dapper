using SoluDapper.CEntidades;
using SoluDapper.CLogic;
using System;

namespace SoluDapper.CConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var categoryBL = new CategoryBL();

            var categories = categoryBL.GetCategories();

            foreach (var category in categories)
            {
                Console.WriteLine($"Id:{category.CategoryID}, Name: {category.CategoryName}");
            }

            var result = categoryBL.InsertCategories("Arquitectura");
            Console.WriteLine($"Filas insertadas: {result}");

            Console.ReadLine();
        }
    }
}