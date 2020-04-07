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
    public partial class Update : Form
    {
        SqlCommand cmd;
        SqlConnection myCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Documente\Facultate\Sem2\II\Laboratoare\Lab3\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf; Integrated Security = True");
        private DataSet dsUniv;
        private string nume;
        private string oras;
        private int id;
        private int cod;
        private ListBox listBox;

        public Update(ListBox listBox)
        {
            this.listBox = listBox;
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void buton_update_Click(object sender, EventArgs e)
        {
            myCon.Open();
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
                listBox.Items.Clear();

                try
                {
                    id = int.Parse(textBox_id.Text);
                    cod = Convert.ToInt32(textBox_cod.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                    ok = false;
                }

                if (ok)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Universitati SET City= @City, NameUniv= @Name, Id= @Id WHERE Code= @Code ", myCon);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", nume);
                        cmd.Parameters.AddWithValue("@City", oras);
                        cmd.Parameters.AddWithValue("@Code", cod);
                        cmd.ExecuteNonQuery();
                        ok = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Code");
                        textBox_cod.Text = "";
                        ok = false;
                    }
                    dsUniv = new DataSet();
                    SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
                    daUniv.Fill(dsUniv, "Universitati");
                    foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                    {
                        String name = dr.ItemArray.GetValue(1).ToString();
                        listBox.Items.Add(name);
                    }
                    
                    if (ok)
                    {
                        MessageBox.Show("Datele au fost actualizate!!!");
                        this.Close();
                    }
                }
            }
            myCon.Close();
        }
    }
}
