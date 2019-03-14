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
using System.Diagnostics;

namespace Metro_use
{
    public partial class Home : Form
    {
        
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public Home()
        {
            InitializeComponent();
             cn.Open();
            



            toolStripButton2.Click += new EventHandler(toolStripStock_Click);
            toolStripDropDownButton3.Click += new EventHandler(toolStripparcel_Click);

            
            resetPasswordToolStripMenuItem.Click += new EventHandler(changePassword);
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

            toolStrip1.Refresh();
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
            



        }



        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (Employee_Details ed = new Employee_Details())
            {
                ed.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                ed.ShowDialog();
            }
        }

        private void taxSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (tax tax = new tax())
            {
                tax.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                tax.ShowDialog();
            }
        }

        private void menuSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (MenuSetup ms = new MenuSetup())
            {
                ms.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                ms.ShowDialog();
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

            using (Table tbl = new Table())
            {
                tbl.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                tbl.ShowDialog();
            }
        }

        private void toolStripStock_Click(object sender, EventArgs e)
        {

        }

        private void toolStripparcel_Click(object sender, EventArgs e)
        {

            using (parcel mypack = new parcel())
            {
                mypack.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                mypack.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Hide();
                Login ls = new Login();
                ls.ShowDialog();   
            
            
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



        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {

        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employee_Details em = new Employee_Details();
            em.ShowDialog();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence att = new Attendence();
            att.ShowDialog();

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salary ss = new salary();
            ss.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            inventory id = new inventory();
            id.ShowDialog();
            

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rawMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        
        }
        protected void btn_Check_Click(object sender, EventArgs e)
        {


        }

       

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Form_Salary rs = new Report_Form_Salary();
            rs.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_form_payment_history ff = new report_form_payment_history();
            ff.ShowDialog();
        }

        private void endOfDaySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_form_customer_bill cs = new report_form_customer_bill();
            cs.ShowDialog();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Form_inventory ri = new Report_Form_inventory();
            ri.ShowDialog();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
