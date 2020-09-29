using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Control
{
    public partial class frmrecsalario : Form
    {
        public frmrecsalario()
        {
            InitializeComponent();
        }

        private void btnRecSalCalc_Click(object sender, EventArgs e)
        {
            var receita = nudSalRec.Value;
            var desconto = nudSalDesc.Value;
            var resultado = receita - desconto;
            lblSalTotal.Text = resultado.ToString();
        }
    }
}
