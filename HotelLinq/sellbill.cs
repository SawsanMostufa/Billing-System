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
    public partial class sellbill : Form
    {
        ParentStors p = new ParentStors();

        Admin admin = new Admin();
        Product mypoduct = null;
        List<Product> listofchoesedroduct = new List<Product>();
      //  List<Product> listofbill = new List<Product>();
        double totalPrice = 0;
        public sellbill()
        {
            InitializeComponent();

            for (int i = 0; i < ParentStors.stores.Count(); i++)
            {
                comboBox1.Items.Add(ParentStors.stores[i].Name);


            }
            //List<Store> stores = new List<Store>();
            //addstorefrm addstorefrm = new addstorefrm();
            //foreach (var s in addstorefrm.adminss)
            //{
            //    stores.Add(s);
            //}

            //foreach (var s in stores)
            //{
            //    comboBox1.Items.Add(s);


            //}


            //*************************************************

            for (int i = 0; i < ParentStors.Customers.Count(); i++)
            {
                comboBoxcustomer.Items.Add(ParentStors.Customers[i].Name);
            }
            //List<Customers> customer = new List<Customers>();
            //customerForm custoerform = new customerForm();
            //foreach (var cus in custoerform.cust)
            //{
            //    customer.Add(cus);
            //}

            //foreach (var s in customer)
            //{
            //    comboBoxcustomer.Items.Add(s);
            //}



        }


        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click_1(object sender, EventArgs e)
        {


            Product mynewproduct = null;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                mynewproduct = new Product();
                var p = item.Cells[1].Value.ToString();
                var newp = int.Parse(p);
                // var q = item.Cells[9].Value.ToString();
                //var quentities = Convert.ToDecimal(q);

                var thenewprice = numericUpDown1.Value * newp;

                totalPrice += (double)thenewprice;
                label5.Text = totalPrice.ToString();

                mynewproduct.name = item.Cells[0].Value.ToString();
                mynewproduct.price = int.Parse(item.Cells[1].Value.ToString());
                mynewproduct.size = item.Cells[2].Value.ToString();
                mynewproduct.color = item.Cells[3].Value.ToString();
                mynewproduct.material = item.Cells[4].Value.ToString();
                mynewproduct.Category = item.Cells[5].Value.ToString();
                mynewproduct.custpmers = comboBoxcustomer.SelectedItem.ToString();
                mynewproduct.supliers = item.Cells[7].Value.ToString();
                mynewproduct.date = DateTime.Now;
              //  mynewproduct.quentity = int.Parse(numericUpDown1.Value.ToString());
                foreach (Product pooo in Store.products)
                {
                    if ((pooo.name == mynewproduct.name) && (pooo.quentity> (int.Parse(numericUpDown1.Value.ToString()))))
                    {
                        pooo.quentity -= int.Parse(numericUpDown1.Value.ToString());

                        mynewproduct.quentity = int.Parse(numericUpDown1.Value.ToString());
                       // break;
                    }
                    else
                    {
                      //  MessageBox.Show("quentity no enough");
                    }
                    //  mynewproduct.custpmers =(string)comboBoxcustomer.SelectedItem;

                }
            }
            Store.listofbill.Add(mynewproduct);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Store.listofbill;

            //  this.Hide();
            ////  new AddPaidService().ShowDialog();
            //  this.Close();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new SuplierForm().ShowDialog();
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
         //   new DeletPaidService().ShowDialog();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminManagement().ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new HotelConfigRoomType().ShowDialog();
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
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

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new customerForm().ShowDialog();
            this.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  new BuyProductsnn().ShowDialog();
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
          //  new HotelConfigAmenities().ShowDialog();
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new HotelConfigHouseKeeping().ShowDialog();
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {


            //ComboBox c = comboBox1;

            string test = comboBox1.Text.ToString();
            dataGridView1.DataSource = Store.GetProducts(test);
            //foreach (Store s in ParentStors.stores)
            //{   if (s.Name == test)
            //    {
            //        dataGridView1.DataSource = s.products;
            //    }

            //}
        }

        private void sellbill_Load(object sender, EventArgs e)
        {

        }
    }
}
