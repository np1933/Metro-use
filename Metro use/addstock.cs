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
    public partial class addstock : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();

        DataTable dt = new DataTable();

        int performance = -1;
        int id = -1;    
        public addstock(String name,int quantity,int operation,int id)
        {
            InitializeComponent();
            cn.Open();
            performance = operation;
            this.id = id;
            if(operation==1)
            {
                textBox1.Text = name;
                textBox4.Text = quantity.ToString();
            }

        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }

        private void taxsv_btn_Click(object sender, EventArgs e)
        {
            if (performance == 0)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT into shop_inventory(inventory_name,inventory_quantity) values ('" + textBox1.Text + "'," + textBox4.Text + ")", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventory Saved...");
                textBox4.Text = "";
                textBox1.Text = "";
                this.Close();
            }else if(performance == 1)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE shop_inventory SET inventory_name='" + textBox1.Text + "', inventory_quantity=" + textBox4.Text + " WHERE inventory_id="+id, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventory Saved...");
                textBox4.Text = "";
                textBox1.Text = "";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

