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
    public partial class donateurTwo : Form
    {
        public donateurTwo()
        {
            InitializeComponent();
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

        private void grb_info_credit_Enter(object sender, EventArgs e)
        {

        }
    }
}
