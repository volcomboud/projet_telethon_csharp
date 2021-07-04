using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace tp_final_csharp_prise_3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }
        private void picb_exit_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Voulez vous quitter le service de donations?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes) Application.Exit();
        }
        private void affichePrincipale()
        {
            pagePrincipale page_principal = new pagePrincipale();
            presentation presentation_intro = new presentation();
            page_principal.Region = this.Region;
            page_principal.Show(); 
            this.Hide();
            presentation_intro.Show();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {

            if (verificationCredential()) affichePrincipale();
            else
            {
                DialogResult succes = MessageBox.Show("Mot de passe ou nom d'utilisateur érronée",
                                "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (succes == DialogResult.OK)
                {
                    txtb_login.Text = string.Empty;
                    txtb_pass.Text = string.Empty;
                }
            }
        }
        private bool verificationCredential()
        {
            //string user = "téléthon 2021";
            //string pass = "Don@2021";
            string user = "";
            string pass = "";
            if (txtb_login.Text == user && txtb_pass.Text == pass) return true;
            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
