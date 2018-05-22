using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursov
{
    public partial class Form7 : Form
    {


        public static bool radiobutton1 { get; internal set; }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бПDataSet2.БП". При необходимости она может быть перемещена или удалена.
            this.бПTableAdapter1.Fill(this.бПDataSet2.БП);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.БД". При необходимости она может быть перемещена или удалена.
            this.бДTableAdapter.Fill(this.бДDataSet.БД);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "нВАDataSet3.НВА". При необходимости она может быть перемещена или удалена.
            this.нВАTableAdapter.Fill(this.нВАDataSet3.НВА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бПDataSet.БП". При необходимости она может быть перемещена или удалена.
            this.бПTableAdapter.Fill(this.бПDataSet.БП);
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox3.SelectedIndex = 0;
            }
           
            
        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true && radioButton6.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton15.Checked == true && radioButton18.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль Mitsubishi Lancer X. Детальніше на вкладці Нові іноземні автомобілі");
            }
            else if (radioButton1.Checked == true && radioButton7.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton14.Checked == true && radioButton18.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль ЗАЗ Vidа. Детальніше на вкладці Нові вітчизняні автомобілі");
            }
            else if (radioButton2.Checked == true && radioButton7.Checked == true && radioButton9.Checked == true && radioButton11.Checked == true && radioButton16.Checked == true && radioButton18.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль LADA 4Х4 Urban. Детальніше на вкладці Нові вітчизняні автомобілі");
            }
            else if (radioButton3.Checked == true && radioButton8.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton14.Checked == true && radioButton18.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль LADA Granta. Детальніше на вкладці Нові вітчизняні автомобілі");
            }
            else if (radioButton4.Checked == true && radioButton7.Checked == true && radioButton9.Checked == true && radioButton12.Checked == true && radioButton15.Checked == true && radioButton19.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль Mercedes-Benz AMG C190. Детальніше на вкладці Нові іноземні автомобілі");
            }
            else if (radioButton1.Checked == true && radioButton6.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton15.Checked == true && radioButton19.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль BMW 3 Series F30. Детальніше на вкладці Нові іноземні автомобілі");
            }
            else if (radioButton2.Checked == true && radioButton6.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton14.Checked == true && radioButton17.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль 	ВАЗ 2104. Детальніше на вкладці Старі вітчизняні автомобілі");
            }
            else if (radioButton5.Checked == true && radioButton7.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton14.Checked == true && radioButton17.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль 	ВАЗ 21093. Детальніше на вкладці Старі вітчизняні автомобілі");
            }
            else if (radioButton1.Checked == true && radioButton8.Checked == true && radioButton9.Checked == true && radioButton10.Checked == true && radioButton14.Checked == true && radioButton17.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль 	ВАЗ 2110. Детальніше на вкладці Старі вітчизняні автомобілі");
            }
            else if (radioButton5.Checked == true && radioButton6.Checked == true && radioButton9.Checked == true && radioButton13.Checked == true && radioButton14.Checked == true && radioButton17.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль 	Opel Astra (G). Детальніше на вкладці Старі іноземні автомобілі");
            }
            else if (radioButton5.Checked == true && radioButton8.Checked == true && radioButton9.Checked == true && radioButton13.Checked == true && radioButton14.Checked == true && radioButton17.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль 	Ford Escort. Детальніше на вкладці Старі іноземні автомобілі");
            }
             
            else if (radioButton5.Checked == true && radioButton7.Checked == true && radioButton9.Checked == true && radioButton13.Checked == true && radioButton14.Checked == true && radioButton17.Checked == true)
            {
                MessageBox.Show("Найбільш підходить автомобіль 	Kia Shuma. Детальніше на вкладці Старі іноземні автомобілі");
            }
            else MessageBox.Show("Автомобіля з такими характеристиками немає в базі");
            

        } 
            
            

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            
        }

        
    }
}
