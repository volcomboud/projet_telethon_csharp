using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioDonationSys;


namespace tp_final_csharp_prise_3
{
    public partial class pagePrincipale : Form
    {
        public pagePrincipale()
        {
            InitializeComponent();
            cacherTabs();
            tabc_page_princ.SelectedIndex = 4;
        }

        private void picb_exit_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Voulez vous quitter le service de donations?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes) Application.Exit();            
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ajout_donateur_Click(object sender, EventArgs e)
        {
            
        }

        private void pagePrincipale_Load(object sender, EventArgs e)
        {

        }
        private void cacherTabs()
        {
            tabc_page_princ.Appearance = TabAppearance.FlatButtons;
            tabc_page_princ.ItemSize = new Size(0, 1);
            tabc_page_princ.SizeMode = TabSizeMode.Fixed;
        }

        private void picb_next_Click(object sender, EventArgs e)
        {
            //ctrl=(Control) sender;
            //this.SelectNextControl(ctrl,true,true,true,true);
            // this.SelectNextControl(ctrl, false, true, true, true); backward
            tabc_page_princ.SelectedIndex = 1;
        }

        private void picb_previous_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 2;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_donateur_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 0;
        }

        private void btn_ajout_commanditaire_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login page_connection = new login();
            page_connection.Region = this.Region;
            page_connection.Show();
            this.Hide();
        }

        private void btn_acceuil_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 4;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 8;
        }

        private void picb_close_donneur_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 4;
        }

        private void picb_close_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 4;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lbl_prenom_Click(object sender, EventArgs e)
        {

        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nom_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 3;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 7;
        }

        private void btn_afficher_prix_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 6;

        }

        private void btn_afficher_sponsor_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 8;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 3;
        }
    }
}
