using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metro_use
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void taxSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void a_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (parcel mypack = new parcel())
            {
                mypack.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                mypack.ShowDialog();
            }
        }

        private void taxSetUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (tax tax = new tax())
            {
                tax.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                tax.ShowDialog();
            }
        }
        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            //adminToolStripMenuItem.Refresh();
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuSetUpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (MenuSetup ms = new MenuSetup())
            {
                ms.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                ms.ShowDialog();
            }
        }

        private void resetPasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (changepass datReport = new changepass())
            {
                datReport.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                datReport.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Table tbl = new Table())
            {
                tbl.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                tbl.ShowDialog();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Employee_Details em = new Employee_Details();
            em.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Attendence att = new Attendence();
            att.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            salary ss = new salary();
            ss.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventory id = new inventory();
            id.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Report_Form_Salary rs = new Report_Form_Salary();
            rs.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            report_form_payment_history ff = new report_form_payment_history();
            ff.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            report_form_customer_bill cs = new report_form_customer_bill();
            cs.ShowDialog();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Form_inventory ri = new Report_Form_inventory();
            ri.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login ls = new Login();
                ls.ShowDialog();


            }
        }

        
    }
}
