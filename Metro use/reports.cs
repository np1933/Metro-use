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
    public partial class reports : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public reports(int operation)
        {
            InitializeComponent();
            cn.Open();

            if (operation == 0)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Total Orders", "Total Orders");
                dataGridView1.Columns.Add("Total Parcel", "Total Parcel");
                dataGridView1.Columns.Add("Total Amount", "Total Amount");
                DateTime dateTime = DateTime.UtcNow.Date;
                string selectQuery = "Select * from shop_pay WHERE order_type='SERVE' AND order_date >'" + dateTime.ToString("yyyy-MM-dd") + " 00:00:00'";
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dt = new DataTable();
                ad.Fill(dt);

                string selectQuery1 = "Select * from shop_pay WHERE order_type='PARCEL' AND order_date >'" + dateTime.ToString("yyyy-MM-dd") + " 00:00:00'";
                DataTable table1 = new DataTable();
                MySqlDataAdapter ad1 = new MySqlDataAdapter(selectQuery1, cn);
                ad1.Fill(table1);
                dt1 = new DataTable();
                ad1.Fill(dt1);

                string selectQuery2 = "SELECT SUM(order_amount) FROM shop_pay";
                DataTable table2 = new DataTable();
                MySqlDataAdapter ad2 = new MySqlDataAdapter(selectQuery2, cn);
                ad2.Fill(table2);
                dt2 = new DataTable();
                ad2.Fill(dt2);
                DataRow row = dt2.Rows[0];

                dataGridView1.Rows[0].Cells["Total Orders"].Value = dt.Rows.Count;
                dataGridView1.Rows[0].Cells["Total Parcel"].Value = dt1.Rows.Count;
                dataGridView1.Rows[0].Cells["Total Amount"].Value = row[0];

            } else if (operation == 2)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();

                string selectQuery = "Select pay_id,order_date,order_amount,order_type from shop_pay";
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = table;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.Columns[0].HeaderText = "Order ID";
                dataGridView1.Columns[1].HeaderText = "Order Date";
                dataGridView1.Columns[2].HeaderText = "Order Amount";
                dataGridView1.Columns[3].HeaderText = "Order Type";

            } else if (operation == 3)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();
                string selectQuery = "SELECT name,logged_in FROM shop_employee JOIN users ON shop_employee.user_id = users.id";
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = table;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.Columns[0].HeaderText = "Employee Name";
                dataGridView1.Columns[1].HeaderText = "Logged In";
            } else if (operation == 4)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Columns.Clear();

                string selectQuery = "Select pay_id,order_date,order_table,order_amount,order_type,order_status from shop_pay";
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = table;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.Columns[0].HeaderText = "Order ID";
                dataGridView1.Columns[1].HeaderText = "Order Date";
                dataGridView1.Columns[2].HeaderText = "Order Table";
                dataGridView1.Columns[3].HeaderText = "Order Amount";
                dataGridView1.Columns[4].HeaderText = "Order Type";
                dataGridView1.Columns[5].HeaderText = "Order Status";
            }
        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }

        private void taxsv_btn_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

