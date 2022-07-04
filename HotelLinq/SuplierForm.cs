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
    public partial class SuplierForm : Form
    {
        Admin admin = new Admin();
        internal List<Suplier> sup = new List<Suplier>();
        Suplier s = null;
        public SuplierForm()
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
            this.Hide();
           // new AddRooms().ShowDialog();
            this.Close();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new AddHouseKeeping().ShowDialog();
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
         //   new HotelConfigAmenities().ShowDialog();
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
          //  new EditRoom().ShowDialog();
            this.Close();

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new DeletRoom().ShowDialog();
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

        private void Button12_Click_1(object sender, EventArgs e)
        {
            s = new Suplier();
            s.Name = textBoxName.Text;
            s.Phone = int.Parse(textBoxphone.Text);
            s.Category = textBoxCategory.Text;
            //foreach (Suplier item in ParentStors.Supliers)
            //{
            //    if (item.ID == int.Parse(textBoxID.Text))
            //    {
            //        //labelID.Text = "the ID is Exist enter another ID ";
            //        labelprimary.Visible = true;
            //        //dataGridView1.DataSource = null;




            //    }
            //    else
            //    {
            //        labelprimary.Visible = false;
            //        s.ID = int.Parse(textBoxID.Text);


            //    }

            //}
            s.ID = int.Parse(textBoxID.Text);
            sup.Add(s);
            admin.addsublier(sup);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sup;
            comboBoxStore.Items.Add(s.Name);

            //s.ID = int.Parse(textBoxID.Text);


            // ParentStors.Supliers.Add(s);


            //  this.Hide();
            ////  new AddPrice().ShowDialog();
            //  this.Close();
        }

        private void Button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new contAdminfrm().ShowDialog();
            this.Close();
        }

        private void Button14_Click_1(object sender, EventArgs e)
        {

            ParentStors.Supliers.RemoveAt(comboBoxStore.SelectedIndex);
            comboBoxStore.Items.Remove(comboBoxStore.SelectedItem);

            //  this.Hide();
            ////  new DeletPrice().ShowDialog();
            //  this.Close();
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //new HotelConfigHouseKeeping().ShowDialog();
            this.Close();
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
          //  new HotelConfigAmenities().ShowDialog();
            this.Close();
        }

        private void Button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new ReportFRM().ShowDialog();
            this.Close();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
          //  new BuyProductsnn().ShowDialog();
            this.Close();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new sellbill().ShowDialog();
            this.Close();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new customerForm().ShowDialog();
            this.Close();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new BuyProducts().ShowDialog();
            this.Close();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new addstorefrm().ShowDialog();
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
          //  new HotelConfigRoomType().ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {
            Regex RePhone = new Regex("^(011|012|010|015)[0-9]{8}");
            bool IsValidPhone = RePhone.IsMatch(textBoxphone.Text);
            if (!IsValidPhone)
            {
                labelSphone.Visible = true;
            }
            else
            {
                labelSphone.Visible = false;
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            Regex ReID = new Regex("^[0-9]");
            bool IsValidID = ReID.IsMatch(textBoxID.Text);
            if (!IsValidID)
            {
                labelprimary.Visible = true;
            }
            else
            {
                labelprimary.Visible = false;
            }


        }

        private void labelID_Click(object sender, EventArgs e)
        {
            //if()
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e .KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
