using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace JdoCRUD.DAO
{
    public sealed class helper
    {
        private static helper _instancia;
        public static helper Instancia
        {
            get { return _instancia ?? (_instancia = new helper()); }
        }
        private helper() { }

        private string imageStorage;

        public string GetConnectionString()
        {
            string senhaSalva;
            string connectionString = ConfigurationManager.ConnectionStrings["JdoCRUD.Properties.Settings.jdoConnectionString"].ConnectionString;
            string caminhoSenha = AppDomain.CurrentDomain.BaseDirectory + "senha.txt";
            if (System.IO.File.Exists(caminhoSenha))
            {
                senhaSalva = System.IO.File.ReadAllText(caminhoSenha);
                connectionString += "password=" + senhaSalva;
            }
            return connectionString;
        }

        public string GetImageStoreUrl()
        {
            string url;
            string imageStorage = AppDomain.CurrentDomain.BaseDirectory + "imageStorage.txt";
            if (System.IO.File.Exists(imageStorage))
            {
                url = System.IO.File.ReadAllText(imageStorage);
                return url;
            }
            else
            {
                return "";
            }
        }
    }
}
