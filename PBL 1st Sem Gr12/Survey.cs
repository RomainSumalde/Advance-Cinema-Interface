using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_1st_Sem_Gr12
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }
        int q1answer = 0;
        int q2answer = 0;
        int q3answer = 0;
        int q4answer = 0;
        int q5answer = 0;
        int q6answer = 0;
        int q7answer = 0;
        int q8answer = 0;
        int q9answer = 0;
        int q10answer = 0;
        int q11answer = 0; //1 = yes, 0 = no
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            q1answer = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            q1answer = 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
            q2answer = 1;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            q2answer = 0;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
            q3answer = 1;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            q3answer = 0;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            q4answer = 1;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            q4answer = 0;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = false;
            q5answer = 1;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            q5answer = 0;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            q6answer = 1;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            q6answer = 0;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Checked = false;
            q7answer = 1;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox13.Checked = false;
            q7answer = 0;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            checkBox16.Checked = false;
            q8answer = 1;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox15.Checked = false;
            q8answer = 0;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox18.Checked = false;
            q9answer = 1;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Checked = false;
            q9answer = 0;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Checked = false;
            q10answer = 1;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            checkBox19.Checked = false;
            q10answer = 0;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            checkBox22.Checked = false;
            q11answer = 1;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            checkBox21.Checked = false;
            q11answer = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dito nalang natin lagay yung mga sesend sa database
            this.Close();
        }

       
    }
}
