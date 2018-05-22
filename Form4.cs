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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нІАDataSet1.НІА". При необходимости она может быть перемещена или удалена.
            this.нІАTableAdapter1.Fill(this.нІАDataSet1.НІА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нІАDataSet.НІА". При необходимости она может быть перемещена или удалена.
            this.нІАTableAdapter.Fill(this.нІАDataSet.НІА);

        }
    }
}
