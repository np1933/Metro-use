using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace Metro_use
{
    public partial class Report_Form_bill : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        public Report_Form_bill()
        {

            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            cn.Open();



            MySqlCommand cmd = new MySqlCommand("select * from shop_orders  ", cn);

            ReportDocument crystalreport = new ReportDocument();

            DataTable ds6 = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds6);

            crystalreport.Load(@"E:\Metro use\Metro use\report_bill.rpt");
            crystalreport.SetDataSource(ds6);
            crystalReportViewer1.ReportSource = crystalreport;



            cn.Close();
        }
    }
}
