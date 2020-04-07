using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add : Form
    {
        SqlCommand cmd;
        SqlConnection myCon;
        private string nume;
        private string oras;
        private int id;
        private int cod;
        private ListBox listBox;

        public Add(ListBox listbox) //constructor, primeste ca parametru listboxul cu universitati
        {
            InitializeComponent();
            this.listBox = listbox;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox_oras.Text.Equals("") && textBox_nume.Text.Equals("")
                && textBox_id.Text.Equals("") && textBox_cod.Text.Equals(""))
            {
                MessageBox.Show("Trebuie completate toate spatiile!!!");
            }
            else
            {
                bool ok = true;
                nume = textBox_nume.Text;
                oras = textBox_oras.Text;

                try
                {
                    id = Convert.ToInt32(textBox_id.Text);
                    cod = Convert.ToInt32(textBox_cod.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("ID-ul si codul sunt numere!");
                    ok = false;
                }

                try
                {
                    myCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Documente\Facultate\Sem2\II\Laboratoare\Lab3\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf; Integrated Security = True");
                    myCon.Open();
                    cmd = new SqlCommand("INSERT INTO Universitati (Id,NameUniv,City,Code) VALUES (@Id,@NameUniv,@City,@Code) ", myCon);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@NameUniv", nume);
                    cmd.Parameters.AddWithValue("@City", oras);
                    cmd.Parameters.AddWithValue("@Code", cod);
                    cmd.ExecuteNonQuery();
                    ok = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Codul este deja folosit!");
                    textBox_cod.Text = "";
                    ok = false;
                }
                if (ok)
                {
                    listBox.Items.Add(nume);
                    myCon.Close();
                    this.Close();
                }
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
