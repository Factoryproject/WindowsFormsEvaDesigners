using Room_clean;
using Room_is_under_cleaning_condtion;
using Room_is_waste_condition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_isss
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 kk = new Form18();
            kk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 cc = new Form19();
            cc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form20 cc = new Form20();
            cc.Show();
        }
    }
}
