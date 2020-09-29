using Pay_Control.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Control.Controle
{
    public class Controle
    {
        public bool tem;
        public string menssagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos LoginSucess = new DAL.LoginDaoComandos();
            tem = LoginSucess.Verificar(login, senha);
            if (!(LoginSucess.menssagem.Equals ("")))
            {
                return tem;
            }
            this.menssagem = LoginSucess.menssagem;
            return tem;
        }

        public string cadastrar(string user, string senha, string confsenha)
        {
            return menssagem;
        }

    }
}
