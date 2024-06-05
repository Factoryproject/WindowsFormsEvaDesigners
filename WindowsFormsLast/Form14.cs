using How_to_use_the_app_choice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worker_works;

namespace Wroker_activitys
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 ss = new Form13();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 zz = new Form15();
            zz.Show();
        }
    }
}
