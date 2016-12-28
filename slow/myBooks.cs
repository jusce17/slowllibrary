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
    public partial class myBooks : Form
    {

        public OracleConnection conn;
        public string connstr = "DATA SOURCE=Connection;USER ID=S5266484;password=S5266484";
        
        public void privateinfo()
        {

            conn = new OracleConnection(connstr);
            conn.Open();

            string select = "select * from rentalx where STUDENT_ID='" + user_lbl.Text + "' ";
            OracleDataAdapter oda = new OracleDataAdapter(select, conn);
              
            OracleCommandBuilder commandBuilder = new OracleCommandBuilder(oda);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
         

             



           
        }
        public myBooks( string user)
        {
            InitializeComponent();
            user_lbl.Text = user;
        }

        private void myBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rental1.RENTALX' table. You can move, or remove it, as needed.
            

           
        }

        private void rENTALXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void rENTALXBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void rENTALXBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            privateinfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
               
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
