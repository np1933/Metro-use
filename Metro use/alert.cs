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
    public partial class alert : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();
        int operations,id_menu;
        String categories,items;
        DataTable dt = new DataTable();
        public alert()
        {
            InitializeComponent();
            cn.Open();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();

            string selectQuery = "Select * from shop_inventory WHERE inventory_quantity<=3";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].HeaderText = "Inventory ID";
            dataGridView1.Columns[1].HeaderText = "Inventory Name";
            dataGridView1.Columns[2].HeaderText = "Inventory Quantity";

        }

        private void addtax_Load(object sender, EventArgs e)
        {
          

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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

