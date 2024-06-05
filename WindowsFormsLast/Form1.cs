using Log_in_for_worker;
using Log_in_info_for_admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_started
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 mm = new Form3();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 ee = new Form12();
            ee.Show();
        }
    }
}
