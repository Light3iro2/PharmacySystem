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
    public partial class FormPharmacies : Form
    {
        public FormPharmacies()
        {
            InitializeComponent();
            ShowPharmacies();
        }
        int idaptek;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Pharmacies p = new Pharmacies();
                p.Name = textBoxNamePharmacies.Text;
                p.Address = textBoxAddress.Text;
                p.Phone = textBoxPhone.Text;
                p.Mail = textBoxMail.Text;
                Program.pharmaciesDb.Pharmacies.Add(p);
                Program.pharmaciesDb.SaveChanges();
                EmptyField();
                ShowPharmacies();
            }
            catch { MessageBox.Show("Невозможно добавить информацию об аптеке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewShowPharmacies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewShowPharmacies.SelectedItems.Count == 1)
            {
                Pharmacies p = listViewShowPharmacies.SelectedItems[0].Tag as Pharmacies;
                idaptek = p.Id;
                textBoxNamePharmacies.Text = p.Name;
                textBoxAddress.Text = p.Address;
                textBoxPhone.Text = p.Phone;
                textBoxMail.Text = p.Mail;
                labelListAvailability.Visible = true;
                comboBoxListAvailability.Visible = true;
                labelQuantity.Visible = true;
                textBoxQuantity.Visible = true;
                ShowAvailability();
                textBoxQuantity.Text = p.Availability.Count.ToString();
            }
            else
            {
                labelListAvailability.Visible = false;
                comboBoxListAvailability.Visible = false;
                labelQuantity.Visible = false;
                textBoxQuantity.Visible = false;
                EmptyField();
            }
        }
        private void EmptyField()
        {
            textBoxAddress.Text = "";
            textBoxMail.Text = "";
            textBoxPhone.Text = "";
            textBoxNamePharmacies.Text = "";
            textBoxQuantity.Text = "";
            comboBoxListAvailability.SelectedItem = null;
            idaptek = 0;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewShowPharmacies.SelectedItems.Count == 1)
            {
                Pharmacies p = listViewShowPharmacies.SelectedItems[0].Tag as Pharmacies;
                p.Name = textBoxNamePharmacies.Text;
                p.Address = textBoxAddress.Text;
                p.Phone = textBoxPhone.Text;
                p.Mail = textBoxMail.Text;
                Program.pharmaciesDb.SaveChanges();
                EmptyField();
                ShowPharmacies();
            }
            else
            {
            
            }
        }
        void ShowPharmacies()
        {
            listViewShowPharmacies.Items.Clear();
            foreach (Pharmacies p in Program.pharmaciesDb.Pharmacies)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        p.Id.ToString(), p.Name, p.Address, p.Phone, p.Mail
                    });
                item.Tag = p;
                listViewShowPharmacies.Items.Add(item);
            }
            listViewShowPharmacies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewShowPharmacies.SelectedItems.Count == 1)
                {
                    Pharmacies p = listViewShowPharmacies.SelectedItems[0].Tag as Pharmacies;
                    Program.pharmaciesDb.Pharmacies.Remove(p);
                    Program.pharmaciesDb.SaveChanges();
                    ShowPharmacies();
                    EmptyField();
                }
                else
                {
                    EmptyField();
                }
            }
            catch { MessageBox.Show("Невозможно удалить данные о аптеке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void ShowAvailability()
        {
            comboBoxListAvailability.Items.Clear();
            foreach (Availability a in Program.pharmaciesDb.Availability)
            {
                if (a.Id_Pharmacies == idaptek)
                {
                    string[] item = { a.Medicines.FormRelease + ", " + a.Medicines.Name + ". Производитель: " + a.Medicines.Maker };
                    comboBoxListAvailability.Items.Add(string.Join(" ", item));
                }
            }
        }
    }
}
