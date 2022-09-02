using Microsoft.Extensions.Configuration;
using System;

namespace SoluDapper.CDatos.Helper
{
    public class HelperDb
    {
        private readonly string nameConnString;
        public HelperDb(string nameConnString)
        {
            this.nameConnString = nameConnString;
        }

        public string GetConnectionString()
        {
            var ruta = AppDomain.CurrentDomain.BaseDirectory;
            var configuration = new ConfigurationBuilder()
                    //.SetBasePath(Directory.GetCurrentDirectory())//no siempre se usa
                    .AddJsonFile("appsettings.json")
                    .Build();

            var urlApi = configuration.GetSection("AppSettings")["UrlApi"];
            
            return configuration.GetConnectionString(nameConnString);
        }
    }
}