namespace StudentSystem
{
    partial class AddGorups
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
            this.NumberOfGruop = new System.Windows.Forms.Label();
            this.NumberOfGroupTextBox = new System.Windows.Forms.TextBox();
            this.AddNumberOfGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOfGruop
            // 
            this.NumberOfGruop.AutoSize = true;
            this.NumberOfGruop.Location = new System.Drawing.Point(28, 43);
            this.NumberOfGruop.Name = "NumberOfGruop";
            this.NumberOfGruop.Size = new System.Drawing.Size(98, 13);
            this.NumberOfGruop.TabIndex = 0;
            this.NumberOfGruop.Text = "Номер на групата";
            // 
            // NumberOfGroupTextBox
            // 
            this.NumberOfGroupTextBox.Location = new System.Drawing.Point(132, 43);
            this.NumberOfGroupTextBox.Name = "NumberOfGroupTextBox";
            this.NumberOfGroupTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfGroupTextBox.TabIndex = 1;
            // 
            // AddNumberOfGroup
            // 
            this.AddNumberOfGroup.Location = new System.Drawing.Point(238, 43);
            this.AddNumberOfGroup.Name = "AddNumberOfGroup";
            this.AddNumberOfGroup.Size = new System.Drawing.Size(75, 23);
            this.AddNumberOfGroup.TabIndex = 2;
            this.AddNumberOfGroup.Text = "Добавяне";
            this.AddNumberOfGroup.UseVisualStyleBackColor = true;
            this.AddNumberOfGroup.Click += new System.EventHandler(this.AddNumberOfGroup_Click);
            // 
            // AddGorups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 105);
            this.Controls.Add(this.AddNumberOfGroup);
            this.Controls.Add(this.NumberOfGroupTextBox);
            this.Controls.Add(this.NumberOfGruop);
            this.Name = "AddGorups";
            this.Text = "AddGorups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfGruop;
        private System.Windows.Forms.TextBox NumberOfGroupTextBox;
        private System.Windows.Forms.Button AddNumberOfGroup;
    }
}