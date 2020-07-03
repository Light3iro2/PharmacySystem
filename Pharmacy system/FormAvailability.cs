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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowMedicines();
            ShowPharmacies();
            ShowAvailability();
            comboBoxShowMedicines.KeyPress += (sender, e) => e.Handled = true;
            comboBoxShowPharmacies.KeyPress += (sender, e) => e.Handled = true;
        }
        private void ShowMedicines()
        {
            comboBoxShowMedicines.Items.Clear();
            foreach(Medicines m in Program.pharmaciesDb.Medicines)
            {
                string[] item = { m.Id.ToString() + ".", m.FormRelease, m.Name, m.Dosage };
                comboBoxShowMedicines.Items.Add(string.Join(" ", item));
            }
        }
        private void ShowPharmacies()
        {
            comboBoxShowPharmacies.Items.Clear();
            foreach (Pharmacies p in Program.pharmaciesDb.Pharmacies)
            {
                string[] item = { p.Id.ToString() + ".", p.Name, p.Address, p.Phone };
                comboBoxShowPharmacies.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckField())
            {
                Availability a = new Availability();
                a.Id_Medicines = Convert.ToInt32(comboBoxShowMedicines.SelectedItem.ToString().Split('.')[0]);
                a.Id_Pharmacies = Convert.ToInt32(comboBoxShowPharmacies.SelectedItem.ToString().Split('.')[0]);
                a.Price = Convert.ToDouble(textBoxPrice.Text);
                a.Quantity = Convert.ToDouble(textBoxQuantity.Text);
                Program.pharmaciesDb.Availability.Add(a);
                Program.pharmaciesDb.SaveChanges();
                ClearField();
                ShowAvailability();
            }
            else { }
        }
        public bool CheckField()
        {
            if (comboBoxShowMedicines.SelectedItem != null && comboBoxShowPharmacies.SelectedItem != null && textBoxPrice.Text != "" && textBoxQuantity.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Заполните обязательно все поля");
                return false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewShowAvailability.SelectedItems.Count == 1)
            {
                Availability a = listViewShowAvailability.SelectedItems[0].Tag as Availability;
                a.Id_Medicines = Convert.ToInt32(comboBoxShowMedicines.SelectedItem.ToString().Split('.')[0]);
                a.Id_Pharmacies = Convert.ToInt32(comboBoxShowPharmacies.SelectedItem.ToString().Split('.')[0]);
                a.Price = Convert.ToDouble(textBoxPrice.Text);
                a.Quantity = Convert.ToDouble(textBoxQuantity.Text);
                Program.pharmaciesDb.SaveChanges();
                ClearField();
                ShowAvailability();
            }
            else
            {
                MessageBox.Show("Выберите товар, для изменения информации о нём");
            }
        }

        private void listViewShowAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewShowAvailability.SelectedItems.Count == 1)
            {
                Availability a = listViewShowAvailability.SelectedItems[0].Tag as Availability;
                comboBoxShowMedicines.SelectedIndex = comboBoxShowMedicines.FindString(a.Id_Medicines.ToString());
                comboBoxShowPharmacies.SelectedIndex = comboBoxShowPharmacies.FindString(a.Id_Pharmacies.ToString());
                textBoxPrice.Text = a.Price.ToString();
                textBoxQuantity.Text = a.Quantity.ToString();
            }
            else
            {
                ClearField();
            }
        }
        private void ClearField()
        {
            comboBoxShowPharmacies.SelectedItem = null;
            comboBoxShowMedicines.SelectedItem = null;
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
        }
        void ShowAvailability()
        {
            listViewShowAvailability.Items.Clear();
            foreach (Availability a in Program.pharmaciesDb.Availability)
            {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        a.Id.ToString(),
                        a.Medicines.FormRelease + ", " + a.Medicines.Name + ". Производитель: " + a.Medicines.Maker, 
                        a.Pharmacies.Name + ", " + a.Pharmacies.Address + ". Телефон: " + a.Pharmacies.Phone,
                        a.Quantity.ToString(),
                        a.Price.ToString()
                    });
                item.Tag = a;
                listViewShowAvailability.Items.Add(item);
            }
            listViewShowAvailability.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (listViewShowAvailability.SelectedItems.Count == 1)
                {
                    Availability a = listViewShowAvailability.SelectedItems[0].Tag as Availability;
                    Program.pharmaciesDb.Availability.Remove(a);
                    Program.pharmaciesDb.SaveChanges();
                    ShowAvailability();
                    ClearField();
                }
                else
                {
                    ClearField();
                }
            }
            catch { MessageBox.Show("Данный товар невозможно удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
