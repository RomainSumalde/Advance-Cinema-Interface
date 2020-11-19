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
    public partial class Survey : Form
    {
        public Survey(string nameTransfer)
        {
            InitializeComponent();
            textBox1.Text = nameTransfer;
        }

        int q1answer = 1;
        int q2answer = 1;
        int q3answer = 1;
        int q4answer = 1;
        int q5answer = 1;
        int q6answer = 1;
        int q7answer = 1;
        int q8answer = 1;
        int q9answer = 1;
        int q10answer = 1;
        int q11answer = 1; //2 = yes, 1 = no

        //public void ifelseStatement()
        //{
        //    string q1String;
        //    string q2String;
        //    string q3String;
        //    string q4String;
        //    string q5String;
        //    string q6String;
        //    string q7String;
        //    string q8String;
        //    string q9String;
        //    string q10String;
        //    string q11String;
        //    string yes = "Yes";
        //    string no = "No";
        //    if (q1answer == 1)
        //    {
        //        q1String = no;
        //    }
        //    else
        //    {
        //        q1String = yes;
        //    }
        //    if (q2answer == 1)
        //    {
        //        q2String = no;
        //    }
        //    else
        //    {
        //        q2String = yes;
        //    }
        //    if (q3answer == 1)
        //    {
        //        q3String = no;
        //    }
        //    else
        //    {
        //        q3String = yes;
        //    }
        //    if (q4answer == 1)
        //    {
        //        q4String = no;
        //    }
        //    else
        //    {
        //        q4String = yes;
        //    }
        //    if (q5answer == 1)
        //    {
        //        q5String = no;
        //    }
        //    else
        //    {
        //        q5String = yes;
        //    }
        //    if (q6answer == 1)
        //    {
        //        q6String = no;
        //    }
        //    else
        //    {
        //        q6String = yes;
        //    }
        //    if (q7answer == 1)
        //    {
        //        q7String = no;
        //    }
        //    else
        //    {
        //        q7String = yes;
        //    }
        //    if (q8answer == 1)
        //    {
        //        q8String = no;
        //    }
        //    else
        //    {
        //        q8String = yes;
        //    }
        //    if (q9answer == 1)
        //    {
        //        q9String = no;
        //    }
        //    else
        //    {
        //        q9String = yes;
        //    }
        //    if (q10answer == 1)
        //    {
        //        q10String = no;
        //    }
        //    else
        //    {
        //        q10String = yes;
        //    }
        //    if (q11answer == 1)
        //    {
        //        q11String = no;
        //    }
        //    else
        //    {
        //        q11String = yes;
        //    }
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            q1answer = 2;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            q1answer = 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
            q2answer = 2;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            q2answer = 1;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
            q3answer = 2;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            q3answer = 1;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            q4answer = 2;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            q4answer = 1;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = false;
            q5answer = 2;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            q5answer = 1;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            q6answer = 2;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            q6answer = 1;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Checked = false;
            q7answer = 2;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox13.Checked = false;
            q7answer = 1;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            checkBox16.Checked = false;
            q8answer = 2;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox15.Checked = false;
            q8answer = 1;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox18.Checked = false;
            q9answer = 2;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Checked = false;
            q9answer = 1;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Checked = false;
            q10answer = 2;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            checkBox19.Checked = false;
            q10answer = 1;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            checkBox22.Checked = false;
            q11answer = 2;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            checkBox21.Checked = false;
            q11answer = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dito nalang natin lagay yung mga sesend sa database
            //string nameString = textBox1.Text;
            //ifelseStatement();
            //string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PBL; Integrated Security = True;";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //string queryString = "INSERT INTO surveyPBL VALUES(@Name, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11)";
            //SqlParameter param1 = new SqlParameter("@Name", nameString);
            //SqlParameter param2 = new SqlParameter("@Q1", q1String);
            //SqlParameter param3 = new SqlParameter("@Q2", genderString);
            //SqlParameter param4 = new SqlParameter("@Q3", contactNumberString);
            //SqlParameter param5 = new SqlParameter("@Q4", addressString);
            //SqlParameter param6 = new SqlParameter("@Q5", emailString);
            //SqlParameter param7 = new SqlParameter("@Q6", cinemaNumberString);
            //SqlParameter param8 = new SqlParameter("@Q7", seatNumberString);
            //SqlParameter param9 = new SqlParameter("@Q8", timeString);
            //SqlParameter param10 = new SqlParameter("@Q9", dateString);
            //SqlParameter param11 = new SqlParameter("@Q10", dateString);
            //SqlParameter param12 = new SqlParameter("@Q11", dateString);
            //SqlCommand command = new SqlCommand(queryString, connection);
            //command.Parameters.Add(param1);
            //command.Parameters.Add(param2);
            //command.Parameters.Add(param3);
            //command.Parameters.Add(param4);
            //command.Parameters.Add(param5);
            //command.Parameters.Add(param6);
            //command.Parameters.Add(param7);
            //command.Parameters.Add(param8);
            //command.Parameters.Add(param9);
            //command.Parameters.Add(param10);
            //command.ExecuteNonQuery();
            //connection.Close();
            //MessageBox.Show("Your information has been registered succesfully.", "New Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}
