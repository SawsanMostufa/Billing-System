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
    public partial class BuyProducts : Form
    {
        Admin admin = new Admin();
        public BuyProducts()
        {
            InitializeComponent();
        //  textBoxprice.KeyPress += textBoxprice_TextChanged;

            for (int i = 0; i < ParentStors.stores.Count(); i++)
            {
                comboBoxStore.Items.Add(ParentStors.stores[i].Name);


            }
            List<Store> stores = new List<Store>();
            addstorefrm addstorefrm = new addstorefrm();
            foreach (var s in addstorefrm.adminss)
            {
                stores.Add(s);
            }

            foreach (var s in stores)
            {
                comboBoxStore.Items.Add(s);


            }



            for (int i = 0; i < ParentStors.Supliers.Count(); i++)
            {
                comboBoxsuplier.Items.Add(ParentStors.Supliers[i].Name);
            }
            List<Suplier> suplier = new List<Suplier>();
            SuplierForm addsupliersfrm = new SuplierForm();
            foreach (var supp in addsupliersfrm.sup)
            {
                suplier.Add(supp);
            }

            foreach (var supp in suplier)
            {
                comboBoxsuplier.Items.Add(supp);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new AddHallType().ShowDialog();
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
           // new DeletHallType().ShowDialog();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminManagement().ShowDialog();
            this.Close();
        }

        private void Button15_Click(object sender, EventArgs e)
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
           // new BuyProductsnn().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.name = textBoxName.Text;
            p1.Category = textBoxcategory.Text;
            p1.price = int.Parse(textBoxprice.Text);
            p1.material = textBoxmaterial.Text;
            p1.size = textBoxsize.Text;
            p1.color = textBoxcolor.Text;
            p1.date = DateTime.Now;
            p1.supliers = (string)comboBoxsuplier.SelectedItem;
           // p1.quentity = int.Parse(textBoxquentity.Text);
            foreach (Product pooo in Store.products)
            {
                if (pooo.name == textBoxName.Text)
                {
                    pooo.quentity += int.Parse(textBoxquentity.Text);

                    p1.quentity = pooo.quentity;
                    
                }
                else
                {
                    p1.quentity = int.Parse(textBoxquentity.Text);
                }
                //  mynewproduct.custpmers =(string)comboBoxcustomer.SelectedItem;

            }

            string combo = comboBoxStore.Text;
            string[] arr = new string[8];
            arr[0] = textBoxName.Text;
            arr[1] = textBoxcategory.Text;
            arr[2] = (string)comboBoxsuplier.SelectedItem;
            arr[3] = textBoxprice.Text;
            arr[4] = textBoxsize.Text;
            arr[5] = textBoxquentity.Text;
            arr[6] = textBoxcolor.Text;
            arr[7] = textBoxmaterial.Text;
            ListViewItem lv = new ListViewItem(arr);
            listView1.Items.Add(lv);
            Store s = new Store();

            if (combo == p1.Category)
            {
                s.Name = combo;
            }
            admin.addproducts(p1, s);
            // dataGridView1.DataSource = null;
            //  dataGridView1.DataSource = Store.products;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }
        private bool IsNumber(string text)
        {
            int result;
            return int.TryParse(text, out result);

        }
        private void textBoxprice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxquentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxquentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxcategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxmaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
