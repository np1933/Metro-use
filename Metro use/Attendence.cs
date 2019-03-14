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
    public partial class Attendence : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public Attendence()
        {
            InitializeComponent();
            
            button1.Click += new EventHandler(button1_Click);
            
        }
        private void changePassword(object sender, EventArgs e)
        {
            using (changepass datReport = new changepass())
            {
                datReport.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                datReport.ShowDialog();
            }
        }
        private void customerBillReport(object sender, EventArgs e)
        {
            using (reports datReport = new reports(4))
            {
                datReport.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                datReport.ShowDialog();
            }
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshData();
            
        }
        private void attendanceReport(object sender, EventArgs e)
        {
           
            using (reports datReport = new reports(3))
            {
                datReport.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                datReport.ShowDialog();
            }
        }
        private void report_endofdaysummary(object sender, EventArgs e)
        {
            
            using (reports datReport = new reports(0))
            {
                datReport.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                datReport.ShowDialog();
            }
        }
        private void paymentHistorysummary(object sender, EventArgs e)
        {
            
            using (reports datReport = new reports(2))
            {
                datReport.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                datReport.ShowDialog();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "server=localhost; User Id= root;password=''; database=restaurant";
            cn.Open();
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
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
                cmd = new MySqlCommand(query, cn);

                if (cmd.ExecuteNonQuery() == 1)
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

        private void refreshData()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            string selectQuery = "SELECT name,logged_in FROM shop_employee JOIN users ON shop_employee.user_id = users.id";
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(selectQuery, cn);
            ad.Fill(table);
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = table;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].HeaderText = "Employee Name";
            dataGridView1.Columns[1].HeaderText = "Logged In";
        }

        
        }

        
    }

