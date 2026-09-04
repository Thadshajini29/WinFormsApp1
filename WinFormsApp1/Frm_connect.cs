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
            if (dgvStudents.CurrentRow == null || !dgvStudents.Columns.Contains("id"))
            {
                MessageBox.Show("Please select a student from the table first.");
                return;
            }
            try
            {
                object idValue = dgvStudents.CurrentRow.Cells["id"].Value;
                string studentId = idValue == null || idValue == DBNull.Value ? "" : idValue.ToString() ?? "";
                if (string.IsNullOrEmpty(studentId))
                {
                    MessageBox.Show("Please select a valid student.");
                    return;
                }

                string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT s.*, g.grade_name, h.house_name " +
                               "FROM students s " +
                               "LEFT JOIN grades g ON s.grade_id = g.id " +
                               "LEFT JOIN houses h ON s.house_id = h.id " +
                               "WHERE s.id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", studentId);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data Not Found.");
                    return;
                }

                DataRow dr = dt.Rows[0];
                string firstname = dr["first_name"] == DBNull.Value ? "" :
                    dr["first_name"].ToString() ?? "";
                string lastname = dr["last_name"] == DBNull.Value ? "" :
                    dr["last_name"].ToString() ?? "";
                string address = dr["per_address"] == DBNull.Value ? "" :
                    dr["per_address"].ToString() ?? "";
                string gender = dr["gender"] == DBNull.Value ? "" :
                    dr["gender"].ToString() ?? "";
                string grade = dr["grade_name"] == DBNull.Value ? "N/A" :
                    dr["grade_name"].ToString() ?? "N/A";
                string medium = dr["medium"] == DBNull.Value ? "N/A" :
                    dr["medium"].ToString() ?? "N/A";
                string house = dr["house_name"] == DBNull.Value ? "N/A" :
                    dr["house_name"].ToString() ?? "N/A";
                string phone = dr["tele_number"] == DBNull.Value ? "N/A" :
                    dr["tele_number"].ToString() ?? "N/A";
                string nic = dr["nic_number"] == DBNull.Value ? "N/A" :
                    dr["nic_number"].ToString() ?? "N/A";
                string addmission = dr["admission_number"] == DBNull.Value ? "N/A" :
                    dr["admission_number"].ToString() ?? "N/A";
                string family = dr["family_id"] == DBNull.Value ? "N/A" :
                    dr["family_id"].ToString() ?? "N/A";
                DateTime dob = dr["date_of_birth"] == DBNull.Value ? DateTime.Today :
                    Convert.ToDateTime(dr["date_of_birth"]);

                txt_fname.Text = firstname;
                txt_lname.Text = lastname;
                txt_address.Text = address;
                txtaddmission.Text = addmission;
                txt_nic.Text = nic;
                txt_phone.Text = phone;
                rdoMale.Checked = gender == "M" || gender == "Male";
                rdoFemale.Checked = gender == "F" || gender == "Female";
                cmb_grade.Text = grade;
                cmb_medium.Text = medium;
                cmbhouse.Text = house;
                cmb_familyid.Text = family;
                dtp_dob.Value = dob;

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

                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load student data: " + ex.Message);
            }

            // ------------------Code to display student details in a new form.------------------
            //try
            //{
            //    string firstname = dgvStudents.CurrentRow.Cells["first_name"].Value.ToString();
            //    string lastname = dgvStudents.CurrentRow.Cells["last_name"].Value.ToString();
            //    string address = dgvStudents.CurrentRow.Cells["per_address"].Value.ToString();

            //    string gender = dgvStudents.CurrentRow.Cells["gender"].Value.ToString();

            //    if (gender == "M")
            //    {
            //        rdoMale.Checked = true;
            //    }
            //    else if (gender == "F")
            //    {
            //        rdoFemale.Checked = true;
            //    }


            //    string grade = "N/A";

            //    string gradeId =
            //        dgvStudents.CurrentRow.Cells["grade_id"].Value.ToString();

            //    if (!string.IsNullOrEmpty(gradeId))
            //    {
            //        cmb_grade.SelectedValue = gradeId;
            //        grade = cmb_grade.Text;
            //    }


            //    string medium = dgvStudents.CurrentRow.Cells["medium"].Value.ToString();

            //    if (string.IsNullOrEmpty(medium))
            //    {
            //        medium = "N/A";
            //    }

            //    string house = dgvStudents.CurrentRow.Cells["house_id"].Value.ToString();
            //    if (string.IsNullOrEmpty(house))
            //    {
            //        house = "N/A";
            //    }

            //    DateTime dob = Convert.ToDateTime(dgvStudents.CurrentRow.Cells["date_of_birth"].Value);

            //    string phone = dgvStudents.CurrentRow.Cells["tele_number"].Value.ToString();
            //    if (string.IsNullOrEmpty(phone))
            //    {
            //        phone = "N/A";
            //    }

            //    string nic = dgvStudents.CurrentRow.Cells["nic_number"].Value.ToString();
            //    if (string.IsNullOrEmpty(nic))
            //    {
            //        nic = "N/A";
            //    }

            //    string addmission = dgvStudents.CurrentRow.Cells["admission_number"].Value.ToString();
            //    if (string.IsNullOrEmpty(addmission))
            //    {
            //        addmission = "N/A";
            //    }

            //    string family = dgvStudents.CurrentRow.Cells["family_id"].Value.ToString();
            //    if (string.IsNullOrEmpty(family))
            //    {
            //        family = "N/A";
            //    }

            //    FrmShowStudent f = new FrmShowStudent(
            //        firstname,
            //        lastname,
            //        address,
            //        gender,
            //        grade,
            //        medium,
            //        house,
            //        dob,
            //        phone,
            //        nic,
            //        addmission,
            //        family

            //    );

            //    f.ShowDialog();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //    throw;
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frmmaster frmmaster = new Frmmaster();
            frmmaster.Show();

            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvStudents.CurrentRow.Cells["id"].Value?.ToString();
                FrmEditStudent f = new FrmEditStudent(id);
                f.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                if (dgvStudents.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvStudents.CurrentRow.Cells["id"].Value?.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM students WHERE id = {id}", conn);
                    int affected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully. Rows Affected: " + affected.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting the databse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
