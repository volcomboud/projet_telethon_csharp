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
            if (yesno == DialogResult.Yes) this.Close();
        }
        private void affichePrincipale()
        {
            pagePrincipale page_principal = new pagePrincipale();
            page_principal.Region = this.Region;
            page_principal.Show();
            this.Hide();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            affichePrincipale();
        }
    }
}
