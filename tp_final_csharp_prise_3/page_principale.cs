using biblioDonationSys;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace tp_final_csharp_prise_3
{
    public partial class pagePrincipale : Form
    {
        private GestionnaireSTE elMaestro = new GestionnaireSTE();
        private int index_don = 0; //utiliser pour l<ajout dans les datagrid
        private int index_prix = 0;//idem pour le prix

        public pagePrincipale()
        {
            InitializeComponent();
            cacherTabs();
            gestionnaireId(); //SETID
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
            this.Close();
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
            //  chargementGridDon();
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

        private void validerSponsorPrixClick(object sender, EventArgs e)
        {
            if (validationSponsorPrix())
            {
                string nom = txtb_sponsor_nom.Text;
                string prenom = txtb_sponsor_prenom.Text;

                Commanditaire tampon = new Commanditaire(nom, prenom);
                elMaestro.ajouterSponsor(tampon);

                string description = txtb_prix_desc.Text;
                double valeur = conversionValeur();
                int qte = conversionQte();

                Prix prixpon = new Prix(description, valeur, qte, tampon);
                elMaestro.ajouterPrix(prixpon);
                ajoutGridSponsor();

                DialogResult succes = MessageBox.Show("Le commanditaire ainsi que son prix on été ajouté",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (succes == DialogResult.OK)
                {
                    tabc_page_princ.SelectedIndex = 4;
                    reinitialiser();
                }
            }
        }

        private void ajoutGridPrix()
        {
            List<Don> list = elMaestro.getDon();
            int point = conversionPoints(list[index_don].getMontant());
            string cadeau = calculateurPoint(point);
            dgv_cadeau.Rows.Add(list[index_don].getDonateur().getNom(), list[index_don].getDonateur().getPrenom(),
            point, cadeau, list[index_don].getDate());
        }

        private void ajoutGridSponsor()
        {
            List<Prix> list = elMaestro.getPrix();
            dgv_prix_sponsor.Rows.Add(list[index_prix].getSponsed().getNom(), list[index_prix].getSponsed().getPrenom(),
                        list[index_prix].getValeur(), list[index_prix].getQte(), list[index_prix].getDesc());
        }

        private void ajoutGridDon()
        {
            List<Don> list = elMaestro.getDon();
            dgv_donateur_don.Rows.Add(list[index_don].getDonateur().getNom(), list[index_don].getDonateur().getPrenom(),
                        list[index_don].getMontant(), list[index_don].getDate(), list[index_don].getId(), list[index_don].getDonateur().getType());
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
                double montant = conversionDon();
                //=============================================================================
                Don tamdon = new Don(don_date, tampon, montant);
                elMaestro.ajouterDon(tamdon);
                ajoutGridDon();
                ajoutGridPrix();
                index_don++;

                DialogResult succes = MessageBox.Show("Le donateur ainsi que son don on été ajouté",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (succes == DialogResult.OK)
                {
                    tabc_page_princ.SelectedIndex = 4;
                    reinitialiser();
                }
            }
        }

        private char typeCarte()
        {
            if (rdb_mc.Checked) return 'M';
            else if (rdb_amex.Checked) return 'A';
            else return 'V';
        }

        private double conversionValeur()
        {
            double tampon;
            string stringpon = txtb_prix_valeur.Text;
            tampon = double.Parse(stringpon);
            return tampon;
        }

        private int conversionQte()
        {
            int tampon;
            string stringpon = txtb_prix_qte.Text;
            tampon = int.Parse(stringpon);
            return tampon;
        }

        private double conversionDon()
        {
            double tampon;
            string stringpon = txtb_don_montant.Text;
            tampon = double.Parse(stringpon);
            return tampon;
        }

        private bool validationDonDon() //Validation pour donateur && don
        {
            Regex format_alpha = new Regex("^([\\D]+)$");
            Regex format_digi = new Regex("^([\\d]+)$");


            if (txtb_dona_nom.Text.Equals(string.Empty)|| !format_alpha.IsMatch(txtb_dona_nom.Text))
            {
                MessageBox.Show("Veuillez entrer le nom du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_nom.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 0;
                return false;
            }

            if (txtb_dona_prenom.Text.Equals(string.Empty) || !format_alpha.IsMatch(txtb_dona_prenom.Text))
            {
                MessageBox.Show("Veuillez entrer le prénom du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_prenom.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 0;
                return false;
            }
            if (!txtb_dona_email.Text.Equals(string.Empty))
            {
                Regex email_format = new Regex(@"^([\w]+)\@([\D]+)\.([\D]+)$");
                if (!email_format.IsMatch(txtb_dona_email.Text))
                {
                    MessageBox.Show("Adresse email invalide", "INVALIDE", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtb_dona_email.BackColor = System.Drawing.Color.BlueViolet;
                    tabc_page_princ.SelectedIndex = 0;
                    return false;
                }
            }
            if (txtb_dona_phone.Text.Equals(string.Empty)|| !format_digi.IsMatch(txtb_dona_phone.Text))
            {
                MessageBox.Show("Veuillez entrer le numéro de téléphone du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_phone.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 0;
                return false;
            }
            if (txtb_dona_carte.Text.Equals(string.Empty) || !format_digi.IsMatch(txtb_dona_carte.Text))
            {
                MessageBox.Show("Veuillez entrer le numéro de carte du donateur", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_dona_carte.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 1;
                return false;
            }
            if (dtp_expiration.Value.Date < DateTime.Now.Date)
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
            if (dtp_don_date.Text.Equals(string.Empty) || dtp_don_date.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Veuillez entrer une date valide", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dtp_don_date.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 2;
                return false;
            }
            return true;
        }

        private bool validationSponsorPrix()
        {
            Regex format_alpha = new Regex("^([\\D]+)$");            

            if (txtb_sponsor_nom.Text.Equals(string.Empty) || !format_alpha.IsMatch(txtb_sponsor_nom.Text))
            {
                MessageBox.Show("Veuillez entrer le nom du commanditaire", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_sponsor_nom.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 3;
                return false;
            }
            if (txtb_sponsor_prenom.Text.Equals(string.Empty) || !format_alpha.IsMatch(txtb_sponsor_prenom.Text))
            {
                MessageBox.Show("Veuillez entrer le prénom du commanditaire", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_sponsor_prenom.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 3;
                return false;
            }
            if (txtb_prix_desc.Text.Equals(string.Empty))
            {
                MessageBox.Show("Veuillez entrer une description", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_prix_desc.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 5;
                return false;
            }
            if (!double.TryParse(txtb_prix_valeur.Text, out double en) || txtb_prix_valeur.Text.Equals(string.Empty))
            {
                MessageBox.Show("Assurez vous d'entrer une valeur valide ", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_prix_valeur.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 5;
                return false;
            }
            if (!int.TryParse(txtb_prix_qte.Text, out int an) || txtb_prix_qte.Text.Equals(string.Empty))
            {
                MessageBox.Show("Assurez vous d'entrer une quantité valide ", "Champs manquant", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_prix_qte.BackColor = System.Drawing.Color.BlueViolet;
                tabc_page_princ.SelectedIndex = 5;
                return false;
            }
            return true;
        }

        private void reinitialiser()
        {
            gestionnaireId();
            txtb_dona_phone.Text = (string.Empty);
            txtb_dona_email.Text = (string.Empty);
            txtb_dona_carte.Text = (string.Empty);
            txtb_dona_nom.Text = (string.Empty);
            txtb_dona_prenom.Text = (string.Empty);
            txtb_don_montant.Text = (string.Empty);
            txtb_prix_desc.Text = (string.Empty);
            txtb_prix_qte.Text = (string.Empty);
            txtb_prix_valeur.Text = (string.Empty);
            txtb_sponsor_nom.Text = (string.Empty);
            txtb_sponsor_prenom.Text = (string.Empty);
            dtp_don_date.Text = (string.Empty);
            dtp_expiration.Text = (string.Empty);
        }

        private void gestionnaireId()
        {
            int index = (elMaestro.getSponsor().Count) - 1;

            if (!elMaestro.getSponsor().Any()) cmbb_sponsor_id.Text = "# 155";
            else cmbb_sponsor_id.Text = "#" + elMaestro.getSponsor()[index].getId().ToString();

            index = (elMaestro.getDonateur().Count) - 1;
            if (!elMaestro.getDonateur().Any()) cmbb_dona_id.Text = "# 10001";
            else cmbb_dona_id.Text = "#" + elMaestro.getDonateur()[index].getId().ToString();

            index = (elMaestro.getDon().Count) - 1;
            if (!elMaestro.getDon().Any()) cmbb_don_id.Text = "# 1";
            else cmbb_don_id.Text = "#" + elMaestro.getDon()[index].getId().ToString();
        }

        private void txtb_dona_email_TextChanged(object sender, EventArgs e)
        {
            txtb_dona_email.BackColor = System.Drawing.Color.White;
        }

        private void txtb_dona_prenom_TextChanged(object sender, EventArgs e)
        {
            txtb_dona_prenom.BackColor = System.Drawing.Color.White;
        }

        private void txtb_dona_nom_TextChanged(object sender, EventArgs e)
        {
            txtb_dona_nom.BackColor = System.Drawing.Color.White;
        }

        private void txtb_dona_nom_TextChanged1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtb_dona_phone_TextChanged(object sender, EventArgs e)
        {
            txtb_dona_phone.BackColor = System.Drawing.Color.White;
        }

        private void txtb_dona_carte_TextChanged(object sender, EventArgs e)
        {
            txtb_dona_carte.BackColor = System.Drawing.Color.White;
        }

        private void dtp_expiration_ValueChanged(object sender, EventArgs e)
        {
            dtp_expiration.BackColor = System.Drawing.Color.White;
        }

        private void rdb_mc_CheckedChanged(object sender, EventArgs e)
        {
            grb_info_credit.BackColor = System.Drawing.Color.Aqua;
        }

        private void rdb_visa_CheckedChanged(object sender, EventArgs e)
        {
            grb_info_credit.BackColor = System.Drawing.Color.Aqua;
        }

        private void rdb_amex_CheckedChanged(object sender, EventArgs e)
        {
            grb_info_credit.BackColor = System.Drawing.Color.Aqua;
        }

        private void dtp_don_date_ValueChanged(object sender, EventArgs e)
        {
            dtp_don_date.BackColor = System.Drawing.Color.White;
        }

        private void txtb_don_montant_TextChanged(object sender, EventArgs e)
        {
            txtb_don_montant.BackColor = System.Drawing.Color.White;
            int point = conversionPoints();
            txtb_don_point.Text = point.ToString();
            calculateurPoint();
        }

        private String calculateurPoint(int point)
        {
            if (point < 10 && point > 0) point = 1;
            if (point > 9 && point < 15) point = 10;
            if (point > 14 && point < 20) point = 15;
            switch (point)
            {
                case 0:
                    return "";

                case 1:
                    return "Calendrier";

                case 10:
                    return "Repas pour 2";

                case 15:
                    return "Barbecue";

                default:
                    return "Télévision";
            }
        }

        private void calculateurPoint()
        {
            if (int.TryParse(txtb_don_point.Text, out int b))
            {
                int point = int.Parse(txtb_don_point.Text);

                if (point < 10 && point > 0) point = 1;
                if (point > 9 && point < 15) point = 10;
                if (point > 14 && point < 20) point = 15;
                switch (point)
                {
                    case 0:
                        lbl_dona_prix.Text = "";
                        picb_dona_prix.Image = null;
                        break;

                    case 1:
                        lbl_dona_prix.Text = "Calendrier";
                        picb_dona_prix.Image = Properties.Resources.calendar;
                        break;

                    case 10:
                        lbl_dona_prix.Text = "Repas pour 2";
                        picb_dona_prix.Image = Properties.Resources.meal;
                        break;

                    case 15:
                        lbl_dona_prix.Text = "Barbecue";
                        picb_dona_prix.Image = Properties.Resources.grill;
                        break;

                    default:
                        lbl_dona_prix.Text = "Télévision";
                        picb_dona_prix.Image = Properties.Resources.television;
                        break;
                }
            }
        }

        private int conversionPoints()
        {
            int points = 0;
            double montant;

            if (double.TryParse(txtb_don_montant.Text, out double b))
            {
                montant = double.Parse(txtb_don_montant.Text);

                if (montant >= 500)
                {
                    montant -= 500;
                    points += 5;
                    while (montant >= 500)
                    {
                        montant -= 500;
                        points += 4;
                    }
                }
                if (montant >= 350 && montant <= 499)
                {
                    points += 3;
                }
                else if (montant >= 200 && montant <= 349)
                {
                    points += 2;
                }
                else if (montant >= 50 && montant <= 199)
                {
                    points += 1;
                }
            }
            return points;
        }

        private int conversionPoints(double montant)
        {
            int points = 0;

            if (montant >= 500)
            {
                montant -= 500;
                points += 5;
                while (montant >= 500)
                {
                    montant -= 500;
                    points += 4;
                }
            }
            if (montant >= 350 && montant <= 499)
            {
                points += 3;
            }
            else if (montant >= 200 && montant <= 349)
            {
                points += 2;
            }
            else if (montant >= 50 && montant <= 199)
            {
                points += 1;
            }
            return points;
        }

        private void txtb_sponsor_nom_TextChanged(object sender, EventArgs e)
        {
            txtb_sponsor_nom.BackColor = System.Drawing.Color.White;
        }

        private void txtb_sponsor_prenom_TextChanged(object sender, EventArgs e)
        {
            txtb_sponsor_prenom.BackColor = System.Drawing.Color.White;
        }

        private void txtb_prix_desc_TextChanged(object sender, EventArgs e)
        {
            txtb_prix_desc.BackColor = System.Drawing.Color.White;
        }

        private void txtb_prix_valeur_TextChanged(object sender, EventArgs e)
        {
            txtb_prix_valeur.BackColor = System.Drawing.Color.White;
        }

        private void txtb_prix_qte_TextChanged(object sender, EventArgs e)
        {
            txtb_prix_qte.BackColor = System.Drawing.Color.White;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculateurPoint();
        }

        private void lectureDon()
        {
            TextReader le_scribe = new StreamReader("bd_donation.txt");
            string ligne = "";
            while ((ligne = le_scribe.ReadLine()) != null)
            {
                string[] dgv_rows = ligne.Split('/');
                dgv_donateur_don.Rows.Add(dgv_rows);
            }
            le_scribe.Close();
        }

        private void picb_info_Click(object sender, EventArgs e)
        {
            presentation presentation_intro = new presentation();
            presentation_intro.Show();
        }
    }
}