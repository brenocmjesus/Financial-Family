using Pay_Control.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pay_Control
{
    public partial class frmregistro : Form
    {
        
        public frmregistro()
        {
            InitializeComponent();
        }

        public CommandType CommandType { get; private set; }

        public void btnRegRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection Ligar = new SqlConnection();
            Ligar.ConnectionString = @"Server =CARNEIRO; Database = dbFinancialFamily; Trusted_Connection = True";
            Ligar.Open();
            SqlCommand registrar = new SqlCommand("sp_InsertUser", Ligar);
            registrar.CommandType = CommandType.StoredProcedure;
            registrar.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = tbRegNome.Text.Trim();
            registrar.Parameters.AddWithValue("@Login", SqlDbType.VarChar).Value = tbRegNome.Text.Trim();
            registrar.Parameters.AddWithValue("@DataNasc", SqlDbType.Date).Value = dtpDataNasc.Value.ToLongDateString();
            registrar.Parameters.AddWithValue("@Genero", SqlDbType.VarChar).Value = GenCheck.ToString();
            registrar.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = tbRegEndereco.Text.Trim();
            registrar.Parameters.AddWithValue("@Conselho", SqlDbType.VarChar).Value = tbRegConcelho.Text.Trim();
            registrar.Parameters.AddWithValue("@Distrito", SqlDbType.VarChar).Value = cbbRegDistrito.SelectedItem.GetType();
            registrar.ExecuteNonQuery();
            MessageBox.Show("Cadastrou!");
            this.Close();
            
        }

        string GenCheck = "";
        public void rbRegMasc_CheckedChanged(object sender, EventArgs e)
        {
            

            if (rbRegMasc.Checked) 
            {
                GenCheck = "Masculino";
            }
            else 
            {
                GenCheck = "Feminino";
            }
        }
    }
}
