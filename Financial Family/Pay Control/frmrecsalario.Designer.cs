namespace Pay_Control
{
    partial class frmrecsalario
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
            this.lblHolRefMes = new System.Windows.Forms.Label();
            this.cbSalMes = new System.Windows.Forms.ComboBox();
            this.cbSalAno = new System.Windows.Forms.ComboBox();
            this.lblHolAno = new System.Windows.Forms.Label();
            this.lblSalRec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSalDesc = new System.Windows.Forms.NumericUpDown();
            this.nudSalRec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalTotal = new System.Windows.Forms.Label();
            this.btnRecSalCalc = new System.Windows.Forms.Button();
            this.btnRecSalGrav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalRec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHolRefMes
            // 
            this.lblHolRefMes.AutoSize = true;
            this.lblHolRefMes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolRefMes.Location = new System.Drawing.Point(25, 61);
            this.lblHolRefMes.Name = "lblHolRefMes";
            this.lblHolRefMes.Size = new System.Drawing.Size(114, 15);
            this.lblHolRefMes.TabIndex = 0;
            this.lblHolRefMes.Text = "Referente ao Mês";
            // 
            // cbSalMes
            // 
            this.cbSalMes.FormattingEnabled = true;
            this.cbSalMes.Items.AddRange(new object[] {
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
            this.cbSalMes.Location = new System.Drawing.Point(150, 59);
            this.cbSalMes.Name = "cbSalMes";
            this.cbSalMes.Size = new System.Drawing.Size(121, 21);
            this.cbSalMes.TabIndex = 2;
            // 
            // cbSalAno
            // 
            this.cbSalAno.AutoCompleteCustomSource.AddRange(new string[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbSalAno.FormattingEnabled = true;
            this.cbSalAno.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbSalAno.Location = new System.Drawing.Point(150, 12);
            this.cbSalAno.Name = "cbSalAno";
            this.cbSalAno.Size = new System.Drawing.Size(121, 21);
            this.cbSalAno.TabIndex = 3;
            // 
            // lblHolAno
            // 
            this.lblHolAno.AutoSize = true;
            this.lblHolAno.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolAno.Location = new System.Drawing.Point(112, 14);
            this.lblHolAno.Name = "lblHolAno";
            this.lblHolAno.Size = new System.Drawing.Size(32, 15);
            this.lblHolAno.TabIndex = 4;
            this.lblHolAno.Text = "Ano";
            // 
            // lblSalRec
            // 
            this.lblSalRec.AutoSize = true;
            this.lblSalRec.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalRec.Location = new System.Drawing.Point(25, 110);
            this.lblSalRec.Name = "lblSalRec";
            this.lblSalRec.Size = new System.Drawing.Size(112, 15);
            this.lblSalRec.TabIndex = 5;
            this.lblSalRec.Text = "Receita Bruta €";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descontos €";
            // 
            // nudSalDesc
            // 
            this.nudSalDesc.DecimalPlaces = 2;
            this.nudSalDesc.Location = new System.Drawing.Point(150, 145);
            this.nudSalDesc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSalDesc.Name = "nudSalDesc";
            this.nudSalDesc.Size = new System.Drawing.Size(94, 20);
            this.nudSalDesc.TabIndex = 8;
            // 
            // nudSalRec
            // 
            this.nudSalRec.DecimalPlaces = 2;
            this.nudSalRec.Location = new System.Drawing.Point(150, 105);
            this.nudSalRec.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSalRec.Name = "nudSalRec";
            this.nudSalRec.Size = new System.Drawing.Size(94, 20);
            this.nudSalRec.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total :";
            // 
            // lblSalTotal
            // 
            this.lblSalTotal.AutoSize = true;
            this.lblSalTotal.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalTotal.Location = new System.Drawing.Point(141, 223);
            this.lblSalTotal.Name = "lblSalTotal";
            this.lblSalTotal.Size = new System.Drawing.Size(71, 33);
            this.lblSalTotal.TabIndex = 11;
            this.lblSalTotal.Text = "0,00";
            // 
            // btnRecSalCalc
            // 
            this.btnRecSalCalc.Location = new System.Drawing.Point(150, 190);
            this.btnRecSalCalc.Name = "btnRecSalCalc";
            this.btnRecSalCalc.Size = new System.Drawing.Size(75, 23);
            this.btnRecSalCalc.TabIndex = 12;
            this.btnRecSalCalc.Text = "Calcular";
            this.btnRecSalCalc.UseVisualStyleBackColor = true;
            this.btnRecSalCalc.Click += new System.EventHandler(this.btnRecSalCalc_Click);
            // 
            // btnRecSalGrav
            // 
            this.btnRecSalGrav.Location = new System.Drawing.Point(196, 277);
            this.btnRecSalGrav.Name = "btnRecSalGrav";
            this.btnRecSalGrav.Size = new System.Drawing.Size(75, 23);
            this.btnRecSalGrav.TabIndex = 13;
            this.btnRecSalGrav.Text = "Gravar";
            this.btnRecSalGrav.UseVisualStyleBackColor = true;
            // 
            // frmrecsalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 312);
            this.Controls.Add(this.btnRecSalGrav);
            this.Controls.Add(this.btnRecSalCalc);
            this.Controls.Add(this.lblSalTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSalRec);
            this.Controls.Add(this.nudSalDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalRec);
            this.Controls.Add(this.lblHolAno);
            this.Controls.Add(this.cbSalAno);
            this.Controls.Add(this.cbSalMes);
            this.Controls.Add(this.lblHolRefMes);
            this.Name = "frmrecsalario";
            this.Text = "Salário";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHolRefMes;
        private System.Windows.Forms.ComboBox cbSalMes;
        private System.Windows.Forms.ComboBox cbSalAno;
        private System.Windows.Forms.Label lblHolAno;
        private System.Windows.Forms.Label lblSalRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSalDesc;
        private System.Windows.Forms.NumericUpDown nudSalRec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalTotal;
        private System.Windows.Forms.Button btnRecSalCalc;
        private System.Windows.Forms.Button btnRecSalGrav;
    }
}