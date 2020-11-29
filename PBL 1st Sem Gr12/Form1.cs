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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            design();
        }

        private void design()
        {
            //Hides Panel of View and Help
            panelView.Visible = false;
        }

        private void hideSubMenu()
        {
            //Hides if One of the Panel is Open
            if (panelView.Visible == true)
                panelView.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (panelView.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Movie Button
        private void buttonMovie_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            pictureBox3.Visible = false;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            panelMain.BringToFront();
        }
        //View Button
        private void buttonView_Click(object sender, EventArgs e)
        {
            showSubMenu(panelView);
        }
        private void buttonViewSeats_Click(object sender, EventArgs e)
        {
            openForm(new SeatForm(panelMain));
            //SeatForm aForm = new SeatForm();
            //aForm.Show();
            hideSubMenu();
        }

        private void buttonViewRecords_Click(object sender, EventArgs e)
        {
            openForm(new RecordForm());
       
            //RecordForm aForm = new RecordForm();
            //aForm.Show();
            hideSubMenu();
        }

        //Submit Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            string time = comboBox1.Text;
            if (time == "11:00AM")
            {
                seat1Button.BringToFront();
            }
            if (time == "4:00PM")
            {
                seat2Button.BringToFront();
                //openForm(new SeatForm2(panelMain));
                //SeatForm2 aForm = new SeatForm2();
                //aForm.Show();
            }
            string time2 = comboBox2.Text;
            if (time2 == "11:00AM")
            {
                seat3Button.BringToFront();
                //openForm(new Seatform3(panelMain));
            }
            if (time2 == "4:00PM")
            {
                seat4Button.BringToFront();
                //openForm(new Seatform4(panelMain));
            }
            if (time == " " || time2 == " ")
            {
                MessageBox.Show("Invalid Time Entry! Please Try Again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Help Button
        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;

        private void openForm(Form panelForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = panelForm;
            panelForm.TopLevel = false;
            //panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(panelForm);
            panelMain.Tag = panelForm;
            panelForm.BringToFront();
            panelForm.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // panelMain.BringToFront();
        }
        string cinema1 = "1", cinema2 = "2", cinema3 = "3", cinema4 = "4";
        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick("A1", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick("A2", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick("A3", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick("A4", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick("A5", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick("A6", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick("A7", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick("A8", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick("A9", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonClick("A10", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonClick("B1", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonClick("B2", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonClick("B3", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonClick("B4", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonClick("B5", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonClick("B6", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonClick("B7", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonClick("B8", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonClick("B9", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonClick("B10", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonClick("C1", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonClick("C2", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonClick("C3", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttonClick("C4", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonClick("C5", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            buttonClick("C6", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            buttonClick("C7", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            buttonClick("C8", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            buttonClick("C9", cinema1, time1);
            panelMain.BringToFront();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            buttonClick("C10", cinema1, time1);
            panelMain.BringToFront();
        }

        string time1 = "11:00AM", time2 = "4:00PM";
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void buttonClick(string seatNumber, string cinema, string time)
        {
            string seatNum = seatNumber;
            foreach (Control button in panel2.Controls.OfType<Button>())
            {
                if (button.Text == seatNum)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
            }
            openForm(new GetInfoForm(cinema, time, seatNum));
            
        }
    }
}
