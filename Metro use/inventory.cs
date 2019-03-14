using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Metro_use
{
    public partial class inventory : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public inventory()
        {
            InitializeComponent();
            cn.Open();
            refreshData();
            button4.Click += new EventHandler(stock_Load);
            button2.Click += new EventHandler(tabPage1_Click);
            button3.Click += new EventHandler(label1_Click);
            string selectQuery = "Select * from shop_inventory WHERE inventory_quantity<=3";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            if(dt.Rows.Count>0)
            {
                using (alert stock = new alert())
                {
                    stock.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                    stock.ShowDialog();
                }
            }
        }
       
        
        private void stock_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            DataRow row = dt.Rows[dataGridView1.CurrentRow.Index];
            Debug.Write("btn_Check_Click event called" + dataGridView1.CurrentRow.Index);
            using (addstock stock = new addstock(row["inventory_name"].ToString(), (int)row["inventory_quantity"], 1, (int)row["inventory_id"]))
            {
                stock.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                stock.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            using (addstock stock = new addstock("", 0, 0, 0))
            {
                stock.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                stock.ShowDialog();
            }
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete?", "Delete Dish Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow row = dt.Rows[dataGridView1.CurrentRow.Index];
                MySqlCommand cmd = new MySqlCommand("DELETE FROM  shop_inventory  WHERE inventory_id=" + row["inventory_id"], cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventory Deleted...");
                refreshData();
            }
        }
        private void refreshData()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();

            string selectQuery = "Select * from shop_inventory";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].HeaderText = "Inventory ID";
            dataGridView1.Columns[1].HeaderText = "Inventory Name";
            dataGridView1.Columns[2].HeaderText = "Inventory Amount";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
