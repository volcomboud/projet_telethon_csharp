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
        Control ctrl;
        public pagePrincipale()
        {
            InitializeComponent();
            cacherTabs();
        }

        private void picb_exit_Click(object sender, EventArgs e)
        {
                DialogResult yesno = MessageBox.Show("Voulez vous quitter le service de donations?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesno == DialogResult.Yes) this.Close();            
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            login page_connection = new login();
            page_connection.Region = this.Region;
            page_connection.Show();
            this.Hide();
        }

        private void btn_ajout_donateur_Click(object sender, EventArgs e)
        {
            tabc_page_princ.SelectedIndex = 0;
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
    }
}
