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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бПDataSet3.БП". При необходимости она может быть перемещена или удалена.
            this.бПTableAdapter2.Fill(this.бПDataSet3.БП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бПDataSet1.БП". При необходимости она может быть перемещена или удалена.
            this.бПTableAdapter1.Fill(this.бПDataSet1.БП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бПDataSet.БП". При необходимости она может быть перемещена или удалена.
            this.бПTableAdapter.Fill(this.бПDataSet.БП);

        }
    }
}
