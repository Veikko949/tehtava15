using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tehtava15
{
    public partial class Form1 : Form
    {
        private Stopwatch ajastin;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aika_label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", ajastin.Elapsed);
        }

        private void kaynista_button1_Click(object sender, EventArgs e)
        {
            ajastin.Start();
        }

        private void pysayta_button1_Click(object sender, EventArgs e)
        {
            ajastin.Stop();
        }

        private void uudeleen_button1_Click(object sender, EventArgs e)
        {
            ajastin.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ajastin = new Stopwatch();
        }
    }
}
