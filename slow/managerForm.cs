using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace slow
{
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
        }
       //loading the staff forms
        managerEditstaff managerEditstaff = new managerEditstaff();
        seeStaff seeStaff = new seeStaff();
        //loading the students forms
        managerEditStudents managerEditStudents = new managerEditStudents();
        managerSeeStudents managerSeeStudents = new managerSeeStudents();

        //LOADING THE BOOKS FORMS
        booksEdit booksEdit = new booksEdit();
        booksSee booksSee = new booksSee();

        //LOADING THE RENTED BOOKS FORM
        managerRental managerRental = new managerRental();

        private void managerForm_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void sTAFFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void sTAFFBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void eDITSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerEditstaff.ShowDialog();
            this.Show();
            
            
        }

        private void sEESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            seeStaff.ShowDialog();
            this.Show();
        }

        private void sTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void sEEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            booksSee.ShowDialog();
            this.Show();

        }

        private void aDDBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            booksEdit.ShowDialog();
            this.Show();
        }

        private void aDDSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerEditstaff.ShowDialog();
            this.Show();
        }

        private void sEESTAFFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            seeStaff.ShowDialog();
            this.Show();
        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerEditStudents.ShowDialog();
            this.Show();
        }

        private void sEESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerSeeStudents.ShowDialog();
            this.Show();
        }

        private void sEEBOOKSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            booksSee.ShowDialog();
            this.Show();
        }

        private void aDDBOOKSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
              this.Hide();
            booksEdit.ShowDialog();
            this.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.OK;
        
        }

        private void rENTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerRental.ShowDialog();
            this.Show();
        }
    }
}
