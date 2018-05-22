namespace Kursov
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рікВипускуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічніХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічнийСтанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запитуванаЦінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нВАBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.нВАDataSet2 = new Kursov.НВАDataSet2();
            this.нВАBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.нВАDataSet = new Kursov.НВАDataSet();
            this.нВАTableAdapter = new Kursov.НВАDataSetTableAdapters.НВАTableAdapter();
            this.нВАDataSet1 = new Kursov.НВАDataSet1();
            this.нВАBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.нВАTableAdapter1 = new Kursov.НВАDataSet1TableAdapters.НВАTableAdapter();
            this.нВАTableAdapter2 = new Kursov.НВАDataSet2TableAdapters.НВАTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.нВАBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(740, 148);
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
            // нВАBindingSource2
            // 
            this.нВАBindingSource2.DataMember = "НВА";
            this.нВАBindingSource2.DataSource = this.нВАDataSet2;
            // 
            // нВАDataSet2
            // 
            this.нВАDataSet2.DataSetName = "НВАDataSet2";
            this.нВАDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нВАBindingSource
            // 
            this.нВАBindingSource.DataMember = "НВА";
            this.нВАBindingSource.DataSource = this.нВАDataSet;
            // 
            // нВАDataSet
            // 
            this.нВАDataSet.DataSetName = "НВАDataSet";
            this.нВАDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нВАTableAdapter
            // 
            this.нВАTableAdapter.ClearBeforeFill = true;
            // 
            // нВАDataSet1
            // 
            this.нВАDataSet1.DataSetName = "НВАDataSet1";
            this.нВАDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нВАBindingSource1
            // 
            this.нВАBindingSource1.DataMember = "НВА";
            this.нВАBindingSource1.DataSource = this.нВАDataSet1;
            // 
            // нВАTableAdapter1
            // 
            this.нВАTableAdapter1.ClearBeforeFill = true;
            // 
            // нВАTableAdapter2
            // 
            this.нВАTableAdapter2.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(742, 361);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База нових автомобілів.Вітчизняні автомобілі";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.нВАBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private НВАDataSet нВАDataSet;
        private System.Windows.Forms.BindingSource нВАBindingSource;
        private НВАDataSetTableAdapters.НВАTableAdapter нВАTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рікВипускуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічніХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічнийСтанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn запитуванаЦінаDataGridViewTextBoxColumn;
        private НВАDataSet1 нВАDataSet1;
        private System.Windows.Forms.BindingSource нВАBindingSource1;
        private НВАDataSet1TableAdapters.НВАTableAdapter нВАTableAdapter1;
        private НВАDataSet2 нВАDataSet2;
        private System.Windows.Forms.BindingSource нВАBindingSource2;
        private НВАDataSet2TableAdapters.НВАTableAdapter нВАTableAdapter2;
    }
}