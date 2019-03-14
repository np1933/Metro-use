using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Metro_use
{
    public partial class salary : MetroFramework.Forms.MetroForm
    {
       
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public salary()
        {
            InitializeComponent();
        }

        private void salary_Load(object sender, EventArgs e)
        {
            GetColumnOnComboBox();
        }

        private void GetColumnOnComboBox()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = "server=localhost; User Id= root; database=restaurant";
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT emp_name FROM emp_regi", cn))
                {

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        comboBox2.ValueMember = "emp_name";
                        comboBox2.DisplayMember = "emp_name";
                        comboBox2.DataSource = dt;

                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void count()
        {
            int totslary = 0;
            Int32 totdays = Convert.ToInt32(label1.Text);
            Int32 totslarys = Convert.ToInt32(label5.Text);
            Int32 totlev = Convert.ToInt32(textBox1.Text);
            totslary = ((totdays - totlev) * totslarys) / totdays;
            label6.Text = totslary.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();

            cn.ConnectionString = "server=localhost; User Id= root; database=restaurant";
            cn.Open();
            using (MySqlCommand cmd1 = new MySqlCommand("SELECT emp_name,salary FROM emp_regi where emp_name ='" + comboBox2.Text + "'", cn))
            {
                using (var dr = cmd1.ExecuteReader())

                    while (dr.Read())
                    {
                        String name = (String)dr["emp_name"];
                        label4.Text = name;
                        int payroll = (int)dr["salary"];
                        label5.Text = payroll.ToString();
                    }

            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.Text == "January") { label1.Text = "31"; }
            else if (comboBox1.Text == "Fabruary") { label1.Text = "29"; }
            else if (comboBox1.Text == "March") { label1.Text = "31"; }
            else if (comboBox1.Text == "April") { label1.Text = "30"; }
            else if (comboBox1.Text == "May") { label1.Text = "31"; }
            else if (comboBox1.Text == "June") { label1.Text = "30"; }
            else if (comboBox1.Text == "July") { label1.Text = "31"; }
            else if (comboBox1.Text == "August") { label1.Text = "31"; }
            else if (comboBox1.Text == "Supetmber") { label1.Text = "30"; }
            else if (comboBox1.Text == "October") { label1.Text = "31"; } else if (comboBox1.Text == "November") { label1.Text = "30"; } else if (comboBox1.Text == "December") { label1.Text = "31"; }
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            count();

            cn.Open();

            try
            {
                MySqlCommand cmdins = new MySqlCommand("INSERT INTO salary VALUES ('" + comboBox2.Text + "'," + label5.Text + "," + textBox1.Text + "," + label6.Text + ")", cn);
                cmdins.ExecuteNonQuery();
                MessageBox.Show("data successfully");
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("err" + e1);
            }


            cn.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void btn_s1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
