namespace StudentSystem
{
    partial class UpdateEducationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesho = new StudentSystem.Pesho();
            this.educationFormTableAdapter = new StudentSystem.PeshoTableAdapters.EducationFormTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eFIDDataGridViewTextBoxColumn,
            this.educFormDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.educationFormBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // eFIDDataGridViewTextBoxColumn
            // 
            this.eFIDDataGridViewTextBoxColumn.DataPropertyName = "EFID";
            this.eFIDDataGridViewTextBoxColumn.HeaderText = "EFID";
            this.eFIDDataGridViewTextBoxColumn.Name = "eFIDDataGridViewTextBoxColumn";
            this.eFIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // educFormDataGridViewTextBoxColumn
            // 
            this.educFormDataGridViewTextBoxColumn.DataPropertyName = "EducForm";
            this.educFormDataGridViewTextBoxColumn.HeaderText = "EducForm";
            this.educFormDataGridViewTextBoxColumn.Name = "educFormDataGridViewTextBoxColumn";
            this.educFormDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // educationFormBindingSource
            // 
            this.educationFormBindingSource.DataMember = "EducationForm";
            this.educationFormBindingSource.DataSource = this.pesho;
            // 
            // pesho
            // 
            this.pesho.DataSetName = "Pesho";
            this.pesho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationFormTableAdapter
            // 
            this.educationFormTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 282);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateEducationForm";
            this.Text = "Промяна на форма на обучение";
            this.Load += new System.EventHandler(this.UpdateEducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Pesho pesho;
        private System.Windows.Forms.BindingSource educationFormBindingSource;
        private PeshoTableAdapters.EducationFormTableAdapter educationFormTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educFormDataGridViewTextBoxColumn;
    }
}