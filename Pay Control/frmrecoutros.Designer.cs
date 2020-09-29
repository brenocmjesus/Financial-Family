namespace Pay_Control
{
    partial class frmrecoutros
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
            this.dgvOutrosConsGrid = new System.Windows.Forms.DataGridView();
            this.lblOutrosConsTA = new System.Windows.Forms.Label();
            this.lblOutrosConsTM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOutrosConsAno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOutrosConsMes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOutrosEntAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOutrosEntAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOutrosEntValue = new System.Windows.Forms.NumericUpDown();
            this.cbOutrosEntMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbOutrosEntNome = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosConsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutrosEntValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Consultar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOutrosConsGrid);
            this.panel2.Controls.Add(this.lblOutrosConsTA);
            this.panel2.Controls.Add(this.lblOutrosConsTM);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbOutrosConsAno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbOutrosConsMes);
            this.panel2.Location = new System.Drawing.Point(12, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 214);
            this.panel2.TabIndex = 13;
            // 
            // dgvOutrosConsGrid
            // 
            this.dgvOutrosConsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutrosConsGrid.Location = new System.Drawing.Point(16, 41);
            this.dgvOutrosConsGrid.Name = "dgvOutrosConsGrid";
            this.dgvOutrosConsGrid.Size = new System.Drawing.Size(341, 113);
            this.dgvOutrosConsGrid.TabIndex = 14;
            // 
            // lblOutrosConsTA
            // 
            this.lblOutrosConsTA.AutoSize = true;
            this.lblOutrosConsTA.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutrosConsTA.Location = new System.Drawing.Point(139, 184);
            this.lblOutrosConsTA.Name = "lblOutrosConsTA";
            this.lblOutrosConsTA.Size = new System.Drawing.Size(41, 19);
            this.lblOutrosConsTA.TabIndex = 13;
            this.lblOutrosConsTA.Text = "0,00";
            // 
            // lblOutrosConsTM
            // 
            this.lblOutrosConsTM.AutoSize = true;
            this.lblOutrosConsTM.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutrosConsTM.Location = new System.Drawing.Point(140, 157);
            this.lblOutrosConsTM.Name = "lblOutrosConsTM";
            this.lblOutrosConsTM.Size = new System.Drawing.Size(41, 19);
            this.lblOutrosConsTM.TabIndex = 12;
            this.lblOutrosConsTM.Text = "0,00";
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
            // cbOutrosConsAno
            // 
            this.cbOutrosConsAno.FormattingEnabled = true;
            this.cbOutrosConsAno.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbOutrosConsAno.Location = new System.Drawing.Point(236, 8);
            this.cbOutrosConsAno.Name = "cbOutrosConsAno";
            this.cbOutrosConsAno.Size = new System.Drawing.Size(121, 21);
            this.cbOutrosConsAno.TabIndex = 9;
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
            // cbOutrosConsMes
            // 
            this.cbOutrosConsMes.FormattingEnabled = true;
            this.cbOutrosConsMes.Items.AddRange(new object[] {
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
            this.cbOutrosConsMes.Location = new System.Drawing.Point(109, 8);
            this.cbOutrosConsMes.Name = "cbOutrosConsMes";
            this.cbOutrosConsMes.Size = new System.Drawing.Size(121, 21);
            this.cbOutrosConsMes.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbOutrosEntNome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnOutrosEntAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbOutrosEntAno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudOutrosEntValue);
            this.panel1.Controls.Add(this.cbOutrosEntMes);
            this.panel1.Location = new System.Drawing.Point(13, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 158);
            this.panel1.TabIndex = 12;
            // 
            // btnOutrosEntAdd
            // 
            this.btnOutrosEntAdd.Location = new System.Drawing.Point(250, 83);
            this.btnOutrosEntAdd.Name = "btnOutrosEntAdd";
            this.btnOutrosEntAdd.Size = new System.Drawing.Size(107, 23);
            this.btnOutrosEntAdd.TabIndex = 6;
            this.btnOutrosEntAdd.Text = "Adicionar Entrada";
            this.btnOutrosEntAdd.UseVisualStyleBackColor = true;
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
            // cbOutrosEntAno
            // 
            this.cbOutrosEntAno.FormattingEnabled = true;
            this.cbOutrosEntAno.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbOutrosEntAno.Location = new System.Drawing.Point(236, 49);
            this.cbOutrosEntAno.Name = "cbOutrosEntAno";
            this.cbOutrosEntAno.Size = new System.Drawing.Size(121, 21);
            this.cbOutrosEntAno.TabIndex = 4;
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
            // nudOutrosEntValue
            // 
            this.nudOutrosEntValue.DecimalPlaces = 2;
            this.nudOutrosEntValue.Location = new System.Drawing.Point(109, 86);
            this.nudOutrosEntValue.Name = "nudOutrosEntValue";
            this.nudOutrosEntValue.Size = new System.Drawing.Size(120, 20);
            this.nudOutrosEntValue.TabIndex = 1;
            // 
            // cbOutrosEntMes
            // 
            this.cbOutrosEntMes.FormattingEnabled = true;
            this.cbOutrosEntMes.Items.AddRange(new object[] {
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
            this.cbOutrosEntMes.Location = new System.Drawing.Point(109, 49);
            this.cbOutrosEntMes.Name = "cbOutrosEntMes";
            this.cbOutrosEntMes.Size = new System.Drawing.Size(121, 21);
            this.cbOutrosEntMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Entradas";
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
            // txbOutrosEntNome
            // 
            this.txbOutrosEntNome.Location = new System.Drawing.Point(108, 10);
            this.txbOutrosEntNome.Name = "txbOutrosEntNome";
            this.txbOutrosEntNome.Size = new System.Drawing.Size(248, 20);
            this.txbOutrosEntNome.TabIndex = 8;
            // 
            // frmrecoutros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmrecoutros";
            this.Text = "Outros";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosConsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutrosEntValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOutrosConsGrid;
        private System.Windows.Forms.Label lblOutrosConsTA;
        private System.Windows.Forms.Label lblOutrosConsTM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOutrosConsAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOutrosConsMes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbOutrosEntNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOutrosEntAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOutrosEntAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOutrosEntValue;
        private System.Windows.Forms.ComboBox cbOutrosEntMes;
        private System.Windows.Forms.Label label2;
    }
}