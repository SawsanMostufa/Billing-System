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
    public partial class welcom2 : Form
    {
        int count = 0;
        public welcom2()
        {
            InitializeComponent();
        }

        private void Welcom2_Load(object sender, EventArgs e)
        {
            lb_num.Text = "";
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 5;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            count += 5;
            if (count < 100)
                lb_num.Text = count.ToString() + "   %";
            else
            { count = 0; lb_num.Text = ""; }

            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                new AdminLoginForm().ShowDialog();
                this.Close();
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
