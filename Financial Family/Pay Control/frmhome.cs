using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Control
{
    public partial class frmhome : Form
    {
            public frmhome()
            {
                InitializeComponent();
                
            }

            public void pcbhomereceitas_MouseEnter(object sender, EventArgs e)
            {
                pcbhomereceitas.Width = 98;
                pcbhomereceitas.Height = 91;

            }

            public void pcbhomereceitas_MouseLeave(object sender, EventArgs e)
            {
                pcbhomereceitas.Width = 88;
                pcbhomereceitas.Height = 81;

            }

            private void pcbhomereceitas_Click(object sender, EventArgs e)
            {
                frmreceitas r = new frmreceitas();
                r.Show();
            
            }

            public void pcbhomedespesas_MouseEnter(object sender, EventArgs e)
            {
                pcbhomedespesas.Width = 98;
                pcbhomedespesas.Height = 91;

            }

            public void pcbhomedespesas_MouseLeave(object sender, EventArgs e)
            {
                pcbhomedespesas.Width = 88;
                pcbhomedespesas.Height = 81;
            }

            private void pcbhomedespesas_Click(object sender, EventArgs e)
            {
                frmdespesas d = new frmdespesas();
                d.Show();
            }

    }
}
