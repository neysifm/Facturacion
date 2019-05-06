using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MiLibreria;


namespace FactuxD.Models  
{
    class Usuario : SQLManager
    {
        public int IdUsuario { get; set; }

        public  string Nombre { get; set; }

        public string Password { get; set; }

        public string Account { get; set; }

        public bool StatusAdmin { get; set; }



        public DataTable Login()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT * FROM Usuarios WHERE Account='{0}' AND Password='{1}'", this.Account.Trim(), this.Password.Trim());

            return this.EjecutarQuery(sb.ToString());
        }
    }

}
