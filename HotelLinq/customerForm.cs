using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelLinq
{
    public partial class customerForm : Form
    {
        Customers c = null;
        Admin admin = new Admin();
        internal List<Customers> cust = new List<Customers>();
        public customerForm()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminManagement().ShowDialog();
            this.Close();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            c = new Customers();
            c.Name = textBoxName.Text;
            c.phone = int.Parse(textBoxphone.Text);
            c.ID = int.Parse(textBoxID.Text);
            cust.Add(c);
            admin.addcustomer(cust);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cust;

            comboBoxStore.Items.Add(c.Name);

            //this.Hide();
            ////new AddHall().ShowDialog();
            //this.Close();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            new contAdminfrm().ShowDialog();
            this.Close();
        }

        private void Button14_Click(object sender, EventArgs e)
        {

            ParentStors.Customers.RemoveAt(comboBoxStore.SelectedIndex);
            comboBoxStore.Items.Remove(comboBoxStore.SelectedItem);
            //  this.Hide();
            ////  new DeletHallType().ShowDialog();
            //  this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new AddHouseKeeping().ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new HotelConfigRoomType().ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new addstorefrm().ShowDialog();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BuyProducts().ShowDialog();
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SuplierForm().ShowDialog();
            this.Close();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportFRM().ShowDialog();
            this.Close();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        //    new HotelConfigAmenities().ShowDialog();
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new HotelConfigHouseKeeping().ShowDialog();
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new sellbill().ShowDialog();
            this.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  new BuyProductsnn().ShowDialog();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {
            Regex RePhone = new Regex("^(011|012|010|015)[0-9]{8}");
            bool IsValidPhone = RePhone.IsMatch(textBoxphone.Text);
            if (!IsValidPhone)
            {
                labelCpohone.Visible = true;
            }
            else
            {
                labelCpohone.Visible = false;
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            Regex ReID = new Regex("^[0-9]");
            bool IsValidID = ReID.IsMatch(textBoxID.Text);
            if (!IsValidID)
            {
                labelID.Visible = true;
            }
            else
            {
                labelID.Visible = false;
            }
        }
    }
}
