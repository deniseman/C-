using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private string text1;
        private string text2;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Ronaldo");
            listBox1.Items.Add("Messi");
            listBox1.Items.Add("Ramos");
            listBox1.Items.Add("Zidane");
            listBox1.Items.Add("Isco");
            listBox1.Items.Add("Van Dijk");
            listBox1.Items.Add("Reus");
            listBox1.Items.Add("Lewandowski");
            listBox1.Items.Add("Marcelo");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();
            pictureBox1.ImageLocation = "./" + selected + ".png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                text1 = radioButton1.Text;
            }else if (radioButton2.Checked)
            {
                text1 = radioButton2.Text;
            }else if (radioButton3.Checked)
            {
                text1 = radioButton3.Text;
            }


            if (radioButton4.Checked)
            {
                text2 = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                text2 = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                text2 = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                text2 = radioButton7.Text;
            }

            MessageBox.Show(text1 + " " + text2);
        }
    }
}
