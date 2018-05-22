namespace Kursov
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рікВипускуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічніХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічнийСтанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запитуванаЦінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сВАBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сВАDataSet1 = new Kursov.СВАDataSet1();
            this.сВАBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сВАDataSet = new Kursov.СВАDataSet();
            this.сВАTableAdapter = new Kursov.СВАDataSetTableAdapters.СВАTableAdapter();
            this.сВАTableAdapter1 = new Kursov.СВАDataSet1TableAdapters.СВАTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАDataSet)).BeginInit();
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
            this.dataGridView1.DataSource = this.сВАBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 151);
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
            // сВАBindingSource1
            // 
            this.сВАBindingSource1.DataMember = "СВА";
            this.сВАBindingSource1.DataSource = this.сВАDataSet1;
            // 
            // сВАDataSet1
            // 
            this.сВАDataSet1.DataSetName = "СВАDataSet1";
            this.сВАDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сВАBindingSource
            // 
            this.сВАBindingSource.DataMember = "СВА";
            this.сВАBindingSource.DataSource = this.сВАDataSet;
            // 
            // сВАDataSet
            // 
            this.сВАDataSet.DataSetName = "СВАDataSet";
            this.сВАDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сВАTableAdapter
            // 
            this.сВАTableAdapter.ClearBeforeFill = true;
            // 
            // сВАTableAdapter1
            // 
            this.сВАTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База старих автомобілів.Вітчизняні автомобілі";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сВАDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private СВАDataSet сВАDataSet;
        private System.Windows.Forms.BindingSource сВАBindingSource;
        private СВАDataSetTableAdapters.СВАTableAdapter сВАTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рікВипускуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічніХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічнийСтанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn запитуванаЦінаDataGridViewTextBoxColumn;
        private СВАDataSet1 сВАDataSet1;
        private System.Windows.Forms.BindingSource сВАBindingSource1;
        private СВАDataSet1TableAdapters.СВАTableAdapter сВАTableAdapter1;
    }
}