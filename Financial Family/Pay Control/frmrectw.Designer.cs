namespace Pay_Control
{
    partial class frmrectw
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
            this.nudTwEntValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTwEntMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTwEntAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTwEntAno = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTwConsGrid = new System.Windows.Forms.DataGridView();
            this.lblTwConsTA = new System.Windows.Forms.Label();
            this.lblTwConsTM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTwConsAno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTwConsMes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTwEntValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTwConsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTwEntValue
            // 
            this.nudTwEntValue.DecimalPlaces = 2;
            this.nudTwEntValue.Location = new System.Drawing.Point(109, 47);
            this.nudTwEntValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTwEntValue.Name = "nudTwEntValue";
            this.nudTwEntValue.Size = new System.Drawing.Size(120, 20);
            this.nudTwEntValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // cbTwEntMes
            // 
            this.cbTwEntMes.FormattingEnabled = true;
            this.cbTwEntMes.Items.AddRange(new object[] {
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
            this.cbTwEntMes.Location = new System.Drawing.Point(109, 10);
            this.cbTwEntMes.Name = "cbTwEntMes";
            this.cbTwEntMes.Size = new System.Drawing.Size(121, 21);
            this.cbTwEntMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entradas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTwEntAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTwEntAno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudTwEntValue);
            this.panel1.Controls.Add(this.cbTwEntMes);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 78);
            this.panel1.TabIndex = 5;
            // 
            // btnTwEntAdd
            // 
            this.btnTwEntAdd.Location = new System.Drawing.Point(250, 44);
            this.btnTwEntAdd.Name = "btnTwEntAdd";
            this.btnTwEntAdd.Size = new System.Drawing.Size(107, 23);
            this.btnTwEntAdd.TabIndex = 6;
            this.btnTwEntAdd.Text = "Adicionar Entrada";
            this.btnTwEntAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor €";
            // 
            // cbTwEntAno
            // 
            this.cbTwEntAno.FormattingEnabled = true;
            this.cbTwEntAno.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbTwEntAno.Location = new System.Drawing.Point(236, 10);
            this.cbTwEntAno.Name = "cbTwEntAno";
            this.cbTwEntAno.Size = new System.Drawing.Size(121, 21);
            this.cbTwEntAno.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTwConsGrid);
            this.panel2.Controls.Add(this.lblTwConsTA);
            this.panel2.Controls.Add(this.lblTwConsTM);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbTwConsAno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbTwConsMes);
            this.panel2.Location = new System.Drawing.Point(12, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 283);
            this.panel2.TabIndex = 9;
            // 
            // dgvTwConsGrid
            // 
            this.dgvTwConsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTwConsGrid.Location = new System.Drawing.Point(16, 61);
            this.dgvTwConsGrid.Name = "dgvTwConsGrid";
            this.dgvTwConsGrid.Size = new System.Drawing.Size(341, 163);
            this.dgvTwConsGrid.TabIndex = 14;
            // 
            // lblTwConsTA
            // 
            this.lblTwConsTA.AutoSize = true;
            this.lblTwConsTA.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwConsTA.Location = new System.Drawing.Point(139, 254);
            this.lblTwConsTA.Name = "lblTwConsTA";
            this.lblTwConsTA.Size = new System.Drawing.Size(41, 19);
            this.lblTwConsTA.TabIndex = 13;
            this.lblTwConsTA.Text = "0,00";
            // 
            // lblTwConsTM
            // 
            this.lblTwConsTM.AutoSize = true;
            this.lblTwConsTM.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwConsTM.Location = new System.Drawing.Point(140, 227);
            this.lblTwConsTM.Name = "lblTwConsTM";
            this.lblTwConsTM.Size = new System.Drawing.Size(41, 19);
            this.lblTwConsTM.TabIndex = 12;
            this.lblTwConsTM.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total do Ano - €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total do Mês - €";
            // 
            // cbTwConsAno
            // 
            this.cbTwConsAno.FormattingEnabled = true;
            this.cbTwConsAno.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbTwConsAno.Location = new System.Drawing.Point(236, 15);
            this.cbTwConsAno.Name = "cbTwConsAno";
            this.cbTwConsAno.Size = new System.Drawing.Size(121, 21);
            this.cbTwConsAno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // cbTwConsMes
            // 
            this.cbTwConsMes.FormattingEnabled = true;
            this.cbTwConsMes.Items.AddRange(new object[] {
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
            this.cbTwConsMes.Location = new System.Drawing.Point(109, 15);
            this.cbTwConsMes.Name = "cbTwConsMes";
            this.cbTwConsMes.Size = new System.Drawing.Size(121, 21);
            this.cbTwConsMes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Consultar";
            // 
            // frmrectw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmrectw";
            this.Text = "Transfer Wise";
            ((System.ComponentModel.ISupportInitialize)(this.nudTwEntValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTwConsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTwEntValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTwEntMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTwEntAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTwEntAno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTwConsTA;
        private System.Windows.Forms.Label lblTwConsTM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTwConsAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTwConsMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTwConsGrid;
    }
}