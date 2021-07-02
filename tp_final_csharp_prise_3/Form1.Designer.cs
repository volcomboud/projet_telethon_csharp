
namespace tp_final_csharp_prise_3
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtb_user = new System.Windows.Forms.TextBox();
            this.txtb_pass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.picb_exit = new System.Windows.Forms.PictureBox();
            this.pnl_match_form = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_exit)).BeginInit();
            this.pnl_match_form.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tp_final_csharp_prise_3.Properties.Resources.helping_hands;
            this.pictureBox1.Location = new System.Drawing.Point(44, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tp_final_csharp_prise_3.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(32, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::tp_final_csharp_prise_3.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(32, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // txtb_user
            // 
            this.txtb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_user.Location = new System.Drawing.Point(87, 25);
            this.txtb_user.Name = "txtb_user";
            this.txtb_user.Size = new System.Drawing.Size(202, 31);
            this.txtb_user.TabIndex = 0;
            // 
            // txtb_pass
            // 
            this.txtb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_pass.Location = new System.Drawing.Point(87, 95);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.Size = new System.Drawing.Size(202, 31);
            this.txtb_pass.TabIndex = 1;
            this.txtb_pass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtb_user);
            this.panel1.Controls.Add(this.txtb_pass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(44, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 150);
            this.panel1.TabIndex = 5;
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.SystemColors.Window;
            this.btn_connexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connexion.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_connexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_connexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Perpetua", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_connexion.ForeColor = System.Drawing.Color.Navy;
            this.btn_connexion.Location = new System.Drawing.Point(76, 443);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(257, 61);
            this.btn_connexion.TabIndex = 3;
            this.btn_connexion.Text = "Se Connecter";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // picb_exit
            // 
            this.picb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_exit.Image = global::tp_final_csharp_prise_3.Properties.Resources.exit;
            this.picb_exit.Location = new System.Drawing.Point(23, 525);
            this.picb_exit.Name = "picb_exit";
            this.picb_exit.Size = new System.Drawing.Size(52, 47);
            this.picb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_exit.TabIndex = 6;
            this.picb_exit.TabStop = false;
            this.picb_exit.Click += new System.EventHandler(this.picb_exit_Click);
            // 
            // pnl_match_form
            // 
            this.pnl_match_form.BackColor = System.Drawing.Color.White;
            this.pnl_match_form.Controls.Add(this.pictureBox1);
            this.pnl_match_form.Controls.Add(this.picb_exit);
            this.pnl_match_form.Controls.Add(this.panel1);
            this.pnl_match_form.Controls.Add(this.btn_connexion);
            this.pnl_match_form.Location = new System.Drawing.Point(5, 4);
            this.pnl_match_form.Name = "pnl_match_form";
            this.pnl_match_form.Size = new System.Drawing.Size(390, 614);
            this.pnl_match_form.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.pnl_match_form);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 622);
            this.panel2.TabIndex = 8;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 622);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Système Téléthon STE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_exit)).EndInit();
            this.pnl_match_form.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtb_user;
        private System.Windows.Forms.TextBox txtb_pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.PictureBox picb_exit;
        private System.Windows.Forms.Panel pnl_match_form;
        private System.Windows.Forms.Panel panel2;
    }
}

