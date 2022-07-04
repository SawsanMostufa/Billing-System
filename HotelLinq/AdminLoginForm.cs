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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void Tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = tb1.Text;
            pass = tb2.Text;
            if (user != null && pass != null)
            {
                if (user == "Admin" || user == "admin" && pass == "Admin" || pass == "admin")
                {
                    contAdminfrm form5 = new contAdminfrm();
                    form5.Show();
                    //this.Close();
                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Wrong User_Name Or Password .. !";
                }
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Please Enter User_Name and Password ... !";
            }



            //this.Hide();
            //new contAdminfrm().ShowDialog();
            //this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new AdminManagement().ShowDialog();
            //this.Close();

        
        }
    }
}
