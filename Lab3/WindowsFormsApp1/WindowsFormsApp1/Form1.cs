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
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection(); //creaza o noua conexiune SQL
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet dsUniv; //avem doua tabele, Universitati si Facultati
        DataSet dsFac;
        DataSet dataSet;
        DataTable sTable;

        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documente\Facultate\Sem2\II\Laboratoare\Lab3\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True"; //adaugam baza de date Database1.mdf la conexiune.
            myCon.Open(); //deschidem conexiunea

            dsUniv = new DataSet(); 
            dsFac = new DataSet();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon); //select all from Universitati, transmitem la daUniv
            daUniv.Fill(dsUniv, "Universitati"); //adauga sau da refresh la date in dsUniv sa se potriveasca cu cele din data source
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows) //pentru fiecare rand din tabela Universitati
            {
                String name = dr.ItemArray.GetValue(1).ToString(); //luam in variabila name itemul al doilea (adica [1]) care e numele universitatii
                listBox_Univ.Items.Add(name); //si il adaugam in listboxul cu universitati
            }
            myCon.Close(); //inchidem conexiunea
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documente\Facultate\Sem2\II\Laboratoare\Lab3\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            connection.Open();

            sCommand = new SqlCommand("SELECT * FROM Facultati", connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            dataSet = new DataSet();

            sAdapter.Fill(dataSet, "Facultati");
            sTable = dataSet.Tables["Facultati"];
            
            connection.Close();

            dataGridView1.DataSource = dataSet.Tables["Facultati"];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void listbox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear(); //sterge elementele ramase de dinainte din textbox
            textBox_City.Clear(); //stergem orasul scris in textbox, il vom inlocui
            int code = 0;

            String UnivSelected = listBox_Univ.SelectedItem.ToString(); //luam numele universitatii selectate din listbox
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows) //pentru fiecare rand din tabela universitati
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString()) //cautam universitatea selectata si cand o gasim
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString(); //modificam orasul din textbox cu cel al universitatii
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_CodeUniv.Text = code.ToString(); //si modificam si codul universitatii cu cel al celei selectate
                }
            }

            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows) //verificam pt fiecare facultate
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1))) //daca codul universitatii corespunde cu cel al facultatii
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString(); //luam numele facultatii
                    listBox_Fac.Items.Add(nameFac);                       //si il punem in listboxul cu Facultati
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(listBox_Univ);
            delete.Show();
        }

        private void addUniv_Click(object sender, EventArgs e)
        {
            Add add = new Add(listBox_Univ);
            add.Show();
        }

        private void updateUniv_Click(object sender, EventArgs e)
        {
            Update update = new Update(listBox_Univ);
            update.Show();
        }

        private void addFac_Click(object sender, EventArgs e)
        {
            sBuilder = new SqlCommandBuilder(sAdapter);
            sAdapter.Update(sTable);
            MessageBox.Show("Facultatea a fost modificata!"); 
        }

        private void delFac_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            sAdapter.Update(sTable);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
