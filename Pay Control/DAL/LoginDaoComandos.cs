using Pay_Control.Dal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Control.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string menssagem = "";
        SqlCommand cmd = new SqlCommand();
        connection con = new connection();
        SqlDataReader dr;

        public bool Verificar(string login, string senha)
        {
            // colocar os comandos sql para verificar se existe no banco dados correspondentes.
            cmd.CommandText = "Select * From Users where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (Exception)
            {
                this.menssagem = "Senha ou login incorretos!!!!";                
            }

            return tem;
        }
        
        public string cadastrar(string user, string senha, string confsenha)
        {
            // comandos para inserir os dados no banco.
            return menssagem;
        }
    }
}
