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
            this.EditCustomersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterdetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.критерииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerNameAdressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поддръжкаToolStripMenuItem,
            this.masterdetailToolStripMenuItem,
            this.referanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поддръжкаToolStripMenuItem
            // 
            this.поддръжкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентиToolStripMenuItem,
            this.критерииToolStripMenuItem});
            this.поддръжкаToolStripMenuItem.Name = "поддръжкаToolStripMenuItem";
            this.поддръжкаToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.поддръжкаToolStripMenuItem.Text = "Поддръжка";
            // 
            // клиентиToolStripMenuItem
            // 
            this.клиентиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditCustomersMenuItem,
            this.deleteToolStripMenuItem});
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
            // EditCustomersMenuItem
            // 
            this.EditCustomersMenuItem.Name = "EditCustomersMenuItem";
            this.EditCustomersMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EditCustomersMenuItem.Text = "Редактиране";
            this.EditCustomersMenuItem.Click += new System.EventHandler(this.EditCustomersMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Изтриване";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // masterdetailToolStripMenuItem
            // 
            this.masterdetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem});
            this.masterdetailToolStripMenuItem.Name = "masterdetailToolStripMenuItem";
            this.masterdetailToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.masterdetailToolStripMenuItem.Text = "master-detail";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // критерииToolStripMenuItem
            // 
            this.критерииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryToolStripMenuItem,
            this.EditCategoryToolStripMenuItem,
            this.DeleteCategoryToolStripMenuItem});
            this.критерииToolStripMenuItem.Name = "критерииToolStripMenuItem";
            this.критерииToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.критерииToolStripMenuItem.Text = "Категории";
            // 
            // AddCategoryToolStripMenuItem
            // 
            this.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem";
            this.AddCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddCategoryToolStripMenuItem.Text = "Добавяне";
            // 
            // EditCategoryToolStripMenuItem
            // 
            this.EditCategoryToolStripMenuItem.Name = "EditCategoryToolStripMenuItem";
            this.EditCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EditCategoryToolStripMenuItem.Text = "Редакиране";
            // 
            // DeleteCategoryToolStripMenuItem
            // 
            this.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem";
            this.DeleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteCategoryToolStripMenuItem.Text = "Изтриване";
            // 
            // referanceToolStripMenuItem
            // 
            this.referanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerNameAdressToolStripMenuItem});
            this.referanceToolStripMenuItem.Name = "referanceToolStripMenuItem";
            this.referanceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.referanceToolStripMenuItem.Text = "Referance";
            // 
            // customerNameAdressToolStripMenuItem
            // 
            this.customerNameAdressToolStripMenuItem.Name = "customerNameAdressToolStripMenuItem";
            this.customerNameAdressToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.customerNameAdressToolStripMenuItem.Text = "CustomerName-Adress";
            this.customerNameAdressToolStripMenuItem.Click += new System.EventHandler(this.customerNameAdressToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem EditCustomersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterdetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem критерииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerNameAdressToolStripMenuItem;
    }
}

