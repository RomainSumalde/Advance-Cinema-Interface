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
    public partial class SeatForm : Form
    {
        public SeatForm()
        {
            InitializeComponent();
        }
        private void buttonClick(Button btn)
        {
            string seatNum = btn.ToString();
            btn.BackColor = Color.Red;
            GetInfoForm aForm = new GetInfoForm();
            aForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonClick(button10);
        }
    }
}
