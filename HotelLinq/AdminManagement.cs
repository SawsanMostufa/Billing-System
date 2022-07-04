using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelLinq
{
    public partial class AdminManagement : Form
    {
        public AdminManagement()
        {
            InitializeComponent();
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLoginForm().ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  new HotelConfigRoomType().ShowDialog();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new ResetPassword().ShowDialog();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        //    new HRManagement().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //string user, pass;
            //user = textBox1.Text;
            //pass = textBox2.Text;
            //if (user != null && pass != null)
            //{
            //    if (user == "Admin" || user == "admin" && pass == "Admin" || pass == "admin")
            //    {
            //        contAdminfrm form5 = new contAdminfrm();
            //        form5.Show();
            //        //this.Close();
            //    }
            //    else
            //    {
            //        label3.Visible = true;
            //        label3.Text = "Wrong User_Name Or Password .. !";
            //    }
            //}
            //else
            //{
            //    label3.Visible = true;
            //    label3.Text = "Please Enter User_Name and Password ... !";
            //}
        }
    }
}
