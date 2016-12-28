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
    public partial class studentForm : Form
        {
        
            //LOADING THE BOOKS FORMS
    
     /*   studentSeeBooks studentSeeBooks = new studentSeeBooks(studentName); */

        public studentForm(string strTextBox, string photo1, Image photo)
        {
           
            InitializeComponent();


           label1.Text=strTextBox;        
          pictureBox1.Image = photo;
          studentName_txt.Text = strTextBox;
          studentName_txt.Visible = false;

            //loading myBooks form and passing the user value
         
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental1.RENTALX' table. You can move, or remove it, as needed.
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LOADING THE BOOKS FORMS
            studentSeeBooks studentSeeBooks = new studentSeeBooks(label1.Text); 
            this.Hide();
            studentSeeBooks.ShowDialog();
            this.Show();
           
        }

        private void rENTALXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myBooks myBooks = new myBooks(label1.Text);
            this.Hide();
            myBooks.ShowDialog();
            this.Show();
           
        }
    }
}
