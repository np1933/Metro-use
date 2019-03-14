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
    public partial class addparcel : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();

        DataTable dt = new DataTable();
        DataTable prices = new DataTable();
        int operation=-1;
        double actual_price = 0;
        int id = -1;
        int beforQunatity = 0;
        public addparcel(String name,int quantity,int operation,int id,double amount)
        {
            InitializeComponent();
            cn.Open();
            this.operation = operation;
            beforQunatity = quantity;
            string selectQuery = "SELECT DISTINCT menu_category FROM shop_menu";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    comboBox1.Items.Add(row["menu_category"]);
                    comboBox1.SelectedIndexChanged += new EventHandler(category_Load);
                }
            }

            if(operation==1)
            {
                textBox4.Text = quantity.ToString();
                textBox1.Text = name;
                actual_price = amount / quantity;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
                this.id = id;
            }
            MySqlCommand cmd = new MySqlCommand("SELECT distinct parcel_name FROM shop_parcel", cn);
            DataSet ds_customName = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds_customName, "shop_parcel");
            AutoCompleteStringCollection col = new
            AutoCompleteStringCollection();
            int l = 0;
            for (l = 0; l <= ds_customName.Tables[0].Rows.Count - 1; l++)
            {
                col.Add(ds_customName.Tables[0].Rows[l]["parcel_name"].ToString());

            }
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = col;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

        }

        private void category_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
           
            string selectQuery = "SELECT * FROM shop_menu WHERE menu_category ='" + comboBox1.GetItemText(this.comboBox1.SelectedItem) + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            prices = dt;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    comboBox2.Items.Add(row["menu_name"]);
                }
            }
        
        }
        int quantities = 0;
        private void taxsv_btn_Click(object sender, EventArgs e)
        {
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM shop_inventory WHERE inventory_name='" + comboBox2.GetItemText(this.comboBox2.SelectedItem) + "'", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow rows = dt.Rows[i];
                        quantities = Int32.Parse(rows["inventory_quantity"].ToString());
                    }
                }
            }
            if (operation == 0 && !comboBox1.GetItemText(this.comboBox1.SelectedItem).Equals("") && !comboBox2.GetItemText(this.comboBox2.SelectedItem).Equals("") && !textBox1.Text.Equals("") && !textBox4.Text.Equals("") && !textBox4.Text.Equals("0"))
            {
                DataRow row = prices.Rows[comboBox2.SelectedIndex];
                double amount = Convert.ToInt32(textBox4.Text) * Convert.ToDouble(row["menu_price"]);
                MySqlCommand cmd = new MySqlCommand("INSERT into shop_parcel (parcel_name,parcel_order,parcel_quantity,parcel_amount) values ('" + textBox1.Text + "','" + comboBox2.GetItemText(this.comboBox2.SelectedItem) + "'," + textBox4.Text + "," + amount + ")", cn);
                cmd.ExecuteNonQuery();
               
                
                    if (quantities > 0)
                    {
                        quantities = quantities - Int32.Parse(textBox4.Text);
                        MySqlCommand cmd2 = new MySqlCommand("UPDATE shop_inventory SET inventory_quantity="+ quantities + " WHERE inventory_name='" + comboBox2.GetItemText(this.comboBox2.SelectedItem) + "'", cn);
                        cmd2.ExecuteNonQuery();
                    }
                MessageBox.Show("Order placed please refresh to view in panel.");
                textBox4.Text = "";
                this.Close();
            }

            else if(operation == 1 && !textBox4.Text.Equals("") && !textBox4.Text.Equals("0"))
                {
                    double amount = Convert.ToInt32(textBox4.Text) * actual_price;
                    
                    MySqlCommand cmd = new MySqlCommand("UPDATE shop_parcel SET parcel_quantity='" + textBox4.Text + "', parcel_amount=" + amount + " WHERE parcel_id="+id, cn);
                    cmd.ExecuteNonQuery();

                if (beforQunatity > Int32.Parse(textBox4.Text))
                {
                    beforQunatity = beforQunatity - Int32.Parse(textBox4.Text);
                    quantities = quantities - beforQunatity;
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE shop_inventory SET inventory_quantity=" + quantities + " WHERE inventory_name='" + comboBox2.GetItemText(this.comboBox2.SelectedItem) + "'", cn);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    beforQunatity = -Int32.Parse(textBox4.Text)- beforQunatity ;
                    quantities = quantities - beforQunatity;
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE shop_inventory SET inventory_quantity=" + quantities + " WHERE inventory_name='" + comboBox2.GetItemText(this.comboBox2.SelectedItem) + "'", cn);
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("Oder Edited...");
                    textBox4.Text = "";
                this.Close();
            }  
            else
            {
                MessageBox.Show("Fields are incomplete...");
            }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

