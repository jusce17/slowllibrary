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

    public partial class Form1 : Form
    {
        
      
        public Form1()
        {
           
            InitializeComponent();
        }
        //loading forms
        studentLogin studentlogin = new studentLogin();
        staffLogin staffLogin = new staffLogin();
         managerLogin managerLogin = new managerLogin();
         help helpForm = new help();
        private void label1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            studentlogin.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Color myColor = Color.FromArgb(99, Color.Black);
            label6.BackColor = myColor;*/
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffLogin.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            helpForm.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
   
           this.Hide();
            managerLogin.ShowDialog();
            this.Show();
           
        }
    }
}
