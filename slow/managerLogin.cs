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
    public partial class managerLogin : Form
    {
        public managerLogin()
        {
            InitializeComponent();
        }
        managerForm managerForm = new managerForm();
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerForm.ShowDialog();
            this.Show();
        }

        private void managerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
