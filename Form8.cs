using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "зДПDataSet.ЗДП". При необходимости она может быть перемещена или удалена.
            this.зДПTableAdapter.Fill(this.зДПDataSet.ЗДП);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount++;
            int row = dataGridView1.RowCount - 1;

            dataGridView1[0, row - 1].Value = textBox1.Text;
            dataGridView1[1, row - 1].Value = textBox2.Text;
            dataGridView1[2, row - 1].Value = textBox3.Text;
            dataGridView1[3, row - 1].Value = textBox4.Text;
            dataGridView1[4, row - 1].Value = textBox5.Text;
            dataGridView1[5, row - 1].Value = textBox6.Text;
            dataGridView1[6, row - 1].Value = textBox7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        
    }
}
