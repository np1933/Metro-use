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
            MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
            

        //private object connection;
        public tax()
        {

            InitializeComponent();
           
        }

    

        private void tax_Load(object sender, EventArgs e)
        {
            cn.Open();
            string selectQuery = "Select * from tax_ids";
            table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dataGridView_tax.DataSource = table;
            cn.Close();

        }




        private void new_tax_btn_Click(object sender, EventArgs e)
        {
           
            using (addtax myForm = new addtax("",0.0,0,0))
            {
                myForm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                myForm.ShowDialog();
            }
           

            
        }
        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Do something
            cn.Open();
            string selectQuery = "Select * from tax_ids";
            table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dataGridView_tax.DataSource = table;
            cn.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MySqlConnection cn1 = new MySqlConnection("server=localhost; User Id= root;password=qwerty; database=restaurant");
            //cn1.Open();
            

            
        }

        private void close_taxgrid_btn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void delete_tax_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Delete?", "Delete Tax", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                DataRow row = table.Rows[dataGridView_tax.CurrentRow.Index];
                cn.Open();
                string selectQuery = "delete from tax_ids where tax_id='" + (int)row["tax_id"] + "'";
                MySqlCommand cmd = new MySqlCommand(selectQuery, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tax Deleted...");
                string selectQuery1 = "Select * from tax_ids";
                table = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery1, cn);
                ad.Fill(table);
                dataGridView_tax.DataSource = table;
                cn.Close();
            }
            
          }
        private void edit_tax_btn_Click(object sender, EventArgs e)
        {
            DataRow row = table.Rows[dataGridView_tax.CurrentRow.Index];
            using (addtax myForm = new addtax(row["taxname"].ToString(), (double)row["tax_value"],1, (int)row["tax_id"]))
            {
                myForm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                myForm.ShowDialog();
            }

        }
        DataTable table = new DataTable();
        private void refresh_tax_btn_Click(object sender, EventArgs e)
        {
            cn.Open();
            string selectQuery = "Select * from tax_ids";
            table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dataGridView_tax.DataSource = table;
            cn.Close();
           
        }

     
    }
}
