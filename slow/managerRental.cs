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
    public partial class managerRental : Form
    {

        public OracleConnection conn;
        public string connstr = "DATA SOURCE=Connection;USER ID=S5266484;password=S5266484";

        public void publicInfo()
        {
            conn = new OracleConnection(connstr);
            conn.Open();


            string select = "select * from rentalx ";
            OracleDataAdapter oda = new OracleDataAdapter(select, conn);

            OracleCommandBuilder commandBuilder = new OracleCommandBuilder(oda);
            DataSet ds = new DataSet();
            oda.Fill(ds);
           
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;

            conn.Close();

        }
        public void privateinfo()
        {

            conn = new OracleConnection(connstr);
            conn.Open();
            
          
            string select = "select * from rentalx where STUDENT_ID='" + textBox1.Text + "' ";
            OracleDataAdapter oda = new OracleDataAdapter(select, conn);

            OracleCommandBuilder commandBuilder = new OracleCommandBuilder(oda);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            // dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;

            conn.Close();
            
                
        }
       
        public void deleteinfo()
        {
            OracleCommand cmnd = new OracleCommand();
            conn = new OracleConnection(connstr);
            conn.Open();

            try
            {

               // string cmdText = "DELETE from TEST WHERE ID  = :ID";
                string cmdText = "DELETE from RENTALX WHERE RENTAL_ID  = :ID";
                using (OracleCommand cmd = new OracleCommand(cmdText, conn))
                {

                    cmd.Parameters.AddWithValue("ID", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    cmnd.Dispose();
                    conn.Close();
                    conn.Dispose();
                    
                    MessageBox.Show(" The Rental "+ textBox2.Text+ " has been deleted");
                    privateinfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.Message);
            }
            finally
            {
                conn.Close();
            }
                      

                

        }


        

        public managerRental()
        {
            InitializeComponent();
        }

        private void managerRental_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text != "")
            {
                privateinfo();
            }
            else
            {
                publicInfo();
            }
        }

        private void rENTALXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void rENTALXBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteinfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
