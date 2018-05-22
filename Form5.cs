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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сІАDataSet1.СІА". При необходимости она может быть перемещена или удалена.
            this.сІАTableAdapter1.Fill(this.сІАDataSet1.СІА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сІАDataSet.СІА". При необходимости она может быть перемещена или удалена.
            this.сІАTableAdapter.Fill(this.сІАDataSet.СІА);

        }
    }
}
