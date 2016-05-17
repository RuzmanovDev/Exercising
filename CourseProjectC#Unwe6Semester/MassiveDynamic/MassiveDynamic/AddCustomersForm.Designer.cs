namespace MassiveDynamic
{
    partial class AddCustomersForm
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
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdAddTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.telNumberLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(12, 20);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(100, 13);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "Номер на клиента";
            // 
            // CustomerIdAddTextBox
            // 
            this.CustomerIdAddTextBox.Location = new System.Drawing.Point(136, 13);
            this.CustomerIdAddTextBox.Name = "CustomerIdAddTextBox";
            this.CustomerIdAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIdAddTextBox.TabIndex = 1;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(12, 54);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(108, 13);
            this.companyNameLabel.TabIndex = 2;
            this.companyNameLabel.Text = "Име на компанията";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(136, 54);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CompanyNameTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(18, 93);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(38, 13);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Адрес";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(136, 86);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 5;
            // 
            // telNumberLabel
            // 
            this.telNumberLabel.AutoSize = true;
            this.telNumberLabel.Location = new System.Drawing.Point(18, 133);
            this.telNumberLabel.Name = "telNumberLabel";
            this.telNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.telNumberLabel.TabIndex = 6;
            this.telNumberLabel.Text = "Телефонен номер";
            // 
            // CustomerPhoneTextBox
            // 
            this.CustomerPhoneTextBox.Location = new System.Drawing.Point(136, 133);
            this.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            this.CustomerPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerPhoneTextBox.TabIndex = 7;
            // 
            // AddCustomersButton
            // 
            this.AddCustomersButton.Location = new System.Drawing.Point(81, 187);
            this.AddCustomersButton.Name = "AddCustomersButton";
            this.AddCustomersButton.Size = new System.Drawing.Size(106, 23);
            this.AddCustomersButton.TabIndex = 8;
            this.AddCustomersButton.Text = "Добави";
            this.AddCustomersButton.UseVisualStyleBackColor = true;
            this.AddCustomersButton.Click += new System.EventHandler(this.AddCustomersButton_Click);
            // 
            // AddCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 235);
            this.Controls.Add(this.AddCustomersButton);
            this.Controls.Add(this.CustomerPhoneTextBox);
            this.Controls.Add(this.telNumberLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.CustomerIdAddTextBox);
            this.Controls.Add(this.customerIdLabel);
            this.Name = "AddCustomersForm";
            this.Text = "AddCustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.TextBox CustomerIdAddTextBox;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label telNumberLabel;
        private System.Windows.Forms.TextBox CustomerPhoneTextBox;
        private System.Windows.Forms.Button AddCustomersButton;
    }
}