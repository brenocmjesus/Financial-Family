namespace Pay_Control
{
    partial class frmregistro
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
            this.lblregNome = new System.Windows.Forms.Label();
            this.tbRegNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbRegEndereco = new System.Windows.Forms.TextBox();
            this.lblregEndereco = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRegFem = new System.Windows.Forms.RadioButton();
            this.rbRegMasc = new System.Windows.Forms.RadioButton();
            this.tbRegConcelho = new System.Windows.Forms.TextBox();
            this.lblRegConcelho = new System.Windows.Forms.Label();
            this.lblRegDistrito = new System.Windows.Forms.Label();
            this.cbbRegDistrito = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegRegistrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblregNome
            // 
            this.lblregNome.AutoSize = true;
            this.lblregNome.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregNome.Location = new System.Drawing.Point(21, 66);
            this.lblregNome.Name = "lblregNome";
            this.lblregNome.Size = new System.Drawing.Size(135, 19);
            this.lblregNome.TabIndex = 0;
            this.lblregNome.Text = "Nome Completo";
            // 
            // tbRegNome
            // 
            this.tbRegNome.Location = new System.Drawing.Point(163, 67);
            this.tbRegNome.Name = "tbRegNome";
            this.tbRegNome.Size = new System.Drawing.Size(349, 20);
            this.tbRegNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbRegEndereco
            // 
            this.tbRegEndereco.Location = new System.Drawing.Point(163, 242);
            this.tbRegEndereco.Name = "tbRegEndereco";
            this.tbRegEndereco.Size = new System.Drawing.Size(349, 20);
            this.tbRegEndereco.TabIndex = 5;
            // 
            // lblregEndereco
            // 
            this.lblregEndereco.AutoSize = true;
            this.lblregEndereco.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregEndereco.Location = new System.Drawing.Point(21, 241);
            this.lblregEndereco.Name = "lblregEndereco";
            this.lblregEndereco.Size = new System.Drawing.Size(82, 19);
            this.lblregEndereco.TabIndex = 4;
            this.lblregEndereco.Text = "Endereço";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(163, 147);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(99, 20);
            this.dtpDataNasc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gênero";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRegFem);
            this.panel1.Controls.Add(this.rbRegMasc);
            this.panel1.Location = new System.Drawing.Point(163, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 40);
            this.panel1.TabIndex = 9;
            // 
            // rbRegFem
            // 
            this.rbRegFem.AutoSize = true;
            this.rbRegFem.Location = new System.Drawing.Point(104, 11);
            this.rbRegFem.Name = "rbRegFem";
            this.rbRegFem.Size = new System.Drawing.Size(67, 17);
            this.rbRegFem.TabIndex = 1;
            this.rbRegFem.TabStop = true;
            this.rbRegFem.Text = "Feminino";
            this.rbRegFem.UseVisualStyleBackColor = true;
            // 
            // rbRegMasc
            // 
            this.rbRegMasc.AutoSize = true;
            this.rbRegMasc.Location = new System.Drawing.Point(13, 11);
            this.rbRegMasc.Name = "rbRegMasc";
            this.rbRegMasc.Size = new System.Drawing.Size(73, 17);
            this.rbRegMasc.TabIndex = 0;
            this.rbRegMasc.TabStop = true;
            this.rbRegMasc.Text = "Masculino";
            this.rbRegMasc.UseVisualStyleBackColor = true;
            this.rbRegMasc.CheckedChanged += new System.EventHandler(this.rbRegMasc_CheckedChanged);
            // 
            // tbRegConcelho
            // 
            this.tbRegConcelho.Location = new System.Drawing.Point(163, 285);
            this.tbRegConcelho.Name = "tbRegConcelho";
            this.tbRegConcelho.Size = new System.Drawing.Size(349, 20);
            this.tbRegConcelho.TabIndex = 11;
            // 
            // lblRegConcelho
            // 
            this.lblRegConcelho.AutoSize = true;
            this.lblRegConcelho.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegConcelho.Location = new System.Drawing.Point(21, 284);
            this.lblRegConcelho.Name = "lblRegConcelho";
            this.lblRegConcelho.Size = new System.Drawing.Size(82, 19);
            this.lblRegConcelho.TabIndex = 10;
            this.lblRegConcelho.Text = "Concelho";
            // 
            // lblRegDistrito
            // 
            this.lblRegDistrito.AutoSize = true;
            this.lblRegDistrito.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegDistrito.Location = new System.Drawing.Point(21, 327);
            this.lblRegDistrito.Name = "lblRegDistrito";
            this.lblRegDistrito.Size = new System.Drawing.Size(68, 19);
            this.lblRegDistrito.TabIndex = 12;
            this.lblRegDistrito.Text = "Distrito";
            // 
            // cbbRegDistrito
            // 
            this.cbbRegDistrito.FormattingEnabled = true;
            this.cbbRegDistrito.Items.AddRange(new object[] {
            "Aveiro",
            "Beja",
            "Braga",
            "Bragança",
            "Castelo Branco",
            "Coimbra",
            "Évora",
            "Faro",
            "Guarda",
            "Leiria",
            "Lisboa",
            "Portalegre",
            "Porto",
            "Santarém",
            "Setúbal",
            "Viana do Castelo",
            "Vila Real",
            "Viseu"});
            this.cbbRegDistrito.Location = new System.Drawing.Point(163, 328);
            this.cbbRegDistrito.Name = "cbbRegDistrito";
            this.cbbRegDistrito.Size = new System.Drawing.Size(219, 21);
            this.cbbRegDistrito.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTRO DE NOVO USUÁRIO";
            // 
            // btnRegRegistrar
            // 
            this.btnRegRegistrar.Location = new System.Drawing.Point(373, 364);
            this.btnRegRegistrar.Name = "btnRegRegistrar";
            this.btnRegRegistrar.Size = new System.Drawing.Size(137, 26);
            this.btnRegRegistrar.TabIndex = 15;
            this.btnRegRegistrar.Text = "Registrar";
            this.btnRegRegistrar.UseVisualStyleBackColor = true;
            this.btnRegRegistrar.Click += new System.EventHandler(this.btnRegRegistrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Login";
            // 
            // frmregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbRegDistrito);
            this.Controls.Add(this.lblRegDistrito);
            this.Controls.Add(this.tbRegConcelho);
            this.Controls.Add(this.lblRegConcelho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.tbRegEndereco);
            this.Controls.Add(this.lblregEndereco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRegNome);
            this.Controls.Add(this.lblregNome);
            this.Name = "frmregistro";
            this.Text = "Registros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregNome;
        private System.Windows.Forms.TextBox tbRegNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbRegEndereco;
        private System.Windows.Forms.Label lblregEndereco;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbRegFem;
        private System.Windows.Forms.RadioButton rbRegMasc;
        private System.Windows.Forms.TextBox tbRegConcelho;
        private System.Windows.Forms.Label lblRegConcelho;
        private System.Windows.Forms.Label lblRegDistrito;
        private System.Windows.Forms.ComboBox cbbRegDistrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegRegistrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}