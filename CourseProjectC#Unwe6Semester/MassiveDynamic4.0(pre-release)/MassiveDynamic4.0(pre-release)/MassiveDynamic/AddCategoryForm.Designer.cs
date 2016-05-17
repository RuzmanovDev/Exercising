namespace MassiveDynamic
{
    partial class AddCategoryForm
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
            this.CategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на категорията";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на категорията";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // CategoryIDTextBox
            // 
            this.CategoryIDTextBox.Location = new System.Drawing.Point(203, 20);
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryIDTextBox.TabIndex = 3;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(203, 70);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryNameTextBox.TabIndex = 4;
            // 
            // CategoryDescriptionTextBox
            // 
            this.CategoryDescriptionTextBox.Location = new System.Drawing.Point(84, 118);
            this.CategoryDescriptionTextBox.Multiline = true;
            this.CategoryDescriptionTextBox.Name = "CategoryDescriptionTextBox";
            this.CategoryDescriptionTextBox.Size = new System.Drawing.Size(219, 52);
            this.CategoryDescriptionTextBox.TabIndex = 5;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(203, 201);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(100, 23);
            this.AddCategoryButton.TabIndex = 6;
            this.AddCategoryButton.TabStop = false;
            this.AddCategoryButton.Text = "Добавяне";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 257);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategoryDescriptionTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CategoryIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategoryForm";
            this.Text = "Добавяне на категория";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CategoryIDTextBox;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox CategoryDescriptionTextBox;
        private System.Windows.Forms.Button AddCategoryButton;
    }
}