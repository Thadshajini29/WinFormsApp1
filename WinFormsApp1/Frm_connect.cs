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
    public partial class Frm_connect : Form
    {
        public Frm_connect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }

        }

        private void btn_AllStudents_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while fetching student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //------------------Code to display student details in a new form.------------------
            try
            {
                string firstname = dgvStudents.CurrentRow.Cells["first_name"].Value.ToString();
                string lastname = dgvStudents.CurrentRow.Cells["last_name"].Value.ToString();
                string address = dgvStudents.CurrentRow.Cells["per_address"].Value.ToString();

                string gender = dgvStudents.CurrentRow.Cells["gender"].Value.ToString();

                if (gender == "M")
                {
                    rdoMale.Checked = true;
                }
                else if (gender == "F")
                {
                    rdoFemale.Checked = true;
                }


                string grade = "N/A";

                string gradeId =
                    dgvStudents.CurrentRow.Cells["grade_id"].Value.ToString();

                if (!string.IsNullOrEmpty(gradeId))
                {
                    cmb_grade.SelectedValue = gradeId;
                    grade = cmb_grade.Text;
                }


                string medium = dgvStudents.CurrentRow.Cells["medium"].Value.ToString();

                if (string.IsNullOrEmpty(medium))
                {
                    medium = "N/A";
                }

                string house = dgvStudents.CurrentRow.Cells["house_id"].Value.ToString();
                if (string.IsNullOrEmpty(house))
                {
                    house = "N/A";
                }

                DateTime dob = Convert.ToDateTime(dgvStudents.CurrentRow.Cells["date_of_birth"].Value);

                string phone = dgvStudents.CurrentRow.Cells["tele_number"].Value.ToString();
                if (string.IsNullOrEmpty(phone))
                {
                    phone = "N/A";
                }

                string nic = dgvStudents.CurrentRow.Cells["nic_number"].Value.ToString();
                if (string.IsNullOrEmpty(nic))
                {
                    nic = "N/A";
                }

                string addmission = dgvStudents.CurrentRow.Cells["admission_number"].Value.ToString();
                if (string.IsNullOrEmpty(addmission))
                {
                    addmission = "N/A";
                }

                string family = dgvStudents.CurrentRow.Cells["family_id"].Value.ToString();
                if (string.IsNullOrEmpty(family))
                {
                    family = "N/A";
                }

                FrmShowStudent f = new FrmShowStudent(
                    firstname,
                    lastname,
                    address,
                    gender,
                    grade,
                    medium,
                    house,
                    dob,
                    phone,
                    nic,
                    addmission,
                    family

                );

                f.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }


            //------------------Alternative code to display student details in text boxes instead of a new form.------------------

            //try
            //{
            //    if(dgvStudents.CurrentRow == null)
            //    {
            //        MessageBox.Show("No Data Found");
            //        return;
            //    }

            //    string firstname = dgvStudents.CurrentRow.Cells["first_name"].Value.ToString();
            //    txt_fname.Text = firstname;

            //    string lastname = dgvStudents.CurrentRow.Cells["last_name"].Value.ToString();
            //    txt_lname.Text = lastname;

            //    string address = dgvStudents.CurrentRow.Cells["address"].Value.ToString();
            //    txt_address.Text = address;


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please Select a row from the table:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



        }

        private void btngrade_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_grade.DataSource = dt;
                cmb_grade.DisplayMember = "grade_name";
                cmb_grade.ValueMember = "id";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while fetching student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_grade.SelectedValue.ToString());
        }

        private void btn_button2_Click(object sender, EventArgs e)
        {
            cmb_grade.SelectedValue = "10";
        }

        private void btngender_Click(object sender, EventArgs e)
        {

            // string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            // MySqlConnection conn = new MySqlConnection(connectionString);

            //try
            // {
            //     conn.Open();
            //     MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);

            //     MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //     DataTable dt = new DataTable();
            //     da.Fill(dt);

            //     string gender ="";
            //     if(rdoMale.Checked)
            //     {
            //         gender = "M";
            //     }
            //     else if(rdoFemale.Checked)
            //     {
            //         gender = "F";
            //     }
            //     MessageBox.Show("Gender: " + gender, "Gender Selection");

            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message.ToString());
            // }
            // finally
            // {
            //     conn.Close();
            // }

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void btn_dbshow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvStudents.CurrentRow.Cells["id"].Value.ToString();
                Frmdbshow f = new Frmdbshow(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }
    }
}
