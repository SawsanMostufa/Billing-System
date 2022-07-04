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
    public partial class addstorefrm : Form
    {
        ParentStors p = new ParentStors();

        Admin admin = new Admin();
        Store s = null;
        internal List<Store> adminss = new List<Store>();
        internal List<Store> listdelete = new List<Store>();
        public addstorefrm()
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
            s = new Store();
            s.Name = textBoxName.Text;
            adminss.Add(s);
            admin.addstore(adminss);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = adminss;

            comboBox1.Items.Add(s.Name);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  new AddHouseKeeping().ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
          //  new HotelConfigRoomType().ShowDialog();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            new BuyProducts().ShowDialog();
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
           // new HotelConfigAmenities().ShowDialog();
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            this.Hide();
          //  new HotelConfigHouseKeeping().ShowDialog();
            this.Close();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            new contAdminfrm().ShowDialog();
            this.Close();

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            ParentStors.stores.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Items.Remove(comboBox1.SelectedItem);

            // this.Hide();
            //// new DeletRoom().ShowDialog();
            // this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            new customerForm().ShowDialog();
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SuplierForm().ShowDialog();
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
         //   new BuyProductsnn().ShowDialog();
            this.Close();
        }

        private void HotelConfigRooms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           // new ReportSell().ShowDialog();
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
