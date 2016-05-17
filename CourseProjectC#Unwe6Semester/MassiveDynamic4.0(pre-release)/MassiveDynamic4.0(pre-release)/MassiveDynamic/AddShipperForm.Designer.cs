namespace MassiveDynamic
{
    partial class AddShipperForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShipperIdTextBox = new System.Windows.Forms.TextBox();
            this.ShipperNameTextBox = new System.Windows.Forms.TextBox();
            this.ShipperTelephoneTextBox = new System.Windows.Forms.TextBox();
            this.AddShipperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на доставчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на доставчика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон на доставчика";
            // 
            // ShipperIdTextBox
            // 
            this.ShipperIdTextBox.Location = new System.Drawing.Point(157, 33);
            this.ShipperIdTextBox.Name = "ShipperIdTextBox";
            this.ShipperIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipperIdTextBox.TabIndex = 3;
            // 
            // ShipperNameTextBox
            // 
            this.ShipperNameTextBox.Location = new System.Drawing.Point(157, 70);
            this.ShipperNameTextBox.Name = "ShipperNameTextBox";
            this.ShipperNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipperNameTextBox.TabIndex = 4;
            // 
            // ShipperTelephoneTextBox
            // 
            this.ShipperTelephoneTextBox.Location = new System.Drawing.Point(157, 103);
            this.ShipperTelephoneTextBox.Name = "ShipperTelephoneTextBox";
            this.ShipperTelephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipperTelephoneTextBox.TabIndex = 5;
            // 
            // AddShipperButton
            // 
            this.AddShipperButton.Location = new System.Drawing.Point(157, 135);
            this.AddShipperButton.Name = "AddShipperButton";
            this.AddShipperButton.Size = new System.Drawing.Size(75, 23);
            this.AddShipperButton.TabIndex = 6;
            this.AddShipperButton.Text = "Добави";
            this.AddShipperButton.UseVisualStyleBackColor = true;
            this.AddShipperButton.Click += new System.EventHandler(this.AddShipperButton_Click);
            // 
            // AddShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 170);
            this.Controls.Add(this.AddShipperButton);
            this.Controls.Add(this.ShipperTelephoneTextBox);
            this.Controls.Add(this.ShipperNameTextBox);
            this.Controls.Add(this.ShipperIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddShipperForm";
            this.Text = "AddShipperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShipperIdTextBox;
        private System.Windows.Forms.TextBox ShipperNameTextBox;
        private System.Windows.Forms.TextBox ShipperTelephoneTextBox;
        private System.Windows.Forms.Button AddShipperButton;
    }
}