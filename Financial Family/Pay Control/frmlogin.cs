using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Control
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }


        private void btnlogenter_Click(object sender, EventArgs e)
        {
            Pay_Control.Controle.Controle logi = new Pay_Control.Controle.Controle();
            logi.acessar(txbloguser.Text, txblogpassword.Text);
            if (logi.menssagem.Equals ("")) 
            { 
                if (logi.tem) 
                {
                    MessageBox.Show("Logado com Sucesso", "Entrou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmhome home = new frmhome();
                    home.Show();
                }
                else 
                {
                    MessageBox.Show("Login ou Senha Incorretos","Falha no Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show(logi.menssagem);
            }

        }

        private void btnlogcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogregister_Click(object sender, EventArgs e)
        {
            frmregistro reg = new frmregistro();
            reg.Show();
        }
        
    }
}
