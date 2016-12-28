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
    public partial class managerSeeStudents : Form
    {
        public managerSeeStudents()
        {
            InitializeComponent();
        }

        private void sTUDENTSXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTSXBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void sTUDENTSXBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTSXBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void managerSeeStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.STUDENTSX' table. You can move, or remove it, as needed.
            this.sTUDENTSXTableAdapter.Fill(this.dataSet1.STUDENTSX);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sTUDENTSXBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.sTUDENTSXBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.sTUDENTSXBindingSource.RemoveCurrent();
        }

        private void pHOTOPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTSXBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Changes have been saved");
        }
    }
}
