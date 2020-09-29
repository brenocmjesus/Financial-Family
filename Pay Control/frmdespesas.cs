using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pay_Control
{
    public partial class frmdespesas : Form
    {
        public frmdespesas()
        {
            InitializeComponent();
        }

        private void btnHomeDespGrav_Click(object sender, EventArgs e)
        {
            SqlConnection ligacao = new SqlConnection();
            ligacao.ConnectionString = @"Server =CARNEIRO; Database = dbFinancialFamily; Trusted_Connection = True";
            ligacao.Open();
            SqlCommand gravar = new SqlCommand("sp_InserDespesa", ligacao);
            gravar.CommandType = CommandType.StoredProcedure;
            gravar.Parameters.AddWithValue("@Ano", SqlDbType.Int).Value = cbHomeDespAno.Text.Trim();
            gravar.Parameters.AddWithValue("@Mes", SqlDbType.VarChar).Value = cbHomeDespMes.SelectedItem.ToString();
            gravar.Parameters.AddWithValue("@Conta", SqlDbType.VarChar).Value = txbHomeDespNome.Text.Trim();
            gravar.Parameters.AddWithValue("@Valor", SqlDbType.Decimal).Value = nudHomeDespValor.Value.ToString();
            gravar.ExecuteNonQuery();

            MessageBox.Show("Despesa Incluida com Sucesso!!!");
            ligacao.Close();            
        }

        private void frmdespesas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFinancialFamilyDataSet.Despesas' table. You can move, or remove it, as needed.
            this.despesasTableAdapter.Fill(this.dbFinancialFamilyDataSet.Despesas);

        }

        private void btnHomeDespCons_Click(object sender, EventArgs e)
        {
            string query = "select Ano, Mês, Conta, Valor From Despesas";
            SqlConnection ligacao = new SqlConnection();
            ligacao.ConnectionString = @"Server =CARNEIRO; Database = dbFinancialFamily; Trusted_Connection = True";
            ligacao.Open();
            SqlCommand comando = new SqlCommand(query,ligacao);
            lblHomeDespTotalValor.Text = dgvHomeDespView.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[valorDataGridViewTextBoxColumn.Name].Value ?? 0)).ToString("##.00");

            try
            {
            SqlDataAdapter adapor = new SqlDataAdapter(comando);
            DataTable datalista = new DataTable();
            adapor.Fill(datalista);
            dgvHomeDespView.DataSource = datalista;
            }
            catch
            {
                MessageBox.Show("Deu Erro!!!");
            }
        }
    }
}
