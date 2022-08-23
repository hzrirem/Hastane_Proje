using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    class SqlBaglantisi
    {
        public SqlConnection sqlconnection()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-HBC1R06;Initial Catalog=HastaneProje;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
