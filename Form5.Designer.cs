namespace Kursov
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рікВипускуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічніХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічнийСтанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запитуванаЦінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сІАBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сІАDataSet1 = new Kursov.СІАDataSet1();
            this.сІАBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сІАDataSet = new Kursov.СІАDataSet();
            this.сІАTableAdapter = new Kursov.СІАDataSetTableAdapters.СІАTableAdapter();
            this.сІАTableAdapter1 = new Kursov.СІАDataSet1TableAdapters.СІАTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАDataSet)).BeginInit();
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
            this.dataGridView1.DataSource = this.сІАBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 150);
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
            // сІАBindingSource1
            // 
            this.сІАBindingSource1.DataMember = "СІА";
            this.сІАBindingSource1.DataSource = this.сІАDataSet1;
            // 
            // сІАDataSet1
            // 
            this.сІАDataSet1.DataSetName = "СІАDataSet1";
            this.сІАDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сІАBindingSource
            // 
            this.сІАBindingSource.DataMember = "СІА";
            this.сІАBindingSource.DataSource = this.сІАDataSet;
            // 
            // сІАDataSet
            // 
            this.сІАDataSet.DataSetName = "СІАDataSet";
            this.сІАDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сІАTableAdapter
            // 
            this.сІАTableAdapter.ClearBeforeFill = true;
            // 
            // сІАTableAdapter1
            // 
            this.сІАTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База старих автомобілів.Іноземні автомобілі";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сІАDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private СІАDataSet сІАDataSet;
        private System.Windows.Forms.BindingSource сІАBindingSource;
        private СІАDataSetTableAdapters.СІАTableAdapter сІАTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рікВипускуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічніХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічнийСтанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn запитуванаЦінаDataGridViewTextBoxColumn;
        private СІАDataSet1 сІАDataSet1;
        private System.Windows.Forms.BindingSource сІАBindingSource1;
        private СІАDataSet1TableAdapters.СІАTableAdapter сІАTableAdapter1;
    }
}