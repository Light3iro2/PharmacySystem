namespace Pharmacy_system
{
    partial class FormMedicines
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewShowMedicines = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCompanyRelease = new System.Windows.Forms.Label();
            this.labelDose = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCompanyRelease = new System.Windows.Forms.TextBox();
            this.textBoxDose = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.labelDateRelease = new System.Windows.Forms.Label();
            this.textBoxDateRelease = new System.Windows.Forms.TextBox();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Honeydew;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(565, 371);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(137, 32);
            this.buttonDelete.TabIndex = 28;
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
            this.buttonEdit.Location = new System.Drawing.Point(422, 371);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(137, 32);
            this.buttonEdit.TabIndex = 27;
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
            this.buttonAdd.Location = new System.Drawing.Point(280, 371);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 32);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewShowMedicines
            // 
            this.listViewShowMedicines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.listViewShowMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewShowMedicines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewShowMedicines.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewShowMedicines.FullRowSelect = true;
            this.listViewShowMedicines.GridLines = true;
            this.listViewShowMedicines.HideSelection = false;
            this.listViewShowMedicines.Location = new System.Drawing.Point(262, 129);
            this.listViewShowMedicines.MultiSelect = false;
            this.listViewShowMedicines.Name = "listViewShowMedicines";
            this.listViewShowMedicines.Size = new System.Drawing.Size(440, 236);
            this.listViewShowMedicines.TabIndex = 25;
            this.listViewShowMedicines.UseCompatibleStateImageBehavior = false;
            this.listViewShowMedicines.View = System.Windows.Forms.View.Details;
            this.listViewShowMedicines.SelectedIndexChanged += new System.EventHandler(this.listViewShowMedicines_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Форма лекарства";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Доза";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Производитель";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата изготовления";
            // 
            // labelCompanyRelease
            // 
            this.labelCompanyRelease.AutoSize = true;
            this.labelCompanyRelease.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelCompanyRelease.Location = new System.Drawing.Point(10, 274);
            this.labelCompanyRelease.Name = "labelCompanyRelease";
            this.labelCompanyRelease.Size = new System.Drawing.Size(127, 21);
            this.labelCompanyRelease.TabIndex = 22;
            this.labelCompanyRelease.Text = "Производитель:";
            // 
            // labelDose
            // 
            this.labelDose.AutoSize = true;
            this.labelDose.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelDose.Location = new System.Drawing.Point(10, 227);
            this.labelDose.Name = "labelDose";
            this.labelDose.Size = new System.Drawing.Size(144, 21);
            this.labelDose.TabIndex = 21;
            this.labelDose.Text = "Доза применения:";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelForm.Location = new System.Drawing.Point(10, 182);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(141, 21);
            this.labelForm.TabIndex = 20;
            this.labelForm.Text = "Форма лекарства:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelName.Location = new System.Drawing.Point(10, 136);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 21);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Название лекарства:";
            // 
            // textBoxCompanyRelease
            // 
            this.textBoxCompanyRelease.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCompanyRelease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCompanyRelease.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxCompanyRelease.Location = new System.Drawing.Point(14, 295);
            this.textBoxCompanyRelease.Multiline = true;
            this.textBoxCompanyRelease.Name = "textBoxCompanyRelease";
            this.textBoxCompanyRelease.Size = new System.Drawing.Size(219, 24);
            this.textBoxCompanyRelease.TabIndex = 18;
            // 
            // textBoxDose
            // 
            this.textBoxDose.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxDose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDose.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxDose.Location = new System.Drawing.Point(14, 249);
            this.textBoxDose.Multiline = true;
            this.textBoxDose.Name = "textBoxDose";
            this.textBoxDose.Size = new System.Drawing.Size(219, 24);
            this.textBoxDose.TabIndex = 17;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxName.Location = new System.Drawing.Point(14, 158);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 24);
            this.textBoxName.TabIndex = 15;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.BackColor = System.Drawing.Color.Honeydew;
            this.comboBoxForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxForm.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.IntegralHeight = false;
            this.comboBoxForm.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxForm.Location = new System.Drawing.Point(14, 203);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(219, 23);
            this.comboBoxForm.TabIndex = 29;
            // 
            // labelDateRelease
            // 
            this.labelDateRelease.AutoSize = true;
            this.labelDateRelease.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.labelDateRelease.Location = new System.Drawing.Point(10, 320);
            this.labelDateRelease.Name = "labelDateRelease";
            this.labelDateRelease.Size = new System.Drawing.Size(152, 21);
            this.labelDateRelease.TabIndex = 31;
            this.labelDateRelease.Text = "Дата производства:";
            // 
            // textBoxDateRelease
            // 
            this.textBoxDateRelease.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxDateRelease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateRelease.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxDateRelease.Location = new System.Drawing.Point(14, 341);
            this.textBoxDateRelease.Multiline = true;
            this.textBoxDateRelease.Name = "textBoxDateRelease";
            this.textBoxDateRelease.Size = new System.Drawing.Size(219, 24);
            this.textBoxDateRelease.TabIndex = 30;
            // 
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.labelLogoName.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelLogoName.Location = new System.Drawing.Point(267, 81);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(184, 31);
            this.labelLogoName.TabIndex = 33;
            this.labelLogoName.Text = "Сеть аптек 24/7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_system.Properties.Resources._5dab0406572aa;
            this.pictureBox1.Location = new System.Drawing.Point(314, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(712, 410);
            this.Controls.Add(this.labelLogoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDateRelease);
            this.Controls.Add(this.textBoxDateRelease);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewShowMedicines);
            this.Controls.Add(this.labelCompanyRelease);
            this.Controls.Add(this.labelDose);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCompanyRelease);
            this.Controls.Add(this.textBoxDose);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormMedicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о лекарствах";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewShowMedicines;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelCompanyRelease;
        private System.Windows.Forms.Label labelDose;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCompanyRelease;
        private System.Windows.Forms.TextBox textBoxDose;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.Label labelDateRelease;
        private System.Windows.Forms.TextBox textBoxDateRelease;
        private System.Windows.Forms.Label labelLogoName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}