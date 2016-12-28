using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace slow
{
    public partial class staffLogin : Form
    {
        public staffLogin()
        {
            InitializeComponent();
        }
            /**********/

        
            public void loginCheck()
        {

           
          
            OracleConnection con = new OracleConnection("DATA SOURCE=Connection;USER ID=S5266484;password=S5266484");
            OracleDataAdapter oda = new OracleDataAdapter("select count (*) from STAFF where STAFF_USER='" + textBox1.Text + "' and STAFF_PASSWORD ='" + textBox2.Text + "'", con);
            OracleDataAdapter oda1 = new OracleDataAdapter("select  staff_photo from STAFF where STAFF_USER='" + textBox1.Text + "' and STAFF_PASSWORD ='" + textBox2.Text + "'", con);
            DataTable dt1 = new DataTable();
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();

               

                oda1.Fill(dt1);
                foreach (DataRow dataRow in dt1.Rows)
                {
                    FileStream FS = new FileStream("image.jpg", FileMode.Create);
                    byte[] blob = (byte[])dataRow[0];
                    FS.Write(blob, 0, blob.Length);
                    FS.Close();
                    FS = null;
                    pictureBox1.Image = Image.FromFile("image.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Refresh();
                    
                }
               
               
               this.Hide();
               staffForm staffForm = new staffForm(textBox1.Text, textBox2.Text, pictureBox1.Image);
              
               this.Hide();
               staffForm.ShowDialog();
                this.Show();
            
            }
            else
            {
                
               
                MessageBox.Show("Please Check your info");
            }


            con.Close();
        }

            /**********/
        
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //in case the next form fails to load the data from the db
            /*this.Hide();
            staffForm.ShowDialog();
            this.Show();*/

          
            loginCheck();
            textBox2.Text = "";
        }

        private void staffLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
