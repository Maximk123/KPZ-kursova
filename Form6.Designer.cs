namespace Kursov
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.пІПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактніКоординатиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вимогиДоМаркиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічніХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.технічнийСтанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фінансовіМожливостіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бПBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.бПDataSet3 = new Kursov.БПDataSet3();
            this.бПBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бПDataSet1 = new Kursov.БПDataSet1();
            this.бПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бПDataSet = new Kursov.БПDataSet();
            this.бПTableAdapter = new Kursov.БПDataSetTableAdapters.БПTableAdapter();
            this.бПTableAdapter1 = new Kursov.БПDataSet1TableAdapters.БПTableAdapter();
            this.бПTableAdapter2 = new Kursov.БПDataSet3TableAdapters.БПTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.пІПDataGridViewTextBoxColumn,
            this.контактніКоординатиDataGridViewTextBoxColumn,
            this.вимогиДоМаркиDataGridViewTextBoxColumn,
            this.технічніХарактеристикиDataGridViewTextBoxColumn,
            this.технічнийСтанDataGridViewTextBoxColumn,
            this.фінансовіМожливостіDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.бПBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // пІПDataGridViewTextBoxColumn
            // 
            this.пІПDataGridViewTextBoxColumn.DataPropertyName = "ПІП";
            this.пІПDataGridViewTextBoxColumn.HeaderText = "ПІП";
            this.пІПDataGridViewTextBoxColumn.Name = "пІПDataGridViewTextBoxColumn";
            this.пІПDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // контактніКоординатиDataGridViewTextBoxColumn
            // 
            this.контактніКоординатиDataGridViewTextBoxColumn.DataPropertyName = "Контактні координати";
            this.контактніКоординатиDataGridViewTextBoxColumn.HeaderText = "Контактні координати";
            this.контактніКоординатиDataGridViewTextBoxColumn.Name = "контактніКоординатиDataGridViewTextBoxColumn";
            this.контактніКоординатиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вимогиДоМаркиDataGridViewTextBoxColumn
            // 
            this.вимогиДоМаркиDataGridViewTextBoxColumn.DataPropertyName = "Вимоги до марки";
            this.вимогиДоМаркиDataGridViewTextBoxColumn.HeaderText = "Вимоги до марки";
            this.вимогиДоМаркиDataGridViewTextBoxColumn.Name = "вимогиДоМаркиDataGridViewTextBoxColumn";
            this.вимогиДоМаркиDataGridViewTextBoxColumn.ReadOnly = true;
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
            // фінансовіМожливостіDataGridViewTextBoxColumn
            // 
            this.фінансовіМожливостіDataGridViewTextBoxColumn.DataPropertyName = "Фінансові можливості";
            this.фінансовіМожливостіDataGridViewTextBoxColumn.HeaderText = "Фінансові можливості";
            this.фінансовіМожливостіDataGridViewTextBoxColumn.Name = "фінансовіМожливостіDataGridViewTextBoxColumn";
            this.фінансовіМожливостіDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // бПBindingSource2
            // 
            this.бПBindingSource2.DataMember = "БП";
            this.бПBindingSource2.DataSource = this.бПDataSet3;
            // 
            // бПDataSet3
            // 
            this.бПDataSet3.DataSetName = "БПDataSet3";
            this.бПDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бПBindingSource1
            // 
            this.бПBindingSource1.DataMember = "БП";
            this.бПBindingSource1.DataSource = this.бПDataSet1;
            // 
            // бПDataSet1
            // 
            this.бПDataSet1.DataSetName = "БПDataSet1";
            this.бПDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бПBindingSource
            // 
            this.бПBindingSource.DataMember = "БП";
            this.бПBindingSource.DataSource = this.бПDataSet;
            // 
            // бПDataSet
            // 
            this.бПDataSet.DataSetName = "БПDataSet";
            this.бПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бПTableAdapter
            // 
            this.бПTableAdapter.ClearBeforeFill = true;
            // 
            // бПTableAdapter1
            // 
            this.бПTableAdapter1.ClearBeforeFill = true;
            // 
            // бПTableAdapter2
            // 
            this.бПTableAdapter2.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База покупців";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бПDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БПDataSet бПDataSet;
        private System.Windows.Forms.BindingSource бПBindingSource;
        private БПDataSetTableAdapters.БПTableAdapter бПTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактніКоординатиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вимогиДоМаркиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічніХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn технічнийСтанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фінансовіМожливостіDataGridViewTextBoxColumn;
        private БПDataSet1 бПDataSet1;
        private System.Windows.Forms.BindingSource бПBindingSource1;
        private БПDataSet1TableAdapters.БПTableAdapter бПTableAdapter1;
        private БПDataSet3 бПDataSet3;
        private System.Windows.Forms.BindingSource бПBindingSource2;
        private БПDataSet3TableAdapters.БПTableAdapter бПTableAdapter2;
    }
}