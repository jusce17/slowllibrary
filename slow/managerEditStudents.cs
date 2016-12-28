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
using System.IO;

namespace slow
{
 
    public partial class managerEditStudents : Form
    {
        public OracleConnection conn;
        public string connstr;
        public string imagename;

        /********/

        public void imagesearch()
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog();
                //specify your own initial directory 
                fldlg.InitialDirectory = @":D\";
                //this will allow onlt those file extensions to be added 
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                if (fldlg.ShowDialog() == DialogResult.OK)
                {

                    imagename = fldlg.FileName;
                    Bitmap newimg = new Bitmap(imagename);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = (Image)newimg;
                }
                fldlg = null;
            }
            catch (System.ArgumentException ae)
            {
                imagename = " ";
                MessageBox.Show(ae.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void imageSave()
        {
            //use filestream object to read the image. 
            //read to the full length of image to a byte array. 
            //add this byte as an oracle parameter and insert it into database. 
            try
            {
                //proceed only when the image has a valid path 
                if (imagename != "")
                {
                    FileStream fls;
                    fls = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
                    //a byte array to read the image 
                    byte[] blob = new byte[fls.Length];
                    fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
                    fls.Close();
                    //open the database using odp.net and insert the data 

                    connstr = "DATA SOURCE=Connection;USER ID=S5266484;password=S5266484";

                    conn = new OracleConnection(connstr);
                    conn.Open();
                    OracleCommand cmnd;
                    string query;

                    query = "insert into STUDENTSX(STUDENT_ID,FIRST_NAME,LAST_NAME,MAJOR,USERNAME,PASSWORD,PHOTO) values(" + textBox1.Text + "," + "'" + textBox2.Text + "'," + "'" + textBox3.Text + "'," + "'" + textBox4.Text + "'," + "'" + textBox5.Text + "'," + "'" + textBox6.Text + "'," + " :BlobParameter )";
                    //insert the byte as oracle parameter of type blob 
                    OracleParameter blobParameter = new OracleParameter();
                    blobParameter.OracleType = OracleType.Blob;

                    blobParameter.ParameterName = "BlobParameter";
                    blobParameter.Value = blob;
                    cmnd = new OracleCommand(query, conn);
                    cmnd.Parameters.Add(blobParameter);
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("A new student has been added");
                    cmnd.Dispose();
                    conn.Close();
                    conn.Dispose();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /********/

        public managerEditStudents()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerEditStudents_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagesearch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageSave();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
