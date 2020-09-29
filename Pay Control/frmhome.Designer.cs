namespace Pay_Control
{
    partial class frmhome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbhomereceitas = new System.Windows.Forms.PictureBox();
            this.pcbhomedespesas = new System.Windows.Forms.PictureBox();
            this.lblhomereceitas = new System.Windows.Forms.Label();
            this.lblhomedespesas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbhomereceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbhomedespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pay_Control.Properties.Resources.Bem_vindo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcbhomereceitas
            // 
            this.pcbhomereceitas.ErrorImage = null;
            this.pcbhomereceitas.Image = global::Pay_Control.Properties.Resources.shopify;
            this.pcbhomereceitas.Location = new System.Drawing.Point(96, 238);
            this.pcbhomereceitas.Name = "pcbhomereceitas";
            this.pcbhomereceitas.Size = new System.Drawing.Size(88, 81);
            this.pcbhomereceitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbhomereceitas.TabIndex = 1;
            this.pcbhomereceitas.TabStop = false;
            this.pcbhomereceitas.Click += new System.EventHandler(this.pcbhomereceitas_Click);
            this.pcbhomereceitas.MouseEnter += new System.EventHandler(this.pcbhomereceitas_MouseEnter);
            this.pcbhomereceitas.MouseLeave += new System.EventHandler(this.pcbhomereceitas_MouseLeave);
            // 
            // pcbhomedespesas
            // 
            this.pcbhomedespesas.ErrorImage = null;
            this.pcbhomedespesas.Image = global::Pay_Control.Properties.Resources.relatorio;
            this.pcbhomedespesas.Location = new System.Drawing.Point(281, 238);
            this.pcbhomedespesas.Name = "pcbhomedespesas";
            this.pcbhomedespesas.Size = new System.Drawing.Size(88, 81);
            this.pcbhomedespesas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbhomedespesas.TabIndex = 2;
            this.pcbhomedespesas.TabStop = false;
            this.pcbhomedespesas.Click += new System.EventHandler(this.pcbhomedespesas_Click);
            this.pcbhomedespesas.MouseEnter += new System.EventHandler(this.pcbhomedespesas_MouseEnter);
            this.pcbhomedespesas.MouseLeave += new System.EventHandler(this.pcbhomedespesas_MouseLeave);
            // 
            // lblhomereceitas
            // 
            this.lblhomereceitas.AutoSize = true;
            this.lblhomereceitas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhomereceitas.Location = new System.Drawing.Point(110, 327);
            this.lblhomereceitas.Name = "lblhomereceitas";
            this.lblhomereceitas.Size = new System.Drawing.Size(64, 16);
            this.lblhomereceitas.TabIndex = 3;
            this.lblhomereceitas.Text = "Receitas";
            // 
            // lblhomedespesas
            // 
            this.lblhomedespesas.AutoSize = true;
            this.lblhomedespesas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhomedespesas.Location = new System.Drawing.Point(290, 327);
            this.lblhomedespesas.Name = "lblhomedespesas";
            this.lblhomedespesas.Size = new System.Drawing.Size(70, 16);
            this.lblhomedespesas.TabIndex = 4;
            this.lblhomedespesas.Text = "Despesas";
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 352);
            this.Controls.Add(this.lblhomedespesas);
            this.Controls.Add(this.lblhomereceitas);
            this.Controls.Add(this.pcbhomedespesas);
            this.Controls.Add(this.pcbhomereceitas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmhome";
            this.Text = "bemvindo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbhomereceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbhomedespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbhomereceitas;
        private System.Windows.Forms.PictureBox pcbhomedespesas;
        private System.Windows.Forms.Label lblhomereceitas;
        private System.Windows.Forms.Label lblhomedespesas;
    }
}