using System;
using System.Windows.Forms;

namespace nosClasses
{
    public class nosClasses
    {
        public bool quitter()
        {
            DialogResult yesno = MessageBox.Show("Voulez vous quitter le service de donations?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes) return true;
            return false;
        }
    }
}
