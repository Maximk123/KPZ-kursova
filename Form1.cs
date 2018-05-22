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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вітчизняніАвтомобіліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        private void вітчизняніАвтомобіліToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 Form2 = new Form3();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        private void іноземніАвтомобіліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Form2 = new Form4();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        private void іліземніАвтомобіліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Form2 = new Form5();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        private void базаПокупцівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Form2 = new Form6();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void пошукПідходящихАвтомобілівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Form2 = new Form7();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        public static implicit operator Form1(Form7 v)
        {
            throw new NotImplementedException();
        }

        private void дляПерегонниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Form2 = new Form8();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;
        }

        private void дляПостачальниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 Form2 = new Form9();
            Form2.Show();
            Form2.Width = 757;
            Form2.Height = 400;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
