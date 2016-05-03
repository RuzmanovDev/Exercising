namespace StudentSystem
{
    partial class AddSpecialties
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
            this.NameOfSpecialty = new System.Windows.Forms.Label();
            this.NameOfSpecialtyTextBox = new System.Windows.Forms.TextBox();
            this.AddSpecialtyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameOfSpecialty
            // 
            this.NameOfSpecialty.AutoSize = true;
            this.NameOfSpecialty.Location = new System.Drawing.Point(30, 43);
            this.NameOfSpecialty.Name = "NameOfSpecialty";
            this.NameOfSpecialty.Size = new System.Drawing.Size(123, 13);
            this.NameOfSpecialty.TabIndex = 0;
            this.NameOfSpecialty.Text = "Име на специалността";
            // 
            // NameOfSpecialtyTextBox
            // 
            this.NameOfSpecialtyTextBox.Location = new System.Drawing.Point(160, 43);
            this.NameOfSpecialtyTextBox.Name = "NameOfSpecialtyTextBox";
            this.NameOfSpecialtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameOfSpecialtyTextBox.TabIndex = 1;
            // 
            // AddSpecialtyButton
            // 
            this.AddSpecialtyButton.Location = new System.Drawing.Point(266, 41);
            this.AddSpecialtyButton.Name = "AddSpecialtyButton";
            this.AddSpecialtyButton.Size = new System.Drawing.Size(75, 23);
            this.AddSpecialtyButton.TabIndex = 2;
            this.AddSpecialtyButton.Text = "Добавяне";
            this.AddSpecialtyButton.UseVisualStyleBackColor = true;
            this.AddSpecialtyButton.Click += new System.EventHandler(this.AddSpecialtyButton_Click);
            // 
            // Specialities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 102);
            this.Controls.Add(this.AddSpecialtyButton);
            this.Controls.Add(this.NameOfSpecialtyTextBox);
            this.Controls.Add(this.NameOfSpecialty);
            this.Name = "Specialities";
            this.Text = "Specialities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfSpecialty;
        private System.Windows.Forms.TextBox NameOfSpecialtyTextBox;
        private System.Windows.Forms.Button AddSpecialtyButton;
    }
}