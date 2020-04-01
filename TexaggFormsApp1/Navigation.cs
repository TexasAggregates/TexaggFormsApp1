using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexaggFormsApp1
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets Ti = new Tickets();
            Ti.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
