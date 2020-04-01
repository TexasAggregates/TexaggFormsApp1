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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tICKETSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tICKETSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tEXAGG1DataSet);

        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEXAGG1DataSet.TICKETS' table. You can move, or remove it, as needed.
            this.tICKETSTableAdapter.Fill(this.tEXAGG1DataSet.TICKETS);

        }

        private void cUSTOMER_NBRComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tKTNOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tKTNOLabel_Click(object sender, EventArgs e)
        {

        }

        private void pLANTLabel_Click(object sender, EventArgs e)
        {

        }

        private void pLANTTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMER_NBRLabel_Click(object sender, EventArgs e)
        {

        }

        private void cUSTOMER_NBRComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dATELabel_Click(object sender, EventArgs e)
        {

        }

        private void dATEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mATERIALLabel_Click(object sender, EventArgs e)
        {

        }

        private void mATERIALComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gROSSLabel_Click(object sender, EventArgs e)
        {

        }

        private void gROSSTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tARELabel_Click(object sender, EventArgs e)
        {

        }

        private void tARETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nETLabel_Click(object sender, EventArgs e)
        {

        }

        private void nETTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tONSLabel_Click(object sender, EventArgs e)
        {

        }

        private void tONSTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tRUCKLabel_Click(object sender, EventArgs e)
        {

        }

        private void tRUCKTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dRIVERLabel_Click(object sender, EventArgs e)
        {

        }

        private void dRIVERTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tRKTYPLabel_Click(object sender, EventArgs e)
        {

        }

        private void tRKTYPTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
