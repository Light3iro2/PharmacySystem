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
    public partial class FormMedicines : Form
    {
        public FormMedicines()
        {
            InitializeComponent();
            ShowMedicines();
            EmptyField();
        }
        private void EmptyField()
        {
            textBoxName.Text = "";
            textBoxCompanyRelease.Text = "";
            textBoxDose.Text = "";
            textBoxDateRelease.Text = "";
            comboBoxForm.SelectedItem = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Medicines m = new Medicines();
                m.Name = textBoxName.Text;
                m.FormRelease = comboBoxForm.Text;
                m.Dosage = textBoxDose.Text;
                m.Maker = textBoxCompanyRelease.Text;
                m.DateRelease = textBoxDateRelease.Text;
                Program.pharmaciesDb.Medicines.Add(m);
                Program.pharmaciesDb.SaveChanges();
                EmptyField();
                ShowMedicines();
            }
            catch { }
        }
        void ShowMedicines()
        {
            listViewShowMedicines.Items.Clear();
            foreach (Medicines m in Program.pharmaciesDb.Medicines)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        m.Id.ToString(), m.Name, m.FormRelease, m.Dosage, m.Maker, m.DateRelease
                    });
                item.Tag = m;
                listViewShowMedicines.Items.Add(item);
            }
            listViewShowMedicines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewShowMedicines.SelectedItems.Count == 1)
            {
                Medicines m = listViewShowMedicines.SelectedItems[0].Tag as Medicines;
                m.Name = textBoxName.Text;
                m.FormRelease = comboBoxForm.Text;
                m.Dosage = textBoxDose.Text;
                m.Maker = textBoxCompanyRelease.Text;
                m.DateRelease = textBoxDateRelease.Text;
                Program.pharmaciesDb.SaveChanges();
                EmptyField();
                ShowMedicines();
            }
            else
            {

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewShowMedicines.SelectedItems.Count == 1)
                {
                    Medicines m = listViewShowMedicines.SelectedItems[0].Tag as Medicines;
                    Program.pharmaciesDb.Medicines.Remove(m);
                    Program.pharmaciesDb.SaveChanges();
                    ShowMedicines();
                    EmptyField();
                }
                else
                {
                    EmptyField();
                }
            }
            catch { MessageBox.Show("Невозможно удалить данные о лекарстве", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewShowMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewShowMedicines.SelectedItems.Count == 1)
            {
                Medicines m = listViewShowMedicines.SelectedItems[0].Tag as Medicines;
                textBoxName.Text = m.Name;
                if (m.FormRelease == "Таблетки")
                {
                    comboBoxForm.SelectedIndex = 0;
                }
                else if (m.FormRelease == "Капсулы")
                {
                    comboBoxForm.SelectedIndex = 1;
                }
                else if (m.FormRelease == "Ампулы")
                {
                    comboBoxForm.SelectedIndex = 2;
                }
                else if (m.FormRelease == "Сироп")
                {
                    comboBoxForm.SelectedIndex = 3;
                }
                else if (m.FormRelease == "Крем")
                {
                    comboBoxForm.SelectedIndex = 4;
                }
                textBoxDose.Text = m.Dosage;
                textBoxCompanyRelease.Text = m.Maker;
                textBoxDateRelease.Text = m.DateRelease;
            }
            else
            {
                EmptyField();
            }
        }
    }
}
