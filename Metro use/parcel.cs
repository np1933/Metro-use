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
    public partial class parcel : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        String parcelName = "";
        double amount = 0;
        public parcel()
        {
            InitializeComponent();
            cn.Open();
            getParcelData();
            button4.Click += new EventHandler(stock_Load);
            button6.Click += new EventHandler(remove_parcel);
            button5.Click += new EventHandler(confirm_pay);
            button2.Click += new EventHandler(tabPage1_Click);
            button3.Click += new EventHandler(label1_Click);
        }

        private void confirm_pay(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT into shop_pay (order_table,order_amount,order_type,order_status) values (0," + amount + ",'PARCEL','PAID')", cn);
            cmd.ExecuteNonQuery();
            
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM shop_parcel WHERE parcel_name='" + parcelName + "'", cn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("CheckOut Successful...");
                label3.Text = "";
                getParcelData();
            }
        

        private void stock_Load(object sender, EventArgs e)
        {
            getParcelData();
        }

        private void remove_parcel(object sender, EventArgs e)
        {
            if (!parcelName.Equals(""))
            {
                if (MessageBox.Show("Do you want to Delete?", "Delete Parcel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow row = dt.Rows[dataGridView1.CurrentRow.Index];
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM  shop_parcel  WHERE parcel_name='" + parcelName + "'", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted...");
                    getParcelData();
                }
            }
            else
                MessageBox.Show("Select an item to delete...");


            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            DataRow row = dt.Rows[dataGridView1.CurrentRow.Index];
            Debug.Write("btn_Check_Click event called" + dataGridView1.CurrentRow.Index);
           using (addparcel stock = new addparcel(row["parcel_name"].ToString(), (int)row["parcel_quantity"], 1, (int)row["parcel_id"], Convert.ToDouble(row["parcel_amount"])))
            {
                stock.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                stock.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (addparcel stock = new addparcel("", 0, 0, 0, 0))
            {
                stock.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                stock.ShowDialog();
            }   
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            getParcelData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete?", "Delete Parcel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow row = dt.Rows[dataGridView1.CurrentRow.Index];
                MySqlCommand cmd = new MySqlCommand("DELETE FROM  shop_parcel  WHERE parcel_id=" + row["parcel_id"], cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                refreshData(row["parcel_name"].ToString());
            }
        }

        private void refreshData(String name)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            parcelName = name;
            string selectQuery = "Select * from shop_parcel WHERE parcel_name='" + name + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "Customer Name";
            dataGridView1.Columns[2].HeaderText = "Order Name";
            dataGridView1.Columns[3].HeaderText = "Order Quantity";
            dataGridView1.Columns[4].HeaderText = "Order Status";
            dataGridView1.Columns[5].HeaderText = "Order Amount";

            
            if (dt.Rows.Count > 0)
            {
                amount = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    amount = amount + Convert.ToDouble(row["parcel_amount"]);
                }
            }
            label3.Text = amount.ToString();
        }

        private void getParcelData()
        {
            this.panel2.Controls.Clear();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT parcel_name FROM shop_parcel", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int j = 0;
                    int k = 0;
                    for (int i =1; i <= dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i-1];
                        Button newButton = new Button();
                        newButton.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        newButton.Location = new Point(5 + (j * 211), 4 + (k * 33));
                        if (i % 3 == 0 && i > 0)
                        {
                            k++; j = 0;
                        }
                        else { j++; }
                        newButton.Name = "button1" + i;
                        newButton.Click += new EventHandler(btn_Check_Click);
                        newButton.Size = new Size(211, 33);
                        newButton.TabIndex = i;
                        newButton.Tag = row["parcel_name"].ToString();
                        newButton.Text = row["parcel_name"].ToString();
                        newButton.UseVisualStyleBackColor = false;

                        this.panel2.Controls.Add(newButton);
                    }
                    this.panel2.AutoScroll = true;
                }
                else
                {
                    //MessageBox.Show("No record found..");
                }
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            refreshData((sender as Button).Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
