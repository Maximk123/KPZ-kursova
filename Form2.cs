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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нВАDataSet2.НВА". При необходимости она может быть перемещена или удалена.
            this.нВАTableAdapter2.Fill(this.нВАDataSet2.НВА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нВАDataSet1.НВА". При необходимости она может быть перемещена или удалена.
            this.нВАTableAdapter1.Fill(this.нВАDataSet1.НВА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нВАDataSet.НВА". При необходимости она может быть перемещена или удалена.
            this.нВАTableAdapter.Fill(this.нВАDataSet.НВА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нВАDataSet1.НВА". При необходимости она может быть перемещена или удалена.
            this.нВАTableAdapter.Fill(this.нВАDataSet.НВА);
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;


        }
    }
}
