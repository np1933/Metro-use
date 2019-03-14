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
using MySql.Data.MySqlClient;

namespace Metro_use
{
    public partial class MenuSetup : MetroFramework.Forms.MetroForm
    {
        String categories, items;
        MySqlConnection cn = new MySqlConnection("server=localhost; User Id= root;password=''; database=restaurant");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public MenuSetup()
        {
            InitializeComponent();
            cn.Open();
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT menu_category FROM shop_menu", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        Button newButton = new Button();
                        newButton.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        newButton.Location = new Point(5, 4+(i*33));
                        newButton.Name = "button1" + i;
                        newButton.Click += new EventHandler(btn_Check_Click);
                        newButton.Size = new Size(211, 33);
                        newButton.TabIndex = i;
                        newButton.Tag= row["menu_category"].ToString();
                        newButton.Text = row["menu_category"].ToString();
                        newButton.UseVisualStyleBackColor = false;

                        this.panel5.Controls.Add(newButton);
                    }
                    this.panel5.AutoScroll = true;
                }
                else
                {
                    MessageBox.Show("No record found..");
                }

            }
        }
        protected void btn_Check_Click(object sender, EventArgs e)
        {
            Debug.Write("btn_Check_Click event called"+ (sender as Button).Text);
            items = "";
            categories = (sender as Button).Text;
            panel2.Controls.Clear();
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT menu_name  FROM shop_menu WHERE menu_category='" + (sender as Button).Text+"'", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int j = 0;
                    int k = 0;
                    for (int i = 1; i <= dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i-1];
                        Button newButton = new Button();
                            newButton.BackColor = Color.WhiteSmoke;
                            newButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            newButton.Location = new Point(21 + (j * 168), 18 + (k * 66));
                            if (i % 4 == 0 && i > 0)
                            {
                                k++; j = 0;
                            }
                            else { j++; }
                            newButton.Name = "button6" + i;
                            newButton.Size = new Size(168, 66);
                            newButton.TabIndex = i;
                        newButton.Click += new EventHandler(btn_items_Click);
                        newButton.Text = row["menu_name"].ToString();
                            newButton.UseVisualStyleBackColor = false;

                            this.panel2.Controls.Add(newButton);
                        }
                        this.panel2.AutoScroll = true;
                    }

                else
                {
                    MessageBox.Show("No record found..");
                }

            }

        }

        protected void btn_items_Click(object sender, EventArgs e)
        {
            items = (sender as Button).Text;
        }

        private void MenuSetup_Load(object sender, EventArgs e)
        {

        }

        private void delete_cate_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Delete?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                MySqlCommand cmd = new MySqlCommand("DELETE FROM  shop_menu  WHERE menu_category='" + categories + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Deleted...");
                panel2.Controls.Clear();
                refreshData();
            }
            

        }

        private void new_cate_btn_Click(object sender, EventArgs e)
        {
            Debug.Write("btn_Check_Click event called" + (sender as Button).Text);
           
            using (addmenu newMenu = new addmenu(categories, 0, ""))
            {
                newMenu.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                newMenu.ShowDialog();
            }
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshData();
        }

        private void edit_cate_btn_Click(object sender, EventArgs e)
        {
            Debug.Write("btn_Check_Click event called" + (sender as Button).Text);
            
            using (addmenu newMenu = new addmenu(categories, 2, ""))
            {
                newMenu.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                newMenu.ShowDialog();
            }
        }

        private void close_empdetails_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!items.Equals(""))
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM  shop_menu  WHERE menu_name='" + items + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu items Deleted...");
                refreshData();
            }else
            {
                MessageBox.Show("No items seleted...");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        void refreshData()
        {
            panel5.Controls.Clear();
            panel2.Controls.Clear();
            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT menu_category FROM shop_menu", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        Button newButton = new Button();
                        newButton.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(184)))));
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        newButton.Location = new Point(5, 4 + (i * 33));
                        newButton.Name = "button1" + i;
                        newButton.Click += new EventHandler(btn_Check_Click);
                        newButton.Size = new Size(211, 33);
                        newButton.TabIndex = i;
                        newButton.Tag = row["menu_category"].ToString();
                        newButton.Text = row["menu_category"].ToString();
                        newButton.UseVisualStyleBackColor = false;

                        this.panel5.Controls.Add(newButton);
                    }
                    this.panel5.AutoScroll = true;
                }
                else
                {
                    MessageBox.Show("No record found..");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!items.Equals(""))
            {

                using (addmenu newMenu = new addmenu(categories, 3, items))
                {
                    newMenu.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                    newMenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No items seleted...");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (addmenu newMenu = new addmenu(categories, 0, ""))
            {
                newMenu.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                newMenu.ShowDialog();
            }
        }
    }
}
