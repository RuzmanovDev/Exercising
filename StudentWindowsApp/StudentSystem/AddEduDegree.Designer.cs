namespace StudentSystem
{
    partial class AddEduDegree
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
            this.EduDegree = new System.Windows.Forms.Label();
            this.EduDegreeTextBox = new System.Windows.Forms.TextBox();
            this.AddEduDegreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EduDegree
            // 
            this.EduDegree.AutoSize = true;
            this.EduDegree.Location = new System.Drawing.Point(46, 57);
            this.EduDegree.Name = "EduDegree";
            this.EduDegree.Size = new System.Drawing.Size(138, 13);
            this.EduDegree.TabIndex = 0;
            this.EduDegree.Text = "Квалификационна степен";
            // 
            // EduDegreeTextBox
            // 
            this.EduDegreeTextBox.Location = new System.Drawing.Point(190, 57);
            this.EduDegreeTextBox.Name = "EduDegreeTextBox";
            this.EduDegreeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EduDegreeTextBox.TabIndex = 1;
            // 
            // AddEduDegreeButton
            // 
            this.AddEduDegreeButton.Location = new System.Drawing.Point(313, 55);
            this.AddEduDegreeButton.Name = "AddEduDegreeButton";
            this.AddEduDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEduDegreeButton.TabIndex = 2;
            this.AddEduDegreeButton.Text = "Добавяне";
            this.AddEduDegreeButton.UseVisualStyleBackColor = true;
            this.AddEduDegreeButton.Click += new System.EventHandler(this.AddEduDegreeButton_Click);
            // 
            // AddEduDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 134);
            this.Controls.Add(this.AddEduDegreeButton);
            this.Controls.Add(this.EduDegreeTextBox);
            this.Controls.Add(this.EduDegree);
            this.Name = "AddEduDegree";
            this.Text = "EduDegree";
            this.Load += new System.EventHandler(this.AddEduDegree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EduDegree;
        private System.Windows.Forms.TextBox EduDegreeTextBox;
        private System.Windows.Forms.Button AddEduDegreeButton;
    }
}