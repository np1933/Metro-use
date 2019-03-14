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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = login_btn;
            MySqlCommandBuilder bd = new MySqlCommandBuilder();
            cn.ConnectionString = "server=localhost; User Id= root;password=''; database=restaurant";
            cn.Open();
            //MySqlDataReader rd = cmd.ExecuteReader();
            username_textbox.Focus();
        }

        private void username_textbox_Click(object sender, EventArgs e)
        {
            //username_textbox.Text = "";
            
        }

        private void password_textbox_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.username_textbox.Text) | string.IsNullOrEmpty(this.password_textbox.Text))
            {
                MessageBox.Show("provide User Name and Password");
            }
            else
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM users where username ='" + username_textbox.Text + "' and password = '" + password_textbox.Text + "'", cn))
                {
                    dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username_textbox.Clear();
                        password_textbox.Clear();
                        //MessageBox.Show("Login Successfull");
                     
                        a h = new a();
                        h.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or password..");
                    }
                }
            }
        }
    }
}