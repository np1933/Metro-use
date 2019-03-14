using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Metro_use
{
    public partial class Table : MetroFramework.Forms.MetroForm
    {
        double gt = 0;
        double tx;

        double strv;

        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        String[] rows = { "Order List", "Payment" };
        public Table()
        {
            InitializeComponent();
            cn.Open();
            refreshData();
            createTableToolStripMenuItem.Click += new EventHandler(createTable_SelectedItem);
            tableNumberToolStripMenuItem.Click += new EventHandler(tableNumber_SelectedItem);
        }

       
        private void submenu_click(object sender, EventArgs e)
        {
            Debug.Write("btn_Check_Click event called" + (sender as ToolStripMenuItem).Text.Substring(9));
        }
        private void submenu_item_click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Text == rows[0])
            {
                this.dataGridView_tax.DataSource = null;
                this.dataGridView_tax.Rows.Clear();
                this.dataGridView_tax.Columns.Clear();
                string selectQuery = "Select * from shop_orders WHERE oder_table=" + (sender as ToolStripItem).Tag;
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dataGridView_tax.DataSource = table;
                dataGridView_tax.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView_tax.Columns[0].HeaderText = "Order ID";
                dataGridView_tax.Columns[1].HeaderText = "Dish Name";
                dataGridView_tax.Columns[2].HeaderText = "Quantity";
                dataGridView_tax.Columns[3].HeaderText = "Amount";
                dataGridView_tax.Columns[4].HeaderText = "Order Table";
                dataGridView_tax.Columns[5].HeaderText = "Order Status";
                dataGridView_tax.Columns[6].HeaderText = "Order Type";
            }
            else
            {
                this.dataGridView_tax.DataSource = null;
                this.dataGridView_tax.Rows.Clear();
                this.dataGridView_tax.Columns.Clear();

                string selectQuery = "Select * from shop_pay WHERE order_table=" + (sender as ToolStripItem).Tag +" AND order_status='NOT PAID'";
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView_tax.DataSource = table;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView_tax.Columns.Add(btn);
                btn.HeaderText = "Check Out";
                btn.Text = "Print Recept";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView_tax.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView_tax.Columns[0].HeaderText = "Pay ID";
                dataGridView_tax.Columns[1].HeaderText = "Table No";
                dataGridView_tax.Columns[2].HeaderText = "Total Amount";
                dataGridView_tax.Columns[3].HeaderText = "Order Type";
                dataGridView_tax.Columns[4].HeaderText = "Order Date";
                dataGridView_tax.Columns[5].HeaderText = "Order Status";
            }

            dataGridView_tax.CellClick += new DataGridViewCellEventHandler(dataGridView_tax_CellClick);


            try



            {

                MySqlCommand cmdsum = new MySqlCommand("SELECT sum(order_amount) from shop_pay WHERE order_table=" + (sender as ToolStripItem).Tag + " AND order_status='NOT PAID'",cn);
               

                gt = 0;
               



                gt =(double) cmdsum.ExecuteScalar();

                txtfm.Text = gt.ToString();




                cal();



                 

                

            }


            catch (Exception e1)
            {
                //MessageBox.Show("err " + e1);


                txtfm.Text = "0";
                txtgt.Text = "0";





            }
           




        }
        int prev_row=-1;
        private void dataGridView_tax_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && prev_row!= e.RowIndex && e.RowIndex<dt.Rows.Count)
            {
                DataGridViewButtonCell b = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                prev_row = e.RowIndex;
                DataRow row = dt.Rows[e.RowIndex];
                MySqlCommand cmd = new MySqlCommand("UPDATE  shop_pay  SET  order_status='PAID' WHERE pay_id='"+ row["pay_id"] +"'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Made Successfully...");
                //report_form_payment_history ph = new report_form_payment_history();
                //ph.Show();
                Report_Form_bill rb = new Report_Form_bill();
                rb.ShowDialog();
                this.dataGridView_tax.DataSource = null;
                this.dataGridView_tax.Rows.Clear();
                this.dataGridView_tax.Columns.Clear();

                string selectQuery = "Select * from shop_inventory WHERE inventory_quantity<=3";
                DataTable table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
                ad.Fill(table);
                dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    alert stock = new alert();
                    stock.ShowDialog();
                }
            }
        }

        private void createTable_SelectedItem(object sender, EventArgs e)
        {
            addtable tables = new addtable();
            tables.Show();
        }

        private void tableNumber_SelectedItem(object sender, EventArgs e)
        {
            refreshData();
        }

        public void cal()
        {


            try
            {
                tx = 0;
                strv = 0;



                strv = double.Parse(txttax.Text);


                tx = (gt * strv) / 100;


                txtgt.Text = (gt + tx).ToString();


            }
            catch(Exception f2)
            {

                txtgt.Text = txtfm.Text;

            }

        }



        private void refreshData()
        {
            tableNumberToolStripMenuItem.DropDownItems.Clear();
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM shop_tables", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        item.Text = "Table No " + row["table_no"].ToString();
                        item.Click += new EventHandler(submenu_click);
                        this.tableNumberToolStripMenuItem.DropDownItems.Add(item);
                        for (int j = 0; j < rows.Length; j++)
                        {
                            ToolStripMenuItem items = new ToolStripMenuItem();
                            items.Text = rows[j];
                            items.Tag = row["table_no"].ToString();
                            items.Click += new EventHandler(submenu_item_click);
                            item.DropDownItems.Add(items);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No table created..");
                }
            }
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void txttax_TextChanged(object sender, EventArgs e)
        {
            cal();

        }

        private void dataGridView_tax_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
