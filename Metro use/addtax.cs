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
    public partial class addtax : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd1 = new MySqlCommand();
        int ops = 0;
        String prev_taxname="";
        double prev_amount = 0.0;
        DataTable dt = new DataTable();
        public addtax(String taxname, double taxprice,int operation,int id)
        {
            InitializeComponent();
            if(operation==1)
            {
                ops = operation;
                prev_taxname = taxname;
                prev_amount = id;
                textBox2.Text = taxprice.ToString();
                textBox1.Text = taxname;
            }
        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }

        private void taxsv_btn_Click(object sender, EventArgs e)
        {
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tax_ids WHERE taxname='" + textBox1.Text+"'", cn)) 
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("name Already Created..");
                }

                else if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Invalid Entries..");
                }
                else
                {
                    cn.Open();
                    if (ops == 1)
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE tax_ids SET taxname='" + textBox1.Text + "' , tax_value='" + textBox2.Text + "' WHERE tax_id ='" + prev_amount + "'", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tax Updated...");

                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT into tax_ids(taxname,tax_value) values ('" + textBox1.Text + "','" + textBox2.Text + "')", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tax Saved...");
                        textBox2.Text = "";
                        textBox1.Text = "";
                    }
                    this.Close();
                }
            }
        }
        

        public Boolean isInteger(String input)
        {
            try
            {
                Int64.Parse(input);
                return true;
            }
            catch (Exception e)
            {
                return false;
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


    }
}

