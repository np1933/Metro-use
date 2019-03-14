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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "server=localhost; User Id= root; database=trial";
            cn.Open();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details ed = new Employee_Details();
            ed.Show();
        }

        private void taxSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tax tax = new tax();
            tax.Show();
        }

        private void menuSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuSetup ms = new MenuSetup();
            ms.Show();
        }
    }
}
