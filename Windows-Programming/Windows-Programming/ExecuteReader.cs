using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Windows_Programming
{
    public partial class ExecuteReader : Form
    {
       
        public ExecuteReader()
        {
            InitializeComponent();
        }

        private void ExecuteReader_Load(object sender, EventArgs e)
        {
            // Initialize your connection when the form loads
            // ⚠️ Replace with your actual connection string
            OdbcConnection con = new OdbcConnection("Dsn=<Dsn Name>");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing connection: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
