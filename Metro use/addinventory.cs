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
    public partial class addinventory : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();
        int operations,id_menu;
        String categories,items;
        DataTable dt = new DataTable();
        private string v1;
        private int v2;
        private int v3;
        private int v4;

        public addinventory(String category,int operation,String items)
        {
            InitializeComponent();
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT stock_category FROM stock", cn);
            DataSet ds_customName = new DataSet();
            MySqlDataAdapter da_menus = new MySqlDataAdapter(cmd);
            da_menus.Fill(ds_customName, "stock");
            AutoCompleteStringCollection col = new
            AutoCompleteStringCollection();
            int l = 0;
            for (l = 0; l <= ds_customName.Tables[0].Rows.Count - 1; l++)
            {
                col.Add(ds_customName.Tables[0].Rows[l]["stock_category"].ToString());

            }
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = col;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

            if (operation==2)
            {
                operations = operation;
                categories = category;
                textBox1.Text = category;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
            }
            else if (operation == 3)
            {
                operations = operation;
                categories = category;
                this.items = items;
                textBox1.Text = category;
                textBox2.Text = items;
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT quantity,stock_id FROM stock WHERE stock_category='" + category + "' AND stock_item='"+items+"'", cn))
                {
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        textBox4.Text = row["quantity"].ToString() ;
                        id_menu = (int)row["stock_id"];
                    }
                }
            }
        }

        public addinventory(string v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }

        private void taxsv_btn_Click(object sender, EventArgs e)
        {
            if (operations == 0 && !textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox4.Text.Equals(""))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT into stock(stock_category,stock_item,quantity) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Saved...");
                textBox2.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";
                this.Close();

            }
            else if (operations == 2 && !textBox1.Text.Equals(""))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE stock SET stock_category ='" + textBox1.Text + "' WHERE stock_category='" + categories + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated...");
                textBox2.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";
                this.Close();
            }
            else if (operations == 3 && !textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox4.Text.Equals(""))
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE stock SET stock_category ='" + textBox1.Text + "',stock_item ='" + textBox2.Text + "',quantity ='" + textBox4.Text + "' WHERE stock_id='" + id_menu + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Saved...");
                textBox2.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Fields are missing...");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

