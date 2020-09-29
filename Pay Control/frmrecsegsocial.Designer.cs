namespace Pay_Control
{
    partial class frmrecsegsocial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSegSocialConsGrid = new System.Windows.Forms.DataGridView();
            this.lblSegSocialConsTA = new System.Windows.Forms.Label();
            this.lblSegSocialConsTM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSegSocialConsAno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSegSocialConsMes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSegSocialEntNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSegSocialEntAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSegSocialEntAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSegSocialEntValue = new System.Windows.Forms.NumericUpDown();
            this.cbSegSocialEntMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegSocialConsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegSocialEntValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Consultar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSegSocialConsGrid);
            this.panel2.Controls.Add(this.lblSegSocialConsTA);
            this.panel2.Controls.Add(this.lblSegSocialConsTM);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbSegSocialConsAno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbSegSocialConsMes);
            this.panel2.Location = new System.Drawing.Point(15, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 214);
            this.panel2.TabIndex = 17;
            // 
            // dgvSegSocialConsGrid
            // 
            this.dgvSegSocialConsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegSocialConsGrid.Location = new System.Drawing.Point(16, 41);
            this.dgvSegSocialConsGrid.Name = "dgvSegSocialConsGrid";
            this.dgvSegSocialConsGrid.Size = new System.Drawing.Size(341, 113);
            this.dgvSegSocialConsGrid.TabIndex = 14;
            // 
            // lblSegSocialConsTA
            // 
            this.lblSegSocialConsTA.AutoSize = true;
            this.lblSegSocialConsTA.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegSocialConsTA.Location = new System.Drawing.Point(139, 184);
            this.lblSegSocialConsTA.Name = "lblSegSocialConsTA";
            this.lblSegSocialConsTA.Size = new System.Drawing.Size(41, 19);
            this.lblSegSocialConsTA.TabIndex = 13;
            this.lblSegSocialConsTA.Text = "0,00";
            // 
            // lblSegSocialConsTM
            // 
            this.lblSegSocialConsTM.AutoSize = true;
            this.lblSegSocialConsTM.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegSocialConsTM.Location = new System.Drawing.Point(140, 157);
            this.lblSegSocialConsTM.Name = "lblSegSocialConsTM";
            this.lblSegSocialConsTM.Size = new System.Drawing.Size(41, 19);
            this.lblSegSocialConsTM.TabIndex = 12;
            this.lblSegSocialConsTM.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total do Ano - €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total do Mês - €";
            // 
            // cbSegSocialConsAno
            // 
            this.cbSegSocialConsAno.FormattingEnabled = true;
            this.cbSegSocialConsAno.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbSegSocialConsAno.Location = new System.Drawing.Point(236, 8);
            this.cbSegSocialConsAno.Name = "cbSegSocialConsAno";
            this.cbSegSocialConsAno.Size = new System.Drawing.Size(121, 21);
            this.cbSegSocialConsAno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // cbSegSocialConsMes
            // 
            this.cbSegSocialConsMes.FormattingEnabled = true;
            this.cbSegSocialConsMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbSegSocialConsMes.Location = new System.Drawing.Point(109, 8);
            this.cbSegSocialConsMes.Name = "cbSegSocialConsMes";
            this.cbSegSocialConsMes.Size = new System.Drawing.Size(121, 21);
            this.cbSegSocialConsMes.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSegSocialEntNome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSegSocialEntAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSegSocialEntAno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudSegSocialEntValue);
            this.panel1.Controls.Add(this.cbSegSocialEntMes);
            this.panel1.Location = new System.Drawing.Point(16, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 158);
            this.panel1.TabIndex = 16;
            // 
            // txbSegSocialEntNome
            // 
            this.txbSegSocialEntNome.Location = new System.Drawing.Point(108, 10);
            this.txbSegSocialEntNome.Name = "txbSegSocialEntNome";
            this.txbSegSocialEntNome.Size = new System.Drawing.Size(248, 20);
            this.txbSegSocialEntNome.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nome";
            // 
            // btnSegSocialEntAdd
            // 
            this.btnSegSocialEntAdd.Location = new System.Drawing.Point(250, 83);
            this.btnSegSocialEntAdd.Name = "btnSegSocialEntAdd";
            this.btnSegSocialEntAdd.Size = new System.Drawing.Size(107, 23);
            this.btnSegSocialEntAdd.TabIndex = 6;
            this.btnSegSocialEntAdd.Text = "Adicionar Entrada";
            this.btnSegSocialEntAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor €";
            // 
            // cbSegSocialEntAno
            // 
            this.cbSegSocialEntAno.FormattingEnabled = true;
            this.cbSegSocialEntAno.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbSegSocialEntAno.Location = new System.Drawing.Point(236, 49);
            this.cbSegSocialEntAno.Name = "cbSegSocialEntAno";
            this.cbSegSocialEntAno.Size = new System.Drawing.Size(121, 21);
            this.cbSegSocialEntAno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // nudSegSocialEntValue
            // 
            this.nudSegSocialEntValue.DecimalPlaces = 2;
            this.nudSegSocialEntValue.Location = new System.Drawing.Point(109, 86);
            this.nudSegSocialEntValue.Name = "nudSegSocialEntValue";
            this.nudSegSocialEntValue.Size = new System.Drawing.Size(120, 20);
            this.nudSegSocialEntValue.TabIndex = 1;
            // 
            // cbSegSocialEntMes
            // 
            this.cbSegSocialEntMes.FormattingEnabled = true;
            this.cbSegSocialEntMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbSegSocialEntMes.Location = new System.Drawing.Point(109, 49);
            this.cbSegSocialEntMes.Name = "cbSegSocialEntMes";
            this.cbSegSocialEntMes.Size = new System.Drawing.Size(121, 21);
            this.cbSegSocialEntMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Entradas";
            // 
            // frmrecsegsocial
            // 
            this.ClientSize = new System.Drawing.Size(404, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmrecsegsocial";
            this.Text = "Segurança Social";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegSocialConsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegSocialEntValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSegSocialConsGrid;
        private System.Windows.Forms.Label lblSegSocialConsTA;
        private System.Windows.Forms.Label lblSegSocialConsTM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSegSocialConsAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSegSocialConsMes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSegSocialEntNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSegSocialEntAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSegSocialEntAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSegSocialEntValue;
        private System.Windows.Forms.ComboBox cbSegSocialEntMes;
        private System.Windows.Forms.Label label2;
    }
}