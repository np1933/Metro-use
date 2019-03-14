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
    public partial class tax : MetroFramework.Forms.MetroForm
    {
        public tax()
        {
            InitializeComponent();
        }

        private void tax_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; User Id= root; database=trial";
            cn.Open();

            dataGridView1.DataSource = null;
            try
            {

                using (MySqlCommand cmd = new MySqlCommand("SELECT tax_name,tax_rate FROM tax_setup", cn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                           // dataGridView1.AutoGenerateColumns = true;

                            //dataGridView1.ColumnCount = 2;

                            /*  dataGridView1.Columns[0].Name = "Taxname";
                              dataGridView1.Columns[0].HeaderText = "tax_name ";
                              dataGridView1.Columns[0].DataPropertyName = "tax name";

                              dataGridView1.Columns[1].HeaderText = "tax rate";
                              dataGridView1.Columns[1].Name = " tax_rate";
                              dataGridView1.Columns[1].DataPropertyName = "tax rate";
                            */
                              dataGridView1.DataSource = dt;
                              int nRowIndex = dataGridView1.Rows.Count - 1;
                              //int nColumnIndex = 2;

                              dataGridView1.Rows[nRowIndex].Selected = true;
                           //   dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
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




        private void new_emp_btn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
