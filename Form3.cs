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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сВАDataSet1.СВА". При необходимости она может быть перемещена или удалена.
            this.сВАTableAdapter1.Fill(this.сВАDataSet1.СВА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сВАDataSet.СВА". При необходимости она может быть перемещена или удалена.
            this.сВАTableAdapter.Fill(this.сВАDataSet.СВА);

        }
    }
}
