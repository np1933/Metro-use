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
            cn.ConnectionString = "server=localhost; User Id= root; database=trial";
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

            using (cmd = new MySqlCommand("INSERT INTO emp_regi(emp_id,emp_name,photo,desig,hire_date,salary,address,city,country,birth_date,phn_no,mob,notes,id_type,id_image) VALUES ('" + empid_textbox + "','" + empname_texbox + "','" + emp_pic + "','" + emp_designation_combobox + "','" + emp_hiredate_dateTimePicker + "','" + emp_salary_textbox + "','" + emp_address_textbox + "','" + emp_city_textbox + "','" + emp_country_textbox + "','" + emp_birthdate_dateTimePicker + "','" + emp_phone_textox + "','" + emp_mobile_textbox + "','" + emp_notes_textbox + "','" + emp_idproof_comboBox + "','" + idproof_picturebox + "')", cn))
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");

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
             emp_pic=null;
 
            emp_designation_combobox.Text=" ";
            emp_salary_textbox.Clear();
                emp_address_textbox.Clear();
                emp_city_textbox.Clear();

            
        }
    }
}
