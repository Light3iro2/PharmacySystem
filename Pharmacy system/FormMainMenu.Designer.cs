namespace Pharmacy_system
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowPharmacies = new System.Windows.Forms.Button();
            this.buttonShowMedicines = new System.Windows.Forms.Button();
            this.buttonShowAvailable = new System.Windows.Forms.Button();
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.pictureBoxLogoCompany = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowPharmacies
            // 
            this.buttonShowPharmacies.BackColor = System.Drawing.Color.Honeydew;
            this.buttonShowPharmacies.FlatAppearance.BorderSize = 0;
            this.buttonShowPharmacies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPharmacies.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPharmacies.Location = new System.Drawing.Point(12, 197);
            this.buttonShowPharmacies.Name = "buttonShowPharmacies";
            this.buttonShowPharmacies.Size = new System.Drawing.Size(324, 63);
            this.buttonShowPharmacies.TabIndex = 0;
            this.buttonShowPharmacies.Text = "Информация о аптеках";
            this.buttonShowPharmacies.UseVisualStyleBackColor = false;
            this.buttonShowPharmacies.Click += new System.EventHandler(this.buttonShowPharmacies_Click);
            // 
            // buttonShowMedicines
            // 
            this.buttonShowMedicines.BackColor = System.Drawing.Color.Honeydew;
            this.buttonShowMedicines.FlatAppearance.BorderSize = 0;
            this.buttonShowMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowMedicines.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonShowMedicines.Location = new System.Drawing.Point(12, 275);
            this.buttonShowMedicines.Name = "buttonShowMedicines";
            this.buttonShowMedicines.Size = new System.Drawing.Size(324, 63);
            this.buttonShowMedicines.TabIndex = 1;
            this.buttonShowMedicines.Text = "Информация о лекарствах";
            this.buttonShowMedicines.UseVisualStyleBackColor = false;
            this.buttonShowMedicines.Click += new System.EventHandler(this.buttonShowMedicines_Click);
            // 
            // buttonShowAvailable
            // 
            this.buttonShowAvailable.BackColor = System.Drawing.Color.Honeydew;
            this.buttonShowAvailable.FlatAppearance.BorderSize = 0;
            this.buttonShowAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAvailable.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonShowAvailable.Location = new System.Drawing.Point(12, 353);
            this.buttonShowAvailable.Name = "buttonShowAvailable";
            this.buttonShowAvailable.Size = new System.Drawing.Size(324, 63);
            this.buttonShowAvailable.TabIndex = 2;
            this.buttonShowAvailable.Text = "Лекарства в наличии";
            this.buttonShowAvailable.UseVisualStyleBackColor = false;
            this.buttonShowAvailable.Click += new System.EventHandler(this.buttonShowAvailable_Click);
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.labelNameCompany.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNameCompany.Location = new System.Drawing.Point(63, 148);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(206, 31);
            this.labelNameCompany.TabIndex = 4;
            this.labelNameCompany.Text = "Сеть аптек \"24/7\"";
            // 
            // pictureBoxLogoCompany
            // 
            this.pictureBoxLogoCompany.Image = global::Pharmacy_system.Properties.Resources._5dab0406572aa;
            this.pictureBoxLogoCompany.Location = new System.Drawing.Point(93, 12);
            this.pictureBoxLogoCompany.Name = "pictureBoxLogoCompany";
            this.pictureBoxLogoCompany.Size = new System.Drawing.Size(147, 126);
            this.pictureBoxLogoCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoCompany.TabIndex = 3;
            this.pictureBoxLogoCompany.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(347, 438);
            this.Controls.Add(this.labelNameCompany);
            this.Controls.Add(this.pictureBoxLogoCompany);
            this.Controls.Add(this.buttonShowAvailable);
            this.Controls.Add(this.buttonShowMedicines);
            this.Controls.Add(this.buttonShowPharmacies);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowPharmacies;
        private System.Windows.Forms.Button buttonShowMedicines;
        private System.Windows.Forms.Button buttonShowAvailable;
        private System.Windows.Forms.PictureBox pictureBoxLogoCompany;
        private System.Windows.Forms.Label labelNameCompany;
    }
}

