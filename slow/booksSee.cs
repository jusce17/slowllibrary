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
    public partial class booksSee : Form
    {
        public booksSee()
        {
            InitializeComponent();
        }

       

      
        private void booksSee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);

        }

        private void bOOKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void bOOKSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bOOKSBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.bOOKSBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bOOKSBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bOOKSBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
