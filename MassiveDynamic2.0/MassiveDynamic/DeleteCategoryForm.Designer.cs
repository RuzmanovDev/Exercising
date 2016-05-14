namespace MassiveDynamic
{
    partial class DeleteCategoryForm
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
            this.DeleteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID на категорията";
            // 
            // DeleteCategoryComboBox
            // 
            this.DeleteCategoryComboBox.DataSource = this.categoriesBindingSource;
            this.DeleteCategoryComboBox.DisplayMember = "CategoryID";
            this.DeleteCategoryComboBox.FormattingEnabled = true;
            this.DeleteCategoryComboBox.Location = new System.Drawing.Point(130, 34);
            this.DeleteCategoryComboBox.Name = "DeleteCategoryComboBox";
            this.DeleteCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeleteCategoryComboBox.TabIndex = 1;
            this.DeleteCategoryComboBox.ValueMember = "CategoryID";
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Location = new System.Drawing.Point(268, 32);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCategoryButton.TabIndex = 2;
            this.DeleteCategoryButton.Text = "Изтриване";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 84);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.DeleteCategoryComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCategoryForm";
            this.Text = "DeleteCategoryForm";
            this.Load += new System.EventHandler(this.DeleteCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DeleteCategoryComboBox;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private MassiveDynamicDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}