namespace Pay_Control
{
    partial class frmdespesas
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
            this.components = new System.ComponentModel.Container();
            this.btnHomeDespGrav = new System.Windows.Forms.Button();
            this.nudHomeDespValor = new System.Windows.Forms.NumericUpDown();
            this.lblSalRec = new System.Windows.Forms.Label();
            this.lblHolAno = new System.Windows.Forms.Label();
            this.cbHomeDespAno = new System.Windows.Forms.ComboBox();
            this.cbHomeDespMes = new System.Windows.Forms.ComboBox();
            this.lblHolRefMes = new System.Windows.Forms.Label();
            this.txbHomeDespNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHomeDespView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mêsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFinancialFamilyDataSet = new Pay_Control.dbFinancialFamilyDataSet();
            this.despesasTableAdapter = new Pay_Control.dbFinancialFamilyDataSetTableAdapters.DespesasTableAdapter();
            this.btnHomeDespCons = new System.Windows.Forms.Button();
            this.lblHomeDespTotal = new System.Windows.Forms.Label();
            this.lblHomeDespTotalValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeDespValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeDespView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFinancialFamilyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHomeDespGrav
            // 
            this.btnHomeDespGrav.Location = new System.Drawing.Point(199, 236);
            this.btnHomeDespGrav.Name = "btnHomeDespGrav";
            this.btnHomeDespGrav.Size = new System.Drawing.Size(75, 23);
            this.btnHomeDespGrav.TabIndex = 20;
            this.btnHomeDespGrav.Text = "Gravar";
            this.btnHomeDespGrav.UseVisualStyleBackColor = true;
            this.btnHomeDespGrav.Click += new System.EventHandler(this.btnHomeDespGrav_Click);
            // 
            // nudHomeDespValor
            // 
            this.nudHomeDespValor.DecimalPlaces = 2;
            this.nudHomeDespValor.Location = new System.Drawing.Point(153, 186);
            this.nudHomeDespValor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudHomeDespValor.Name = "nudHomeDespValor";
            this.nudHomeDespValor.Size = new System.Drawing.Size(94, 20);
            this.nudHomeDespValor.TabIndex = 19;
            // 
            // lblSalRec
            // 
            this.lblSalRec.AutoSize = true;
            this.lblSalRec.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalRec.Location = new System.Drawing.Point(100, 187);
            this.lblSalRec.Name = "lblSalRec";
            this.lblSalRec.Size = new System.Drawing.Size(42, 15);
            this.lblSalRec.TabIndex = 18;
            this.lblSalRec.Text = "Valor";
            // 
            // lblHolAno
            // 
            this.lblHolAno.AutoSize = true;
            this.lblHolAno.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolAno.Location = new System.Drawing.Point(115, 14);
            this.lblHolAno.Name = "lblHolAno";
            this.lblHolAno.Size = new System.Drawing.Size(32, 15);
            this.lblHolAno.TabIndex = 17;
            this.lblHolAno.Text = "Ano";
            // 
            // cbHomeDespAno
            // 
            this.cbHomeDespAno.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cbHomeDespAno.FormattingEnabled = true;
            this.cbHomeDespAno.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbHomeDespAno.Location = new System.Drawing.Point(153, 12);
            this.cbHomeDespAno.Name = "cbHomeDespAno";
            this.cbHomeDespAno.Size = new System.Drawing.Size(121, 21);
            this.cbHomeDespAno.TabIndex = 16;
            // 
            // cbHomeDespMes
            // 
            this.cbHomeDespMes.FormattingEnabled = true;
            this.cbHomeDespMes.Items.AddRange(new object[] {
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
            this.cbHomeDespMes.Location = new System.Drawing.Point(153, 59);
            this.cbHomeDespMes.Name = "cbHomeDespMes";
            this.cbHomeDespMes.Size = new System.Drawing.Size(121, 21);
            this.cbHomeDespMes.TabIndex = 15;
            // 
            // lblHolRefMes
            // 
            this.lblHolRefMes.AutoSize = true;
            this.lblHolRefMes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolRefMes.Location = new System.Drawing.Point(28, 61);
            this.lblHolRefMes.Name = "lblHolRefMes";
            this.lblHolRefMes.Size = new System.Drawing.Size(114, 15);
            this.lblHolRefMes.TabIndex = 14;
            this.lblHolRefMes.Text = "Referente ao Mês";
            // 
            // txbHomeDespNome
            // 
            this.txbHomeDespNome.Location = new System.Drawing.Point(153, 124);
            this.txbHomeDespNome.Name = "txbHomeDespNome";
            this.txbHomeDespNome.Size = new System.Drawing.Size(121, 20);
            this.txbHomeDespNome.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome da Conta";
            // 
            // dgvHomeDespView
            // 
            this.dgvHomeDespView.AutoGenerateColumns = false;
            this.dgvHomeDespView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeDespView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.mêsDataGridViewTextBoxColumn,
            this.contaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgvHomeDespView.DataSource = this.despesasBindingSource;
            this.dgvHomeDespView.Location = new System.Drawing.Point(328, 12);
            this.dgvHomeDespView.Name = "dgvHomeDespView";
            this.dgvHomeDespView.Size = new System.Drawing.Size(501, 247);
            this.dgvHomeDespView.TabIndex = 24;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // mêsDataGridViewTextBoxColumn
            // 
            this.mêsDataGridViewTextBoxColumn.DataPropertyName = "Mês";
            this.mêsDataGridViewTextBoxColumn.HeaderText = "Mês";
            this.mêsDataGridViewTextBoxColumn.Name = "mêsDataGridViewTextBoxColumn";
            // 
            // contaDataGridViewTextBoxColumn
            // 
            this.contaDataGridViewTextBoxColumn.DataPropertyName = "Conta";
            this.contaDataGridViewTextBoxColumn.HeaderText = "Conta";
            this.contaDataGridViewTextBoxColumn.Name = "contaDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataMember = "Despesas";
            this.despesasBindingSource.DataSource = this.dbFinancialFamilyDataSet;
            // 
            // dbFinancialFamilyDataSet
            // 
            this.dbFinancialFamilyDataSet.DataSetName = "dbFinancialFamilyDataSet";
            this.dbFinancialFamilyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // despesasTableAdapter
            // 
            this.despesasTableAdapter.ClearBeforeFill = true;
            // 
            // btnHomeDespCons
            // 
            this.btnHomeDespCons.Location = new System.Drawing.Point(31, 236);
            this.btnHomeDespCons.Name = "btnHomeDespCons";
            this.btnHomeDespCons.Size = new System.Drawing.Size(75, 23);
            this.btnHomeDespCons.TabIndex = 25;
            this.btnHomeDespCons.Text = "Consultar";
            this.btnHomeDespCons.UseVisualStyleBackColor = true;
            this.btnHomeDespCons.Click += new System.EventHandler(this.btnHomeDespCons_Click);
            // 
            // lblHomeDespTotal
            // 
            this.lblHomeDespTotal.AutoSize = true;
            this.lblHomeDespTotal.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeDespTotal.Location = new System.Drawing.Point(687, 271);
            this.lblHomeDespTotal.Name = "lblHomeDespTotal";
            this.lblHomeDespTotal.Size = new System.Drawing.Size(59, 23);
            this.lblHomeDespTotal.TabIndex = 26;
            this.lblHomeDespTotal.Text = "Total:";
            // 
            // lblHomeDespTotalValor
            // 
            this.lblHomeDespTotalValor.AutoSize = true;
            this.lblHomeDespTotalValor.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeDespTotalValor.Location = new System.Drawing.Point(768, 271);
            this.lblHomeDespTotalValor.Name = "lblHomeDespTotalValor";
            this.lblHomeDespTotalValor.Size = new System.Drawing.Size(48, 23);
            this.lblHomeDespTotalValor.TabIndex = 27;
            this.lblHomeDespTotalValor.Text = "0,00";
            // 
            // frmdespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 310);
            this.Controls.Add(this.lblHomeDespTotalValor);
            this.Controls.Add(this.lblHomeDespTotal);
            this.Controls.Add(this.btnHomeDespCons);
            this.Controls.Add(this.dgvHomeDespView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbHomeDespNome);
            this.Controls.Add(this.btnHomeDespGrav);
            this.Controls.Add(this.nudHomeDespValor);
            this.Controls.Add(this.lblSalRec);
            this.Controls.Add(this.lblHolAno);
            this.Controls.Add(this.cbHomeDespAno);
            this.Controls.Add(this.cbHomeDespMes);
            this.Controls.Add(this.lblHolRefMes);
            this.Name = "frmdespesas";
            this.Text = "frmdespesas";
            this.Load += new System.EventHandler(this.frmdespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeDespValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeDespView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFinancialFamilyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomeDespGrav;
        private System.Windows.Forms.NumericUpDown nudHomeDespValor;
        private System.Windows.Forms.Label lblSalRec;
        private System.Windows.Forms.Label lblHolAno;
        private System.Windows.Forms.ComboBox cbHomeDespAno;
        private System.Windows.Forms.ComboBox cbHomeDespMes;
        private System.Windows.Forms.Label lblHolRefMes;
        private System.Windows.Forms.TextBox txbHomeDespNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHomeDespView;
        private dbFinancialFamilyDataSet dbFinancialFamilyDataSet;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private dbFinancialFamilyDataSetTableAdapters.DespesasTableAdapter despesasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mêsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHomeDespCons;
        private System.Windows.Forms.Label lblHomeDespTotal;
        private System.Windows.Forms.Label lblHomeDespTotalValor;
    }
}