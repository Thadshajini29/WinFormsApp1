using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Frmdbshow : Form
    {
        string studentId;
        public Frmdbshow(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void Frmdbshow_Load(object sender, EventArgs e)
        {
             //txt_fname.Text = studentId;

           
                 
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"select * from students where id={this.studentId}",conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow dr = dt.Rows[0];
                txt_fname.Text = dr["first_name"].ToString();
                txt_lname.Text = dr["last_name"].ToString();
                txt_address.Text = dr["per_address"].ToString();
                txtaddmission.Text = dr["admission_number"].ToString();

                string gender =
                    dr["gender"].ToString();

                rdoMale.Checked = gender == "M";
                rdoFemale.Checked = gender == "F";

                if(dr["grade_id"] != DBNull.Value)
                {
                    cmb_grade.SelectedValue = dr["grade_id"];
                }
                else
                {
                    cmb_grade.SelectedIndex = -1;
                }

                if (dr["date_of_birth"] != DBNull.Value)
                {
                    dtp_dob.Value =
                        Convert.ToDateTime(dr["date_of_birth"]);
                }

                txt_nic.Text = dr["nic_number"].ToString();
                txt_phone.Text = dr["tele_number"].ToString();

                if (dr["house_id"] != DBNull.Value)
                {
                    cmbhouse.SelectedValue = dr["house_id"];
                }
                else
                {
                    cmbhouse.SelectedIndex = -1;
                }

                if (dr["medium"] != DBNull.Value)
                {
                    cmb_medium.Text =
                        dr["medium"].ToString();
                }
                else
                {
                    cmb_medium .Text = "N/A";
                }

                if (dr["family_id"] != DBNull.Value)
                {
                    cmb_familyid.SelectedValue =
                        dr["family_id"].ToString();
                }
                else
                {
                    cmb_familyid.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
