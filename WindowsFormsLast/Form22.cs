using Machine_in_process_for_medicine;
using Non_product_item_condition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_iss
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form23 hh = new Form23();
            hh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form24 hh = new Form24();
            hh.Show();
        }
    }
}
