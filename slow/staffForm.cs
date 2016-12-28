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
    public partial class staffForm : Form
    {
        public staffForm(string staff_strTextBox, string staff_photo1, Image staff_photo)
        {
            InitializeComponent();
            label1.Text = staff_strTextBox;

            pictureBox1.Image = staff_photo;
        }
        //loading the students forms
        managerEditStudents managerEditStudents = new managerEditStudents();
        managerSeeStudents managerSeeStudents = new managerSeeStudents();

        //LOADING THE BOOKS FORMS
        booksEdit booksEdit = new booksEdit();
        booksSee booksSee = new booksSee();

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
           
        }

        private void staffForm_Load(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void aDDSTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerEditStudents.ShowDialog();
            this.Show();
        }

        private void sEESTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerSeeStudents.ShowDialog();
            this.Show();
        }

        private void aDDBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            booksEdit.ShowDialog();
            this.Show();
        }

        private void sEEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            booksSee.ShowDialog();
            this.Show();
        }

        private void bOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
