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
    public partial class Form1 : Form
    {
        int c1 = 0, c2 = 0, len1 = 0, len2 = 0;

        string s1 = "", s2 = "";

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (c1 < len1)
            {
                c1 += 1;
                lb_welcome.Text = s1.Substring(0, c1);
            }
            else
            {
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            c2 += 1;
            if (c2 > len2)
            {
                c2 = 0;
                lbChoose.Text = "";
            }
            else
            {
                lbChoose.Text = s2.Substring(0, c2);
                if (lbChoose.ForeColor == Color.Black) lbChoose.ForeColor = Color.AliceBlue;
                else lbChoose.ForeColor = Color.Black;
            }
            btnArabic.Visible = true;
           

        }

        private void lbChoose_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s1 = lb_welcome.Text;
            len1 = s1.Length;
            lb_welcome.Text = "";
            timer1.Start();
            btnArabic.Visible = false;
          
            s2 = lbChoose.Text;
            len2 = s2.Length;
            lbChoose.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnArabic_Click(object sender, EventArgs e)
        {
            //  lang = "ar";
            this.Hide();
            timer2.Stop();
            new welcom2().ShowDialog();
            this.Close();
        }

        private void BtnEnglish_Click(object sender, EventArgs e)
        {
            // lang = "en";
            this.Hide();
            timer2.Stop();
            new contAdminfrm().ShowDialog();
            this.Close();
        }
    }
}
