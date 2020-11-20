using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PBL_1st_Sem_Gr12
{
    public partial class RecordForm : Form
    {
        string connectString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PBL; Integrated Security = True;";
        SqlConnection connection;
        SqlDataAdapter adapt;
        DataTable table;

        public RecordForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectString);
            connection.Open();
            string queryString = "SELECT * FROM infoPBL;";
            SqlCommand command1 = new SqlCommand(queryString, connection);
            adapt = new SqlDataAdapter(queryString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView1.DataSource = table;
            command1.ExecuteNonQuery();
            dataGridView1.BackColor = Color.WhiteSmoke;
            string surveyString = "SELECT * FROM surveyPBL;";
            SqlCommand command2 = new SqlCommand(surveyString, connection);
            adapt = new SqlDataAdapter(surveyString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView2.DataSource = table;
            command2.ExecuteNonQuery();
            dataGridView2.BackColor = Color.WhiteSmoke;
            connection.Close();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            string queryString = "SELECT * FROM surveyPBL;";
            SqlCommand command = new SqlCommand(queryString, connection);
            adapt = new SqlDataAdapter(queryString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView1.DataSource = table;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            string queryString = "SELECT * FROM infoPBL;";
            SqlCommand command = new SqlCommand(queryString, connection);
            adapt = new SqlDataAdapter(queryString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView1.DataSource = table;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
