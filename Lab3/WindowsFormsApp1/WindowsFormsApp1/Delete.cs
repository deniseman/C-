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
    public partial class Delete : Form
    {
        SqlCommand cmd;
        SqlConnection myCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Documente\Facultate\Sem2\II\Laboratoare\Lab3\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf; Integrated Security = True");
        private DataSet dsUniv;
        private int cod;
        private ListBox listbox;
        public Delete(ListBox listBox)
        {
            this.listbox = listBox;
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_delete.Equals(""))
            {
                MessageBox.Show("Introduceti un numar!!!");
            }
            else
            {
                bool ok = true;
                myCon.Open();
                listbox.Items.Clear();

                try
                {
                    cmd = new SqlCommand("DELETE FROM Universitati WHERE Code= @code", myCon);
                    cmd.Parameters.AddWithValue("code", textBox_delete.Text);
                    cmd.ExecuteNonQuery();
                    ok = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Codul nu a fost gasit in baza de date!!");
                    ok = false;
                }

                dsUniv = new DataSet();
                SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
                daUniv.Fill(dsUniv, "Universitati");
                foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                {
                    String name = dr.ItemArray.GetValue(1).ToString();
                    listbox.Items.Add(name);
                }
                myCon.Close();

                if (ok)
                {
                    MessageBox.Show("Universitatea a fost stearsa din baza de date!!");
                    this.Close();
                }

            }
        }
    }
}
