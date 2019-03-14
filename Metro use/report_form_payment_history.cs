using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Metro_use
{
    public partial class report_form_payment_history : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        public report_form_payment_history()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            cn.Open();



            MySqlCommand cmd = new MySqlCommand("select * from shop_pay  ", cn);

            ReportDocument crystalreport = new ReportDocument();

            DataTable ds6 = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds6);

            crystalreport.Load(@"E:\Metro use\Metro use\report_payment_history.rpt");
            crystalreport.SetDataSource(ds6);
            crystalReportViewer1.ReportSource = crystalreport;



            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* cn.Open();



            



                MySqlCommand cmd = new MySqlCommand("select * from shop_pay where (order_date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "') ", cn);

                ReportDocument crystalreport = new ReportDocument();

                DataTable ds6 = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds6);

                crystalreport.Load(@"E:\Metro use\Metro use\report_payment_history.rpt");
                crystalreport.SetDataSource(ds6);
                crystalReportViewer1.ReportSource = crystalreport;


           

            cn.Close();*/


        }
    }
}
