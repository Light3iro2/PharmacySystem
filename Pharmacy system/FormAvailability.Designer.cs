namespace Pharmacy_system
{
    partial class FormAvailability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxShowPharmacies = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewShowAvailability = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelShowPharmacies = new System.Windows.Forms.Label();
            this.labelShowMedicines = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxShowMedicines = new System.Windows.Forms.ComboBox();
            this.labelLogoNameCompany = new System.Windows.Forms.Label();
            this.pictureBoxLogoCompany = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxShowPharmacies
            // 
            this.comboBoxShowPharmacies.BackColor = System.Drawing.Color.Honeydew;
            this.comboBoxShowPharmacies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShowPharmacies.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboBoxShowPharmacies.FormattingEnabled = true;
            this.comboBoxShowPharmacies.IntegralHeight = false;
            this.comboBoxShowPharmacies.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxShowPharmacies.Location = new System.Drawing.Point(12, 189);
            this.comboBoxShowPharmacies.Name = "comboBoxShowPharmacies";
            this.comboBoxShowPharmacies.Size = new System.Drawing.Size(219, 23);
            this.comboBoxShowPharmacies.TabIndex = 45;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Honeydew;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(563, 311);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(137, 32);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Honeydew;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(420, 311);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(137, 32);
            this.buttonEdit.TabIndex = 43;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Honeydew;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(277, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 32);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewShowAvailability
            // 
            this.listViewShowAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.listViewShowAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewShowAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewShowAvailability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewShowAvailability.FullRowSelect = true;
            this.listViewShowAvailability.GridLines = true;
            this.listViewShowAvailability.HideSelection = false;
            this.listViewShowAvailability.Location = new System.Drawing.Point(242, 124);
            this.listViewShowAvailability.MultiSelect = false;
            this.listViewShowAvailability.Name = "listViewShowAvailability";
            this.listViewShowAvailability.Size = new System.Drawing.Size(460, 181);
            this.listViewShowAvailability.TabIndex = 41;
            this.listViewShowAvailability.UseCompatibleStateImageBehavior = false;
            this.listViewShowAvailability.View = System.Windows.Forms.View.Details;
            this.listViewShowAvailability.SelectedIndexChanged += new System.EventHandler(this.listViewShowAvailability_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Лекарство";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Аптека";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelPrice.Location = new System.Drawing.Point(8, 260);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 21);
            this.labelPrice.TabIndex = 38;
            this.labelPrice.Text = "Цена:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelQuantity.Location = new System.Drawing.Point(8, 213);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(98, 21);
            this.labelQuantity.TabIndex = 37;
            this.labelQuantity.Text = "Количество:";
            // 
            // labelShowPharmacies
            // 
            this.labelShowPharmacies.AutoSize = true;
            this.labelShowPharmacies.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelShowPharmacies.Location = new System.Drawing.Point(8, 168);
            this.labelShowPharmacies.Name = "labelShowPharmacies";
            this.labelShowPharmacies.Size = new System.Drawing.Size(65, 21);
            this.labelShowPharmacies.TabIndex = 36;
            this.labelShowPharmacies.Text = "Аптека:";
            // 
            // labelShowMedicines
            // 
            this.labelShowMedicines.AutoSize = true;
            this.labelShowMedicines.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelShowMedicines.Location = new System.Drawing.Point(8, 118);
            this.labelShowMedicines.Name = "labelShowMedicines";
            this.labelShowMedicines.Size = new System.Drawing.Size(89, 21);
            this.labelShowMedicines.TabIndex = 35;
            this.labelShowMedicines.Text = "Лекарство:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxPrice.Location = new System.Drawing.Point(12, 281);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(219, 24);
            this.textBoxPrice.TabIndex = 34;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxQuantity.Location = new System.Drawing.Point(12, 235);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(219, 24);
            this.textBoxQuantity.TabIndex = 33;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // comboBoxShowMedicines
            // 
            this.comboBoxShowMedicines.BackColor = System.Drawing.Color.Honeydew;
            this.comboBoxShowMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShowMedicines.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboBoxShowMedicines.FormattingEnabled = true;
            this.comboBoxShowMedicines.IntegralHeight = false;
            this.comboBoxShowMedicines.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxShowMedicines.Location = new System.Drawing.Point(12, 140);
            this.comboBoxShowMedicines.Name = "comboBoxShowMedicines";
            this.comboBoxShowMedicines.Size = new System.Drawing.Size(219, 23);
            this.comboBoxShowMedicines.TabIndex = 48;
            // 
            // labelLogoNameCompany
            // 
            this.labelLogoNameCompany.AutoSize = true;
            this.labelLogoNameCompany.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.labelLogoNameCompany.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelLogoNameCompany.Location = new System.Drawing.Point(276, 80);
            this.labelLogoNameCompany.Name = "labelLogoNameCompany";
            this.labelLogoNameCompany.Size = new System.Drawing.Size(184, 31);
            this.labelLogoNameCompany.TabIndex = 50;
            this.labelLogoNameCompany.Text = "Сеть аптек 24/7";
            // 
            // pictureBoxLogoCompany
            // 
            this.pictureBoxLogoCompany.Image = global::Pharmacy_system.Properties.Resources._5dab0406572aa;
            this.pictureBoxLogoCompany.Location = new System.Drawing.Point(323, 5);
            this.pictureBoxLogoCompany.Name = "pictureBoxLogoCompany";
            this.pictureBoxLogoCompany.Size = new System.Drawing.Size(88, 72);
            this.pictureBoxLogoCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoCompany.TabIndex = 49;
            this.pictureBoxLogoCompany.TabStop = false;
            // 
            // FormAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(712, 356);
            this.Controls.Add(this.labelLogoNameCompany);
            this.Controls.Add(this.pictureBoxLogoCompany);
            this.Controls.Add(this.comboBoxShowMedicines);
            this.Controls.Add(this.comboBoxShowPharmacies);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewShowAvailability);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelShowPharmacies);
            this.Controls.Add(this.labelShowMedicines);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Name = "FormAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие лекарств";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxShowPharmacies;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewShowAvailability;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelShowPharmacies;
        private System.Windows.Forms.Label labelShowMedicines;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxShowMedicines;
        private System.Windows.Forms.Label labelLogoNameCompany;
        private System.Windows.Forms.PictureBox pictureBoxLogoCompany;
    }
}