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
using System.Configuration;

namespace Metro_use
{
    public partial class Employee_Details : MetroFramework.Forms.MetroForm
    {
        
        public Employee_Details()
        {
            InitializeComponent();
            
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            MySqlConnection cn =new MySqlConnection();
           cn.ConnectionString = "server=localhost; User Id= root; database=trial";
            cn.Open();

            dataGridView1.DataSource = null;
            try
            {

                using (MySqlCommand cmd = new MySqlCommand("SELECT emp_id,emp_name,desig,mob,salary FROM emp_regi", cn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.AutoGenerateColumns = true;

                            dataGridView1.ColumnCount = 5;

                            dataGridView1.Columns[0].Name = "emp_id";
                            dataGridView1.Columns[0].HeaderText = "Emp Id ";
                            dataGridView1.Columns[0].DataPropertyName = "emp_id";

                            dataGridView1.Columns[1].HeaderText = "emp_name";
                            dataGridView1.Columns[1].Name = " Emp Name ";
                            dataGridView1.Columns[1].DataPropertyName = "emp_name";

                            dataGridView1.Columns[2].HeaderText = "desig";
                            dataGridView1.Columns[2].Name = " Designation ";
                            dataGridView1.Columns[2].DataPropertyName = "desig";



                            dataGridView1.Columns[3].HeaderText = "mob";
                            dataGridView1.Columns[3].Name = " Mobile ";
                            dataGridView1.Columns[3].DataPropertyName = "mob";



                            dataGridView1.Columns[4].HeaderText = "salary";
                            dataGridView1.Columns[4].Name = " salary ";
                            dataGridView1.Columns[4].DataPropertyName = "salary";

                            dataGridView1.DataSource = dt;
                            int nRowIndex = dataGridView1.Rows.Count - 1;
                            int nColumnIndex = 2;

                            dataGridView1.Rows[nRowIndex].Selected = true;
                            dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
                        }
                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error" + e1.ToString());
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void new_emp_btn_Click(object sender, EventArgs e)
        {
            
           
            new_employee ne = new new_employee();
            ne.Show();
           // this.Opacity = 0.5;
        }

        private void close_empdetails_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
