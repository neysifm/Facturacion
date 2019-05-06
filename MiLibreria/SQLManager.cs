using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public abstract class SQLManager
    {
        protected DataTable EjecutarQuery(string sql)
        {

            SqlConnection cnn = this.GetConection();
            DataTable DS = new DataTable();
            SqlDataAdapter DP = new SqlDataAdapter(sql,cnn);

            DP.Fill(DS);

            return DS;
        }

        protected SqlConnection GetConection()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
 
        }
    }
}

