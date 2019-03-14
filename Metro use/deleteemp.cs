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

    public partial class deleteemp : MetroFramework.Forms.MetroForm
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();


        
        public deleteemp()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; User Id= root;password=''; database=restaurant";
            cn.Open();
            using (MySqlCommand cmd1 = new MySqlCommand("SELECT emp_id FROM emp_regi where emp_name ='" + comboBox1.Text + "'", cn))
            {

                MySqlDataReader dr;
                dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr["emp_id"];
                    label2.Text = id.ToString();
                }

            }
            cn.Close();

        }

        private void deleteemp_Load(object sender, EventArgs e)
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
        using (MySqlCommand cmd = new MySqlCommand("SELECT emp_name FROM emp_regi ", cn))
        {

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                dt = new DataTable();
                da.Fill(dt);
                comboBox1.ValueMember = "emp_name";
                comboBox1.DisplayMember = "emp_name";
                comboBox1.DataSource = dt;

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



        private void delete_emp_btn_Click(object sender, EventArgs e)
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; User Id= root; database=restaurant";
            cn.Open();

            using (MySqlCommand cmd = new MySqlCommand("Delete  from emp_regi where  emp_id ='" + label2.Text + "'", cn))
            {
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record DELETED.");

                }
                else
                {
                    MessageBox.Show("Record Failed..");
                }

            }
        }
    }
}
