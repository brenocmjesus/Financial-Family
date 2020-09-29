using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pay_Control.Dal
{
    public class connection
    {
        SqlConnection ligacao = new SqlConnection();

        public connection()
        {
            ligacao.ConnectionString = @"Server =CARNEIRO; Database = dbFinancialFamily; Trusted_Connection = True";

        }
        public SqlConnection Conectar()
        {
            if (ligacao.State == System.Data.ConnectionState.Closed)
            {
                ligacao.Open();
            }
            return ligacao;

        }

        public SqlConnection Desconectar()
        {
            if (ligacao.State == System.Data.ConnectionState.Open)
            {
                ligacao.Close();
            }
            return ligacao;
        }

    }
    
}


