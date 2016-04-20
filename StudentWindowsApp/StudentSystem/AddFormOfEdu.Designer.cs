namespace StudentSystem
{
    partial class AddFormOfEdu
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
            this.formOfEduLabel = new System.Windows.Forms.Label();
            this.FormOfEduTextBox = new System.Windows.Forms.TextBox();
            this.FormOfEduAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formOfEduLabel
            // 
            this.formOfEduLabel.AutoSize = true;
            this.formOfEduLabel.Location = new System.Drawing.Point(23, 28);
            this.formOfEduLabel.Name = "formOfEduLabel";
            this.formOfEduLabel.Size = new System.Drawing.Size(108, 13);
            this.formOfEduLabel.TabIndex = 0;
            this.formOfEduLabel.Text = "Форма на обучение";
            // 
            // FormOfEduTextBox
            // 
            this.FormOfEduTextBox.Location = new System.Drawing.Point(152, 28);
            this.FormOfEduTextBox.Name = "FormOfEduTextBox";
            this.FormOfEduTextBox.Size = new System.Drawing.Size(100, 20);
            this.FormOfEduTextBox.TabIndex = 1;
            // 
            // FormOfEduAddButton
            // 
            this.FormOfEduAddButton.Location = new System.Drawing.Point(274, 24);
            this.FormOfEduAddButton.Name = "FormOfEduAddButton";
            this.FormOfEduAddButton.Size = new System.Drawing.Size(75, 23);
            this.FormOfEduAddButton.TabIndex = 2;
            this.FormOfEduAddButton.Text = "Добавяне";
            this.FormOfEduAddButton.UseVisualStyleBackColor = true;
            this.FormOfEduAddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFormOfEdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 82);
            this.Controls.Add(this.FormOfEduAddButton);
            this.Controls.Add(this.FormOfEduTextBox);
            this.Controls.Add(this.formOfEduLabel);
            this.Name = "AddFormOfEdu";
            this.Text = "AddFormOfEdu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formOfEduLabel;
        private System.Windows.Forms.TextBox FormOfEduTextBox;
        private System.Windows.Forms.Button FormOfEduAddButton;
    }
}