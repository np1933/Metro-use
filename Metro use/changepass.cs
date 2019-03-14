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
    public partial class changepass : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();
        DataTable dt = new DataTable();
        public changepass()
        {
            InitializeComponent();
        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }

        private void taxsv_btn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("")|| textBox2.Text.Equals(""))
            {
                MessageBox.Show("Invalid Entries..");
            }
            else
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET password='" + textBox2.Text + "' WHERE username='" + textBox1.Text + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Changed...");
                textBox2.Text = "";
                textBox1.Text = "";
                cn.Close();
                this.Close();
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

