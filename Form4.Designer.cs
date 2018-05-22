namespace Kursov
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рікВипускуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічніХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічнийСтанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запитуванаЦінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нІАBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.нІАDataSet1 = new Kursov.НІАDataSet1();
            this.нІАBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.нІАDataSet = new Kursov.НІАDataSet();
            this.нІАTableAdapter = new Kursov.НІАDataSetTableAdapters.НІАTableAdapter();
            this.нІАTableAdapter1 = new Kursov.НІАDataSet1TableAdapters.НІАTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.маркаDataGridViewTextBoxColumn,
            this.рікВипускуDataGridViewTextBoxColumn,
            this.технічніХарактеристикиDataGridViewTextBoxColumn,
            this.технічнийСтанDataGridViewTextBoxColumn,
            this.запитуванаЦінаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.нІАBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 149);
            this.dataGridView1.TabIndex = 0;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рікВипускуDataGridViewTextBoxColumn
            // 
            this.рікВипускуDataGridViewTextBoxColumn.DataPropertyName = "Рік випуску";
            this.рікВипускуDataGridViewTextBoxColumn.HeaderText = "Рік випуску";
            this.рікВипускуDataGridViewTextBoxColumn.Name = "рікВипускуDataGridViewTextBoxColumn";
            this.рікВипускуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // технічніХарактеристикиDataGridViewTextBoxColumn
            // 
            this.технічніХарактеристикиDataGridViewTextBoxColumn.DataPropertyName = "Технічні характеристики";
            this.технічніХарактеристикиDataGridViewTextBoxColumn.HeaderText = "Технічні характеристики";
            this.технічніХарактеристикиDataGridViewTextBoxColumn.Name = "технічніХарактеристикиDataGridViewTextBoxColumn";
            this.технічніХарактеристикиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // технічнийСтанDataGridViewTextBoxColumn
            // 
            this.технічнийСтанDataGridViewTextBoxColumn.DataPropertyName = "Технічний стан";
            this.технічнийСтанDataGridViewTextBoxColumn.HeaderText = "Технічний стан";
            this.технічнийСтанDataGridViewTextBoxColumn.Name = "технічнийСтанDataGridViewTextBoxColumn";
            this.технічнийСтанDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // запитуванаЦінаDataGridViewTextBoxColumn
            // 
            this.запитуванаЦінаDataGridViewTextBoxColumn.DataPropertyName = "Запитувана ціна";
            this.запитуванаЦінаDataGridViewTextBoxColumn.HeaderText = "Запитувана ціна";
            this.запитуванаЦінаDataGridViewTextBoxColumn.Name = "запитуванаЦінаDataGridViewTextBoxColumn";
            this.запитуванаЦінаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // нІАBindingSource1
            // 
            this.нІАBindingSource1.DataMember = "НІА";
            this.нІАBindingSource1.DataSource = this.нІАDataSet1;
            // 
            // нІАDataSet1
            // 
            this.нІАDataSet1.DataSetName = "НІАDataSet1";
            this.нІАDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нІАBindingSource
            // 
            this.нІАBindingSource.DataMember = "НІА";
            this.нІАBindingSource.DataSource = this.нІАDataSet;
            // 
            // нІАDataSet
            // 
            this.нІАDataSet.DataSetName = "НІАDataSet";
            this.нІАDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нІАTableAdapter
            // 
            this.нІАTableAdapter.ClearBeforeFill = true;
            // 
            // нІАTableAdapter1
            // 
            this.нІАTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База нових автомобілів.Іноземні автомобілі";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нІАDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private НІАDataSet нІАDataSet;
        private System.Windows.Forms.BindingSource нІАBindingSource;
        private НІАDataSetTableAdapters.НІАTableAdapter нІАTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рікВипускуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічніХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічнийСтанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn запитуванаЦінаDataGridViewTextBoxColumn;
        private НІАDataSet1 нІАDataSet1;
        private System.Windows.Forms.BindingSource нІАBindingSource1;
        private НІАDataSet1TableAdapters.НІАTableAdapter нІАTableAdapter1;
    }
}