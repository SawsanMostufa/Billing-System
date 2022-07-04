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
    public partial class ReportFRM : Form
    {
        public ReportFRM()
        {
            InitializeComponent();
            for (int i = 0; i < ParentStors.stores.Count(); i++)
            {
                comboBox1.Items.Add(ParentStors.stores[i].Name);


            }
            List<Store> stores = new List<Store>();
            addstorefrm addstorefrm = new addstorefrm();
            foreach (var s in addstorefrm.adminss)
            {
                stores.Add(s);
            }

            foreach (var s in stores)
            {
                comboBox1.Items.Add(s);


            }



            for (int i = 0; i < ParentStors.Supliers.Count(); i++)
            {
                comboBox3.Items.Add(ParentStors.Supliers[i].Name);
            }
            //List<Suplier> suplier = new List<Suplier>();
            //SuplierForm addsupliersfrm = new SuplierForm();
            //foreach (var supp in addsupliersfrm.sup)
            //{
            //    suplier.Add(supp);
            //}

            //foreach (var supp in suplier)
            //{
            //    comboBox2.Items.Add(supp);
            //}

            //*******************************************************************

            for (int i = 0; i < ParentStors.Customers.Count(); i++)
            {
                comboBox2.Items.Add(ParentStors.Customers[i].Name);
            }
            //List<Customers> customer = new List<Customers>();
            //customerForm custoerform = new customerForm();
            //foreach (var cus in custoerform.cust)
            //{
            //    customer.Add(cus);
            //}

            //foreach (var s in customer)
            //{
            //    comboBox3.Items.Add(s);
            //}

        }

        private void Button5_Click(object sender, EventArgs e)
        {

            this.Hide();
           // new AdminManagement().ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  new AddFloor().ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            //new HotelConfigRoomType().ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            new addstorefrm().ShowDialog();
            this.Close();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

            this.Hide();
            //new HotelConfigAmenities().ShowDialog();
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            this.Hide();
           // new HotelConfigHouseKeeping().ShowDialog();
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
            this.Hide();
           // new DeletFloor().ShowDialog();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BuyProducts().ShowDialog();
            this.Close();
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
           // new BuyProductsnn().ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string test = comboBox1.Text.ToString();
            dataGridView1.DataSource = Store.GetProducts(test);
            //foreach (Store s in ParentStors.stores)
            //{   if (s.Name == test)
            //    {
            //        dataGridView1.DataSource = s.products;
            //    }

            //}
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string test = comboBox2.Text.ToString();
            dataGridView2.DataSource = null;
           dataGridView2.DataSource = Store.GetProductsforcustomer(test);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string test = comboBox3.Text.ToString();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Store.GetProductsforsuplier(test);
        }
    }
}
