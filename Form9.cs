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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount++;
            int row = dataGridView1.RowCount - 1;

            dataGridView1[0, row - 1].Value = textBox1.Text;
            dataGridView1[1, row - 1].Value = textBox2.Text;
            dataGridView1[2, row - 1].Value = textBox3.Text;
            dataGridView1[3, row - 1].Value = textBox4.Text;
            dataGridView1[4, row - 1].Value = textBox5.Text;
            dataGridView1[5, row - 1].Value = textBox6.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            BindingList<SampleRow> data = new BindingList<SampleRow>(); //Специальный список List с вызовом события обновления внутреннего состояния, необходимого для автообновления datagridview
            data.Add(new SampleRow("Киев","Конотоп" ,"чотири години","Mers" ,1,"З заводу"));
            data.Add(new SampleRow("Киев", "Суми", "дві години", "Ford", 3, "З заводу"));
            data.Add(new SampleRow("Киев", "Москва", "три години", "Michubichi", 5, "З заводу"));

            dataGridView1.DataSource = data;
            data.Add(new SampleRow("Киев", "Тернополь", "Час", "ВАЗ 2104", 12, "З заводу"));
        }
    }
}
