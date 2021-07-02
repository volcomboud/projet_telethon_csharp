
namespace tp_final_csharp_prise_3
{
    partial class pagePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagePrincipale));
            this.pnl_pp_bot = new System.Windows.Forms.Panel();
            this.picb_exit = new System.Windows.Forms.PictureBox();
            this.pnl_pp_top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_pp_left = new System.Windows.Forms.Panel();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_ajout_commanditaire = new System.Windows.Forms.Button();
            this.btn_ajout_donateur = new System.Windows.Forms.Button();
            this.pnl_pp_bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_exit)).BeginInit();
            this.pnl_pp_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_pp_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_pp_bot
            // 
            this.pnl_pp_bot.BackColor = System.Drawing.Color.White;
            this.pnl_pp_bot.Controls.Add(this.picb_exit);
            this.pnl_pp_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_pp_bot.Location = new System.Drawing.Point(0, 574);
            this.pnl_pp_bot.Name = "pnl_pp_bot";
            this.pnl_pp_bot.Size = new System.Drawing.Size(1236, 114);
            this.pnl_pp_bot.TabIndex = 0;
            // 
            // picb_exit
            // 
            this.picb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_exit.Image = global::tp_final_csharp_prise_3.Properties.Resources.exit;
            this.picb_exit.Location = new System.Drawing.Point(13, 41);
            this.picb_exit.Name = "picb_exit";
            this.picb_exit.Size = new System.Drawing.Size(52, 47);
            this.picb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_exit.TabIndex = 7;
            this.picb_exit.TabStop = false;
            this.picb_exit.Click += new System.EventHandler(this.picb_exit_Click);
            // 
            // pnl_pp_top
            // 
            this.pnl_pp_top.BackColor = System.Drawing.Color.Aqua;
            this.pnl_pp_top.Controls.Add(this.panel2);
            this.pnl_pp_top.Controls.Add(this.panel1);
            this.pnl_pp_top.Controls.Add(this.pictureBox2);
            this.pnl_pp_top.Controls.Add(this.pictureBox1);
            this.pnl_pp_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_pp_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_pp_top.Name = "pnl_pp_top";
            this.pnl_pp_top.Size = new System.Drawing.Size(1236, 107);
            this.pnl_pp_top.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(856, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 99);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(187, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 99);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tp_final_csharp_prise_3.Properties.Resources.telethon_0;
            this.pictureBox2.Location = new System.Drawing.Point(387, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(473, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tp_final_csharp_prise_3.Properties.Resources.helping_hands;
            this.pictureBox1.Location = new System.Drawing.Point(0, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_pp_left
            // 
            this.pnl_pp_left.BackColor = System.Drawing.Color.White;
            this.pnl_pp_left.Controls.Add(this.btn_log_out);
            this.pnl_pp_left.Controls.Add(this.btn_ajout_commanditaire);
            this.pnl_pp_left.Controls.Add(this.btn_ajout_donateur);
            this.pnl_pp_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_pp_left.Location = new System.Drawing.Point(0, 107);
            this.pnl_pp_left.Name = "pnl_pp_left";
            this.pnl_pp_left.Size = new System.Drawing.Size(185, 467);
            this.pnl_pp_left.TabIndex = 2;
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.Aqua;
            this.btn_log_out.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_log_out.ForeColor = System.Drawing.Color.Navy;
            this.btn_log_out.Location = new System.Drawing.Point(13, 413);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(160, 34);
            this.btn_log_out.TabIndex = 2;
            this.btn_log_out.Text = "Déconnection";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_ajout_commanditaire
            // 
            this.btn_ajout_commanditaire.BackColor = System.Drawing.Color.Aqua;
            this.btn_ajout_commanditaire.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ajout_commanditaire.ForeColor = System.Drawing.Color.Navy;
            this.btn_ajout_commanditaire.Location = new System.Drawing.Point(13, 144);
            this.btn_ajout_commanditaire.Name = "btn_ajout_commanditaire";
            this.btn_ajout_commanditaire.Size = new System.Drawing.Size(160, 34);
            this.btn_ajout_commanditaire.TabIndex = 1;
            this.btn_ajout_commanditaire.Text = "Commanditaire";
            this.btn_ajout_commanditaire.UseVisualStyleBackColor = false;
            // 
            // btn_ajout_donateur
            // 
            this.btn_ajout_donateur.BackColor = System.Drawing.Color.Aqua;
            this.btn_ajout_donateur.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ajout_donateur.ForeColor = System.Drawing.Color.Navy;
            this.btn_ajout_donateur.Location = new System.Drawing.Point(13, 55);
            this.btn_ajout_donateur.Name = "btn_ajout_donateur";
            this.btn_ajout_donateur.Size = new System.Drawing.Size(160, 34);
            this.btn_ajout_donateur.TabIndex = 0;
            this.btn_ajout_donateur.Text = "Donateur";
            this.btn_ajout_donateur.UseVisualStyleBackColor = false;
            this.btn_ajout_donateur.Click += new System.EventHandler(this.btn_ajout_donateur_Click);
            // 
            // pagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1236, 688);
            this.Controls.Add(this.pnl_pp_left);
            this.Controls.Add(this.pnl_pp_top);
            this.Controls.Add(this.pnl_pp_bot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pagePrincipale";
            this.Text = "Service de donation";
            this.pnl_pp_bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_exit)).EndInit();
            this.pnl_pp_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_pp_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_pp_bot;
        private System.Windows.Forms.Panel pnl_pp_top;
        private System.Windows.Forms.Panel pnl_pp_left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_ajout_commanditaire;
        private System.Windows.Forms.Button btn_ajout_donateur;
        private System.Windows.Forms.PictureBox picb_exit;
        private System.Windows.Forms.Button btn_log_out;
    }
}