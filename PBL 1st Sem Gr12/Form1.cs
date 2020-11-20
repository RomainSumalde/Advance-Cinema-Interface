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
            panelHelp.Visible = false;
        }

        private void hideSubMenu()
        {
            //Hides if One of the Panel is Open
            if (panelView.Visible == true)
                panelView.Visible = false;
            if (panelHelp.Visible == true)
                panelHelp.Visible = false;
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            panelMain.Show();
            pictureBox3.Visible = false;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
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
                openForm(new SeatForm(panelMain));
            }
            if (time == "4:00PM")
            {
                openForm(new SeatForm2(panelMain));
                //SeatForm2 aForm = new SeatForm2();
                //aForm.Show();
            }
            string time2 = comboBox2.Text;
            if (time2 == "11:00AM")
            {
                openForm(new Seatform3(panelMain));
            }
            if (time2 == "4:00PM")
            {
                openForm(new Seatform4(panelMain));
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
            showSubMenu(panelHelp);
        }
        private void buttonHelpContact_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonHelpLocation_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonHelpAboutUs_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null;

        private void openForm(Form panelForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = panelForm;
            panelForm.TopLevel = false;
            panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(panelForm);
            panelMain.Tag = panelForm;
            panelForm.BringToFront();
            panelForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
