namespace Pay_Control
{
    partial class frmreceitas
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
            this.lblrecSal = new System.Windows.Forms.Label();
            this.lblrecoutros = new System.Windows.Forms.Label();
            this.lblrecsegsocial = new System.Windows.Forms.Label();
            this.lblrectransferwise = new System.Windows.Forms.Label();
            this.pcbrecsegsocial = new System.Windows.Forms.PictureBox();
            this.pcbrecoutros = new System.Windows.Forms.PictureBox();
            this.pcbrectw = new System.Windows.Forms.PictureBox();
            this.pcbrecSal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrecsegsocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrecoutros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrectw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrecSal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrecSal
            // 
            this.lblrecSal.AutoSize = true;
            this.lblrecSal.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecSal.Location = new System.Drawing.Point(93, 216);
            this.lblrecSal.Name = "lblrecSal";
            this.lblrecSal.Size = new System.Drawing.Size(50, 15);
            this.lblrecSal.TabIndex = 4;
            this.lblrecSal.Text = "Salário";
            // 
            // lblrecoutros
            // 
            this.lblrecoutros.AutoSize = true;
            this.lblrecoutros.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecoutros.Location = new System.Drawing.Point(346, 453);
            this.lblrecoutros.Name = "lblrecoutros";
            this.lblrecoutros.Size = new System.Drawing.Size(51, 15);
            this.lblrecoutros.TabIndex = 5;
            this.lblrecoutros.Text = "Outros";
            // 
            // lblrecsegsocial
            // 
            this.lblrecsegsocial.AutoSize = true;
            this.lblrecsegsocial.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecsegsocial.Location = new System.Drawing.Point(69, 451);
            this.lblrecsegsocial.Name = "lblrecsegsocial";
            this.lblrecsegsocial.Size = new System.Drawing.Size(109, 15);
            this.lblrecsegsocial.TabIndex = 6;
            this.lblrecsegsocial.Text = "Segurança Social";
            // 
            // lblrectransferwise
            // 
            this.lblrectransferwise.AutoSize = true;
            this.lblrectransferwise.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrectransferwise.Location = new System.Drawing.Point(332, 216);
            this.lblrectransferwise.Name = "lblrectransferwise";
            this.lblrectransferwise.Size = new System.Drawing.Size(92, 15);
            this.lblrectransferwise.TabIndex = 7;
            this.lblrectransferwise.Text = "Transfer Wise";
            // 
            // pcbrecsegsocial
            // 
            this.pcbrecsegsocial.Image = global::Pay_Control.Properties.Resources.segsocial;
            this.pcbrecsegsocial.Location = new System.Drawing.Point(29, 267);
            this.pcbrecsegsocial.Name = "pcbrecsegsocial";
            this.pcbrecsegsocial.Size = new System.Drawing.Size(188, 181);
            this.pcbrecsegsocial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbrecsegsocial.TabIndex = 3;
            this.pcbrecsegsocial.TabStop = false;
            this.pcbrecsegsocial.Click += new System.EventHandler(this.pcbrecsegsocial_Click);
            this.pcbrecsegsocial.MouseEnter += new System.EventHandler(this.pcbrecsegsocial_MouseEnter);
            this.pcbrecsegsocial.MouseLeave += new System.EventHandler(this.pcbrecsegsocial_MouseLeave);
            // 
            // pcbrecoutros
            // 
            this.pcbrecoutros.Image = global::Pay_Control.Properties.Resources.dinheiro;
            this.pcbrecoutros.Location = new System.Drawing.Point(284, 267);
            this.pcbrecoutros.Name = "pcbrecoutros";
            this.pcbrecoutros.Size = new System.Drawing.Size(188, 181);
            this.pcbrecoutros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbrecoutros.TabIndex = 2;
            this.pcbrecoutros.TabStop = false;
            this.pcbrecoutros.Click += new System.EventHandler(this.pcbrecoutros_Click);
            this.pcbrecoutros.MouseEnter += new System.EventHandler(this.pcbrecoutros_MouseEnter);
            this.pcbrecoutros.MouseLeave += new System.EventHandler(this.pcbrecoutros_MouseLeave);
            // 
            // pcbrectw
            // 
            this.pcbrectw.Image = global::Pay_Control.Properties.Resources.kisspng_debit_card_transferwise_bank_credit_card_payment_mastercard_5acafc66ed1915_9127750615232523269712;
            this.pcbrectw.Location = new System.Drawing.Point(284, 32);
            this.pcbrectw.Name = "pcbrectw";
            this.pcbrectw.Size = new System.Drawing.Size(188, 181);
            this.pcbrectw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbrectw.TabIndex = 1;
            this.pcbrectw.TabStop = false;
            this.pcbrectw.Click += new System.EventHandler(this.pcbrectw_Click);
            this.pcbrectw.MouseEnter += new System.EventHandler(this.pcbrectw_MouseEnter);
            this.pcbrectw.MouseLeave += new System.EventHandler(this.pcbrectw_MouseLeave);
            // 
            // pcbrecSal
            // 
            this.pcbrecSal.Image = global::Pay_Control.Properties.Resources.envelope;
            this.pcbrecSal.ImageLocation = "";
            this.pcbrecSal.Location = new System.Drawing.Point(29, 32);
            this.pcbrecSal.Name = "pcbrecSal";
            this.pcbrecSal.Size = new System.Drawing.Size(188, 181);
            this.pcbrecSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbrecSal.TabIndex = 0;
            this.pcbrecSal.TabStop = false;
            this.pcbrecSal.Click += new System.EventHandler(this.pcbrecSal_Click);
            this.pcbrecSal.MouseEnter += new System.EventHandler(this.pcbrecSal_MouseEnter);
            this.pcbrecSal.MouseLeave += new System.EventHandler(this.pcbrecSal_MouseLeave);
            // 
            // frmreceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 477);
            this.Controls.Add(this.lblrectransferwise);
            this.Controls.Add(this.lblrecsegsocial);
            this.Controls.Add(this.lblrecoutros);
            this.Controls.Add(this.lblrecSal);
            this.Controls.Add(this.pcbrecsegsocial);
            this.Controls.Add(this.pcbrecoutros);
            this.Controls.Add(this.pcbrectw);
            this.Controls.Add(this.pcbrecSal);
            this.Name = "frmreceitas";
            this.Text = "Receitas";
            ((System.ComponentModel.ISupportInitialize)(this.pcbrecsegsocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrecoutros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrectw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrecSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbrecSal;
        private System.Windows.Forms.PictureBox pcbrectw;
        private System.Windows.Forms.PictureBox pcbrecoutros;
        private System.Windows.Forms.PictureBox pcbrecsegsocial;
        private System.Windows.Forms.Label lblrecSal;
        private System.Windows.Forms.Label lblrecoutros;
        private System.Windows.Forms.Label lblrecsegsocial;
        private System.Windows.Forms.Label lblrectransferwise;
    }
}