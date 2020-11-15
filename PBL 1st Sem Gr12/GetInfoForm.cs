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
    public partial class GetInfoForm : Form
    {
        public GetInfoForm(string stringCinema, string stringTime, string seatNumber)
        {
            InitializeComponent();
            comboBox2.Text = stringCinema;
            comboBox3.Text = stringTime;
            textBox6.Text = seatNumber;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Survey aForm = new Survey();
            aForm.Show();
            this.Hide();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
