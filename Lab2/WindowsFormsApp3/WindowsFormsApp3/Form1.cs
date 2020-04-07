using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nr1, nr2, rez;
            nr1 = Convert.ToInt32(textBox1.Text);
            nr2 = Convert.ToInt32(textBox2.Text);
            rez = nr1 & nr2;
            textBox3.Text = rez.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nr1, nr2, rez;
            nr1 = Convert.ToInt32(textBox1.Text);
            nr2 = Convert.ToInt32(textBox2.Text);
            rez = nr1 | nr2;
            textBox3.Text = rez.ToString();
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nr1, nr2, rez;
            nr1 = Convert.ToInt32(textBox1.Text);
            nr2 = Convert.ToInt32(textBox2.Text);
            rez = nr1 ^ nr2;
            textBox3.Text = rez.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int nr1, nr2;
            bool rez;
            nr1 = Convert.ToInt32(textBox1.Text);
            nr2 = Convert.ToInt32(textBox2.Text);
            rez = (nr1==nr2);
            textBox3.Text = rez.ToString();
        }
    }
}
