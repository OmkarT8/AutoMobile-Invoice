using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoManufacture
{
    public partial class SplashSc : Form
    {
        public SplashSc()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void SplashSc_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 5000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {
            tmr.Stop();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void SplashSc_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
