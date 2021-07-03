using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using biblioDonationSys;


namespace tp_final_csharp_prise_3
{
    public partial class pagePrincipale : Form
    {
        GestionnaireSTE elMaestro = new GestionnaireSTE();
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

        private void ValiderDonationClick(object sender, EventArgs e)
        {
            //====================CHARGEMENT VARIABLE DONATION=============================
            if (validationDonDon())
            {
                string nom = txtb_dona_nom.Text;
                string prenom = txtb_dona_prenom.Text;
                string email = txtb_dona_email.Text;
                string telephone = txtb_dona_phone.Text;
                string carte = txtb_dona_carte.Text;
                char type_carte = typeCarte();
                string date_expiration = dtp_expiration.Text;


                Donateur tampon = new Donateur(nom, prenom, email, telephone, type_carte, carte, date_expiration);
                elMaestro.ajouterDonateur(tampon);
                //====================CHARGEMENT VARIABLE DON==================================
                string don_date = dtp_don_date.Text;
                double montant = montantDon();
                //=============================================================================
                Don tamdon = new Don(don_date, tampon.getId(), montant);
                elMaestro.ajouterDon(tamdon);

                DialogResult succes = MessageBox.Show("Le donateur ainsi que son don on été ajouté",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (succes == DialogResult.OK) tabc_page_princ.SelectedIndex = 4;
            }
            else
                MessageBox.Show("batard");
        }
        private char typeCarte()
        {
            if (rdb_mc.Checked) return 'M';
            else if (rdb_amex.Checked) return 'A';
            else return 'V';
        }
        private double montantDon()
        {
            double tampon;
            string stringpon = txtb_don_montant.Text;
            tampon=double.Parse(stringpon);
            return tampon;
        }
        private bool validationDonDon() //Validation pour donateur && don
        {        
            if (txtb_dona_nom.Text.Equals(string.Empty))             
            {
                MessageBox.Show("Veuillez entrer le nom du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_nom.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 0;
                return false;
            }

            if (txtb_dona_prenom.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez entrer le prénom du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_prenom.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 0;
                return false;
            }
            if (!txtb_dona_email.Text.Equals(string.Empty))
            {
                Regex monExpression = new Regex(@"^([\w]+)\@([\D]+)\.([\D]+)$");
                if (!monExpression.IsMatch(txtb_dona_email.Text))
                {
                    MessageBox.Show("Adresse email invalide", "INVALIDE", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtb_dona_email.BackColor = System.Drawing.Color.BlueViolet;
                    tabc_page_princ.SelectedIndex = 0;
                    return false;
                }
            }
            if (txtb_dona_phone.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez entrer le numéro de téléphone du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_phone.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 0;
                return false;
            }
            if (txtb_dona_carte.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez entrer le numéro de carte du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_carte.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 1;
                return false;
            } 
            if (dtp_expiration.Value.Date<DateTime.Now.Date)
            {
                MessageBox.Show("La carte entré est expiré", "Carte Expiré", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dtp_expiration.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 1;
                return false;
            }
            if (dtp_expiration.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez entrer une date valide", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dtp_expiration.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 1;
                return false;
            }
            if (rdb_amex.Checked == false && rdb_mc.Checked == false && rdb_visa.Checked == false)
            {
                MessageBox.Show("Veuillez sélectionner le type de carte ", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                grb_info_credit.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 1;
                return false;
            }
            if (!double.TryParse(txtb_don_montant.Text, out double en))
            {
                MessageBox.Show("Assurez vous d'entrer un montant valide ", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_don_montant.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 2;
                return false;
            }
            if (dtp_don_date.Text.Equals(string.Empty)|| dtp_don_date.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Veuillez entrer une date valide", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dtp_don_date.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 2;
                return false;
            }
            return true;
            
        }
    }
}
