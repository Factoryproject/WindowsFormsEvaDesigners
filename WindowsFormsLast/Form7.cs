using Machine_choice_admin;
using Product_for_admin;
using Room_Choice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workers_to_start_working
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 uu = new Form8();
            uu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 tt = new Form9();
            tt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 tt = new Form11();
            tt.Show();
        }
    }
}
