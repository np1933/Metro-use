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
    public partial class addtax : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd1 = new MySqlCommand();
        //MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public addtax()
        {
            InitializeComponent();
        }

        private void addtax_Load(object sender, EventArgs e)
        {

        }
    }
}
