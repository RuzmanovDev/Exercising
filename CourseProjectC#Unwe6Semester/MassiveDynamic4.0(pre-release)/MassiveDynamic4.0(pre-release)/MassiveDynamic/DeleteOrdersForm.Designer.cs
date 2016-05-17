namespace MassiveDynamic
{
    partial class DeleteOrdersForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteOrdersComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteOrdersButton = new System.Windows.Forms.Button();
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на поръчката";
            // 
            // DeleteOrdersComboBox
            // 
            this.DeleteOrdersComboBox.DataSource = this.ordersBindingSource;
            this.DeleteOrdersComboBox.DisplayMember = "OrderID";
            this.DeleteOrdersComboBox.FormattingEnabled = true;
            this.DeleteOrdersComboBox.Location = new System.Drawing.Point(158, 25);
            this.DeleteOrdersComboBox.Name = "DeleteOrdersComboBox";
            this.DeleteOrdersComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeleteOrdersComboBox.TabIndex = 1;
            this.DeleteOrdersComboBox.ValueMember = "OrderID";
            // 
            // DeleteOrdersButton
            // 
            this.DeleteOrdersButton.Location = new System.Drawing.Point(306, 23);
            this.DeleteOrdersButton.Name = "DeleteOrdersButton";
            this.DeleteOrdersButton.Size = new System.Drawing.Size(86, 23);
            this.DeleteOrdersButton.TabIndex = 2;
            this.DeleteOrdersButton.Text = "Изтриване";
            this.DeleteOrdersButton.UseVisualStyleBackColor = true;
            this.DeleteOrdersButton.Click += new System.EventHandler(this.DeleteOrdersButton_Click);
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.DeleteOrdersButton);
            this.Controls.Add(this.DeleteOrdersComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteOrdersForm";
            this.Text = "Изтриване на поръчки";
            this.Load += new System.EventHandler(this.DeleteOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeleteOrdersComboBox;
        private System.Windows.Forms.Button DeleteOrdersButton;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MassiveDynamicDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}