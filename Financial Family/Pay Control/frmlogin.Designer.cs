using System;

namespace Pay_Control
{
    partial class frmlogin
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
            this.btnlogenter = new System.Windows.Forms.Button();
            this.btnlogcancel = new System.Windows.Forms.Button();
            this.btnlogregister = new System.Windows.Forms.Button();
            this.lblloguser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbloguser = new System.Windows.Forms.TextBox();
            this.txblogpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogenter
            // 
            this.btnlogenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogenter.Location = new System.Drawing.Point(56, 169);
            this.btnlogenter.Name = "btnlogenter";
            this.btnlogenter.Size = new System.Drawing.Size(163, 26);
            this.btnlogenter.TabIndex = 0;
            this.btnlogenter.Text = "Enter";
            this.btnlogenter.UseVisualStyleBackColor = true;
            this.btnlogenter.Click += new System.EventHandler(this.btnlogenter_Click);
            // 
            // btnlogcancel
            // 
            this.btnlogcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogcancel.Location = new System.Drawing.Point(148, 217);
            this.btnlogcancel.Name = "btnlogcancel";
            this.btnlogcancel.Size = new System.Drawing.Size(71, 25);
            this.btnlogcancel.TabIndex = 1;
            this.btnlogcancel.Text = "Cancel";
            this.btnlogcancel.UseVisualStyleBackColor = true;
            this.btnlogcancel.Click += new System.EventHandler(this.btnlogcancel_Click);
            // 
            // btnlogregister
            // 
            this.btnlogregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogregister.Location = new System.Drawing.Point(56, 217);
            this.btnlogregister.Name = "btnlogregister";
            this.btnlogregister.Size = new System.Drawing.Size(71, 25);
            this.btnlogregister.TabIndex = 2;
            this.btnlogregister.Text = "Register";
            this.btnlogregister.UseVisualStyleBackColor = true;
            this.btnlogregister.Click += new System.EventHandler(this.btnlogregister_Click);
            // 
            // lblloguser
            // 
            this.lblloguser.AutoSize = true;
            this.lblloguser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloguser.Location = new System.Drawing.Point(12, 92);
            this.lblloguser.Name = "lblloguser";
            this.lblloguser.Size = new System.Drawing.Size(35, 15);
            this.lblloguser.TabIndex = 3;
            this.lblloguser.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txbloguser
            // 
            this.txbloguser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbloguser.Location = new System.Drawing.Point(81, 90);
            this.txbloguser.Name = "txbloguser";
            this.txbloguser.Size = new System.Drawing.Size(173, 20);
            this.txbloguser.TabIndex = 5;
            // 
            // txblogpassword
            // 
            this.txblogpassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txblogpassword.Location = new System.Drawing.Point(81, 129);
            this.txblogpassword.Name = "txblogpassword";
            this.txblogpassword.PasswordChar = '*';
            this.txblogpassword.Size = new System.Drawing.Size(173, 20);
            this.txblogpassword.TabIndex = 6;
            this.txblogpassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Pay_Control.Properties.Resources.changing_money;
            this.pictureBox1.Image = global::Pay_Control.Properties.Resources.changing_money;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txblogpassword);
            this.Controls.Add(this.txbloguser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblloguser);
            this.Controls.Add(this.btnlogregister);
            this.Controls.Add(this.btnlogcancel);
            this.Controls.Add(this.btnlogenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmlogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogenter;
        private System.Windows.Forms.Button btnlogcancel;
        private System.Windows.Forms.Button btnlogregister;
        private System.Windows.Forms.Label lblloguser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbloguser;
        private System.Windows.Forms.TextBox txblogpassword;
        private System.Windows.Forms.PictureBox pictureBox1;

        
    }
}

