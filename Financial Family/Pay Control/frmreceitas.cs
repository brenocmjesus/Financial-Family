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
    public partial class frmreceitas : Form
    {
        public frmreceitas()
        {
            InitializeComponent();
        }
        //////////////////////////////Eventos do Mouse Leave e Enter/////////////////////////////////
        public void pcbrecSal_MouseEnter(object sender, EventArgs e)
        {
            pcbrecSal.Width = 198;
            pcbrecSal.Height = 191;
        }
        public void pcbrecSal_MouseLeave(object sender, EventArgs e)
        {
            pcbrecSal.Width = 188;
            pcbrecSal.Height = 181;
        }
        public void pcbrectw_MouseEnter(object sender, EventArgs e)
        {
            pcbrectw.Width = 198;
            pcbrectw.Height = 191;
        }
        public void pcbrectw_MouseLeave(object sender, EventArgs e)
        {
            pcbrectw.Width = 188;
            pcbrectw.Height = 181;
        }
        public void pcbrecsegsocial_MouseEnter(object sender, EventArgs e)
        {
            pcbrecsegsocial.Width = 198;
            pcbrecsegsocial.Height = 191;
        }
        public void pcbrecsegsocial_MouseLeave(object sender, EventArgs e)
        {
            pcbrecsegsocial.Width = 188;
            pcbrecsegsocial.Height = 181;
        }
        public void pcbrecoutros_MouseEnter(object sender, EventArgs e)
        {
            pcbrecoutros.Width = 198;
            pcbrecoutros.Height = 191;
        }
        public void pcbrecoutros_MouseLeave(object sender, EventArgs e)
        {
            pcbrecoutros.Width = 188;
            pcbrecoutros.Height = 181;
        }

        //////////////////////////////Eventos do Mouse Click/////////////////////////////////
        private void pcbrecoutros_Click(object sender, EventArgs e)
        {
            frmrecoutros o = new frmrecoutros();
            o.Show();
            this.Close();
        }
        private void pcbrecSal_Click(object sender, EventArgs e)
        {
            frmrecsalario h = new frmrecsalario();
            h.Show();
            this.Close();
        }
        private void pcbrectw_Click(object sender, EventArgs e)
        {
            frmrectw tw = new frmrectw();
            tw.Show();
            this.Close();
        }
        private void pcbrecsegsocial_Click(object sender, EventArgs e)
        {
            frmrecsegsocial ss = new frmrecsegsocial();
            ss.Show();
            this.Close();
        }

    }
}
