namespace MassiveDynamic
{
    partial class DeleteShipperForm
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
            this.deleteShipperComboBox = new System.Windows.Forms.ComboBox();
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.ShippersTableAdapter();
            this.DeleteShipper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID на доставчика";
            // 
            // deleteShipperComboBox
            // 
            this.deleteShipperComboBox.DataSource = this.shippersBindingSource;
            this.deleteShipperComboBox.DisplayMember = "ShipperID";
            this.deleteShipperComboBox.FormattingEnabled = true;
            this.deleteShipperComboBox.Location = new System.Drawing.Point(146, 45);
            this.deleteShipperComboBox.Name = "deleteShipperComboBox";
            this.deleteShipperComboBox.Size = new System.Drawing.Size(121, 21);
            this.deleteShipperComboBox.TabIndex = 1;
            this.deleteShipperComboBox.ValueMember = "ShipperID";
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shippersBindingSource
            // 
            this.shippersBindingSource.DataMember = "Shippers";
            this.shippersBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteShipper
            // 
            this.DeleteShipper.Location = new System.Drawing.Point(305, 45);
            this.DeleteShipper.Name = "DeleteShipper";
            this.DeleteShipper.Size = new System.Drawing.Size(75, 23);
            this.DeleteShipper.TabIndex = 2;
            this.DeleteShipper.Text = "Изтриване";
            this.DeleteShipper.UseVisualStyleBackColor = true;
            this.DeleteShipper.Click += new System.EventHandler(this.DeleteShipper_Click);
            // 
            // DeleteShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 118);
            this.Controls.Add(this.DeleteShipper);
            this.Controls.Add(this.deleteShipperComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteShipperForm";
            this.Text = "DeleteShipperForm";
            this.Load += new System.EventHandler(this.DeleteShipperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deleteShipperComboBox;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource shippersBindingSource;
        private MassiveDynamicDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
        private System.Windows.Forms.Button DeleteShipper;
    }
}