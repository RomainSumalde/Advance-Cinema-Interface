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
        string cinema = "1";
        string time = "11:00AM";
        private void buttonClick(Button btn)
        {
            string seatNum = btn.ToString();
            btn.BackColor = Color.Red;
            GetInfoForm aForm = new GetInfoForm(cinema, time);
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

        private void button11_Click(object sender, EventArgs e)
        {
            buttonClick(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonClick(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonClick(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonClick(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonClick(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonClick(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonClick(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonClick(button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonClick(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonClick(button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonClick(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonClick(button22);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonClick(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttonClick(button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonClick(button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            buttonClick(button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            buttonClick(button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            buttonClick(button28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            buttonClick(button29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            buttonClick(button30);
        }
    }
}
