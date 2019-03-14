using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_use
{
    public partial class addtable : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();

        DataTable dt = new DataTable();
        public addtable()
        {
            InitializeComponent();
            cn.Open();
        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }

        private void taxsv_btn_Click(object sender, EventArgs e)
        {
          
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM shop_tables WHERE table_no=" + textBox1.Text, cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Table Already Created..");
                }
                else if(!textBox1.Text.Equals(""))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT into shop_tables(table_no,status) values (" + textBox1.Text + ",'NONE')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Table Created..");
                    textBox1.Text = "";
                }
                else MessageBox.Show("An error occured..");
            }
        }

        public void closeconnection()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public void executeMyQuery(string query)
        {
            try
            {
                openconnection();
                cmd1 = new MySqlCommand(query, cn);

                if (cmd1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeconnection();
            }

        }

        private void openconnection()
        {
            throw new NotImplementedException();
        }

        private void close_addtax_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

