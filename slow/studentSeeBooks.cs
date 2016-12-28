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
    public partial class studentSeeBooks : Form
    {
        public OracleConnection conn;
        public string connstr;
        public string imagename;
        public string tryeden;

        /*******/

        public void bookrental()
        {
                     string oradb = "DATA SOURCE=Connection;USER ID=S5266484;password=S5266484;";
 
                    OracleConnection conn = new OracleConnection(oradb); // a instance of oracle connection
                    conn.Open();
                    OracleCommand cmnd = new OracleCommand();
                    cmnd.Connection = conn;
                 
                    cmnd.CommandText =  "insert into RENTALX(TITTLE,BOOK_ID,AUTHOR_ID,STUDENT_ID) values('" + bOOK_TITLETextBox.Text + "'," + "'" + bOOK_IDTextBox1.Text + "'," + "'" + aUTHOR_IDTextBox.Text + "'," + "'" + studentName_lbl.Text + "')";
                    
                   // cmnd.CommandText =  "insert into RENTALX(TITTLE,BOOK_ID,AUTHOR_ID,STUDENT_ID) values(" + bOOK_TITLETextBox.Text + "," + "'" + bOOK_IDTextBox1.Text + "'," + "'" + aUTHOR_IDTextBox.Text + "'," + "'" + studentName_lbl.Text + "')";
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("A new BOOK has been added");
                    cmnd.Dispose();
                    conn.Close();
                    conn.Dispose();
              
            
            
        }


        /********/

        public studentSeeBooks(string studentName)
        {

           
            
            InitializeComponent();
            studentName_lbl.Text = studentName;
        }

        private void studentSeeBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksView.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.booksView.BOOKS);
            bOOK_IDTextBox1.Visible = false;
            bOOK_TITLETextBox.Visible = false;
            bOOK_PAGESTextBox.Visible = false;
            bOOK_CATEGORYTextBox.Visible = false;
            bOOK_POSITIONTextBox.Visible = false;
            bOOK_PRICETextBox.Visible = false;
            aUTHOR_IDTextBox.Visible = false;
            bOOK_IDTextBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bOOKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksView);

        }

        private void bOOK_COMMENTLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bookrental();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
