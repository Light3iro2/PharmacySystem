using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_system
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonShowPharmacies_Click(object sender, EventArgs e)
        {
            FormPharmacies frm = new FormPharmacies();
            frm.Show();
        }

        private void buttonShowMedicines_Click(object sender, EventArgs e)
        {
            FormMedicines frm = new FormMedicines();
            frm.Show();
        }

        private void buttonShowAvailable_Click(object sender, EventArgs e)
        {
            FormAvailability frm = new FormAvailability();
            frm.Show();
        }
    }
}
