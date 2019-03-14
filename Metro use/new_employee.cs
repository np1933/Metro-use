using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_use
{
    public partial class new_employee : MetroFramework.Forms.MetroForm
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public new_employee()
        {
            InitializeComponent();
        }

        private void new_employee_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "server=localhost; User Id= root; database=restaurant";
            cn.Open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void new_emp_btn_Click(object sender, EventArgs e)
        {
           
           
        }

        private void browseemp_image_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                emp_pic.Image = Image.FromFile(opf.FileName);
            }
        }

        public void new_emp_btn_Click_1(object sender, EventArgs e)
        {

            using (cmd = new MySqlCommand("INSERT INTO emp_regi(emp_id,emp_name,photo,desig,hire_date,salary,address,city,country,birth_date,phn_no,mob,notes,id_type,id_image) VALUES ('" + empid_textbox.Text + "','" + empname_texbox.Text + "','" + emp_pic.Image + "','" + emp_designation_combobox.Text + "','" +hiredate_txtbox.Text + "','" + emp_salary_textbox.Text + "','" + emp_address_textbox.Text + "','" + emp_city_textbox.Text + "','" + emp_country_textbox.Text + "','" + birthdate_txtbox.Text + "','" + emp_phone_textox.Text + "','" + emp_mobile_textbox.Text + "','" + emp_notes_textbox.Text + "','" + emp_idproof_comboBox.Text + "','" + idproof_picturebox.Image + "')", cn))
            {
                if (idproof_picturebox.Image != null || emp_pic.Image!=null)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("enter emp pic and id proof");
                }
                try
                {
                    //for emp image
                    MemoryStream ms = new MemoryStream();
                    emp_pic.Image.Save(ms, emp_pic.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd.Parameters.Add("@img", MySqlDbType.Blob);
                    cmd.Parameters["@img"].Value = img;

                    //for id proof
                    idproof_picturebox.Image.Save(ms, idproof_picturebox.Image.RawFormat);
                    byte[] idimg = ms.ToArray();
                    cmd.Parameters.Add("@idimg", MySqlDbType.Blob);
                    cmd.Parameters["@idimg"].Value = idimg;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
               
            }
        }

        private void browse_empidproof_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                idproof_picturebox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void delete_emp_btn_Click(object sender, EventArgs e)
        {
                empid_textbox.Clear();
                empname_texbox.Clear();
                emp_pic.Image=null;
                emp_designation_combobox.Text=" ";
                emp_salary_textbox.Clear();
                emp_address_textbox.Clear();
                emp_city_textbox.Clear();
                emp_country_textbox.Clear();
                emp_phone_textox.Clear();
                emp_mobile_textbox.Clear();
                emp_notes_textbox.Clear();
                emp_idproof_comboBox.Text="";
                idproof_picturebox.Image = null;
            
        }

        private void close_empdetails_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
