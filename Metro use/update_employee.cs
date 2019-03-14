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
    public partial class update_employee : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public update_employee()
        {
            InitializeComponent();
        }

           private void GetColumnOnComboBox()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = "server=localhost; User Id= root; database=restaurant";
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT emp_id FROM emp_regi", cn))
                {

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        comboBox1.ValueMember = "emp_id";
                        comboBox1.DisplayMember = "emp_id";
                        comboBox1.DataSource = dt;

                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }

        private void update_employee_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "server=localhost; User Id= root; database=restaurant; convert zero datetime=True";
            cn.Open();
           GetColumnOnComboBox();
        }

        private void empid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_emp_btn_Click(object sender, EventArgs e)
        {

            using (cmd = new MySqlCommand("UPDATE emp_regi SET emp_name='" + empname_texbox.Text + "',desig='" + emp_designation_combobox.Text + "',hire_date='" + hiredate_txtbox.Text + "',salary ='" + emp_salary_textbox.Text + "',address='" + emp_address_textbox.Text + "',city='" + emp_city_textbox.Text + "',country='" + emp_country_textbox.Text + "',birth_date='" + birthdate_txtbox.Text + "',phn_no='" + emp_phone_textox.Text + "',mob='" + emp_mobile_textbox.Text + "',notes='" + emp_notes_textbox + "',id_type='" + emp_idproof_comboBox.Text + "' WHERE emp_id= " + comboBox1.Text + "", cn))
            {

                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record UPDATED..");

                }
                else
                {
                    MessageBox.Show("Record Failed..");
                }

                empname_texbox.Clear();
                //emp_pic.Image = null;
                emp_designation_combobox.Text = " ";
                emp_salary_textbox.Clear();
                emp_address_textbox.Clear();
                emp_city_textbox.Clear();
                emp_country_textbox.Clear();
                emp_phone_textox.Clear();
                emp_mobile_textbox.Clear();
                emp_notes_textbox.Clear();
                emp_idproof_comboBox.Text = "";
                //idproof_picturebox.Image = null;
            }
        }

        private void close_empdetails_btn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM emp_regi where emp_id ='" + comboBox1.Text + "'", cn))
            {
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    empname_texbox.Text = (dt.Rows[0]["emp_name"].ToString());
                    emp_designation_combobox.Text = (dt.Rows[0]["desig"].ToString());
                    //emp_pic.Image = (dt.Rows[0]["photo"].ToString());
                    hiredate_txtbox.Text = (dt.Rows[0]["hire_date"].ToString());
                    birthdate_txtbox.Text = (dt.Rows[0]["birth_date"].ToString());
                    emp_salary_textbox.Text = (dt.Rows[0]["salary"].ToString());
                    emp_address_textbox.Text = (dt.Rows[0]["address"].ToString());
                    emp_city_textbox.Text = (dt.Rows[0]["city"].ToString());
                    emp_country_textbox.Text = (dt.Rows[0]["country"].ToString());
                    emp_phone_textox.Text = (dt.Rows[0]["phn_no"].ToString());
                    emp_mobile_textbox.Text = (dt.Rows[0]["mob"].ToString());
                    emp_notes_textbox.Text = (dt.Rows[0]["notes"].ToString());
                    emp_idproof_comboBox.Text = (dt.Rows[0]["id_type"].ToString());
                    // idproof_picturebox.Image = (dt.Rows[0]["idproof"].ToString());

                }
                else
                {
                    MessageBox.Show("Id is invalid");
                }

            }  

        }
        }
    }

