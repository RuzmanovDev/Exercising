namespace MassiveDynamic
{
    partial class MassiveDynamicMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поддръжкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поддръжкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поддръжкаToolStripMenuItem
            // 
            this.поддръжкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентиToolStripMenuItem});
            this.поддръжкаToolStripMenuItem.Name = "поддръжкаToolStripMenuItem";
            this.поддръжкаToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.поддръжкаToolStripMenuItem.Text = "Поддръжка";
            // 
            // клиентиToolStripMenuItem
            // 
            this.клиентиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.редактиранеToolStripMenuItem,
            this.изтриванеToolStripMenuItem});
            this.клиентиToolStripMenuItem.Name = "клиентиToolStripMenuItem";
            this.клиентиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.клиентиToolStripMenuItem.Text = "Клиенти";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolStripMenuItem.Text = "Добавяне";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // редактиранеToolStripMenuItem
            // 
            this.редактиранеToolStripMenuItem.Name = "редактиранеToolStripMenuItem";
            this.редактиранеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.редактиранеToolStripMenuItem.Text = "Редактиране";
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            // 
            // MassiveDynamicMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 269);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MassiveDynamicMainForm";
            this.Text = "MassiveDynamic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поддръжкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактиранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem;
    }
}

