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
    public partial class contAdminfrm : Form
    {
        public contAdminfrm()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new BuyProductsnn().ShowDialog();
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportFRM().ShowDialog();
            this.Close();
        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new customerForm().ShowDialog();
            this.Close();
        }

        private void LogChoose_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new sellbill().ShowDialog();
            this.Close();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SuplierForm().ShowDialog();
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BuyProducts().ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new addstorefrm().ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminManagement().ShowDialog();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            new AdminLoginForm().ShowDialog();
            this.Close();
        }
    }
}
