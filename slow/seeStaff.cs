using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slow
{
    public partial class seeStaff : Form
    {
        public seeStaff()
        {
            InitializeComponent();
        }

        private void sTAFFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTAFFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void seeStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.dataSet1.STAFF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sTAFFDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.sTAFFBindingSource.RemoveCurrent();
            MessageBox.Show("Staff Removed");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.sTAFFBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.sTAFFBindingSource.MoveNext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.sTAFFBindingSource.RemoveCurrent();
            MessageBox.Show("Staff Removed");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
