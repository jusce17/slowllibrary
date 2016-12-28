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
    public partial class studentLogin : Form
    {
        public studentLogin()
        {
            InitializeComponent();
        }
        /*********/
        

        
        public void loginCheck()
        {
            OracleConnection con = new OracleConnection("DATA SOURCE=Connection;USER ID=S5266484;password=S5266484");
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select count (*) from studentsx where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            OracleDataAdapter oda1 = new OracleDataAdapter("select  photo from studentsx where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            DataTable dt1 = new DataTable();
            DataTable dt = new DataTable();
            oda.Fill(dt);
           
            if (dt.Rows[0][0].ToString() == "1")
            {
               


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
                //    FS.Dispose();
                    FS.Close();
                }
                this.Hide();
            
                studentForm studentForm = new studentForm(textBox1.Text, textBox2.Text, pictureBox1.Image);
                this.Hide();
                studentForm.ShowDialog();
                this.Show();

                con.Close();
                con.Dispose();
                oda.Dispose();
                oda1.Dispose();
                
            }
            else
            {
                
                MessageBox.Show("Please Check your info");
            }


            
        }
       



        /*************/



      
     
        private void button2_Click(object sender, EventArgs e)
        {
            
         
            this.DialogResult = DialogResult.OK;
        }

        private void studentLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          /*  this.Hide();
            studentForm.ShowDialog();
            this.Show();*/
            loginCheck();
            textBox2.Text = "";
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
