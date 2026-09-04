using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class FrmEditStudent : Form
    {
        private string studentId;

        public FrmEditStudent(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }

        private void FrmEditStudent_Load(object sender, EventArgs e)
        {


            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string gradeQuery = "SELECT id, grade_name FROM grades";
                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);
                cmb_grade.DataSource = gradeTable;
                cmb_grade.DisplayMember = "grade_name";
                cmb_grade.ValueMember = "id";

                string houseQuery = "SELECT id, house_name FROM houses";
                MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                DataTable houseTable = new DataTable();
                houseAdapter.Fill(houseTable);
                cmbhouse.DataSource = houseTable;
                cmbhouse.DisplayMember = "house_name";
                cmbhouse.ValueMember = "id";

                //string familyQuery = "SELECT id FROM families";
                //MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);
                //DataTable familyTable = new DataTable();
                //familyAdapter.Fill(familyTable);
                //cmb_familyid.DataSource = familyTable;
                //cmb_familyid.DisplayMember = "mobile_number";
                //cmb_familyid.ValueMember = "id";

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM students WHERE id = {this.studentId}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                DataRow dr = dt.Rows[0];

                txt_fname.Text = dr["first_name"].ToString();
                txt_lname.Text = dr["last_name"].ToString();
                txt_address.Text = dr["per_address"].ToString();

                //***********Grade ComboBox Selection***********
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmb_grade.SelectedValue = dr["grade_id"];
                }
                else
                {
                    cmb_grade.SelectedIndex = -1;
                    cmb_grade.Text = "N/A";
                }

                //***********Family ComboBox Selection***********
                if (dr["house_id"] != DBNull.Value)
                {
                    int houseId = Convert.ToInt32(dr["house_id"]);

                    cmbhouse.SelectedValue = houseId;
                }
                else
                {
                    cmbhouse.SelectedIndex = -1;
                    cmbhouse.Text = "N/A";
                }

                //***********Medium ComboBox Selection***********
                if (dr["medium"] != DBNull.Value && !string.IsNullOrEmpty(dr["medium"].ToString()))
                {
                    cmb_medium.Text = dr["medium"].ToString();
                }
                else
                {
                    cmb_medium.Text = "N/A";
                }

                //************Date of Birth****************
                if (dr["date_of_birth"] != DBNull.Value)
                {
                    dtp_dob.Value = Convert.ToDateTime(dr["date_of_birth"]);
                }

                //************Gender****************

                string gender = dr["gender"].ToString();

                if (gender == "M")
                {
                    rdoMale.Checked = true;
                }
                else if (gender == "F")
                {
                    rdoFemale.Checked = true;
                }

                //************Admission Number****************
                txtaddmission.Text = dr["admission_number"].ToString();

                //************NIC Number****************
                txt_nic.Text = dr["nic_number"].ToString();

                //************Telephone Number****************
                txt_phone.Text = dr["tele_number"].ToString();

                // Load families
                string familyQuery = "SELECT id, mobile_number FROM families";

                MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);
                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                //*****************Guardian Mobile Number********************
                if (dr["family_id"] != DBNull.Value)
                {
                    string familyId = dr["family_id"].ToString();

                    foreach (DataRow familyRow in familyTable.Rows)
                    {
                        if (familyRow["id"].ToString() == familyId)
                        {
                            txt_Family.Text = familyRow["mobile_number"].ToString();
                            break;
                        }
                    }
                }
                else
                {
                    txt_Family.Text = "N/A";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }


        private void cmb_grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void lblgrade_Click(object sender, EventArgs e)
        {

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_medium_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                //MySqlCommand cmd = new MySqlCommand($"UPDATE students SET first_name ='{txt_fname.Text}', last_name ='{txt_lname.Text}' , per_address ='{txt_address.Text}'  WHERE id ={this.studentId}", conn);

               MySqlCommand cmd = new MySqlCommand(
               "UPDATE students SET " +
               "first_name=@first_name, " +
               "last_name=@last_name, " +
               "per_address=@per_address, " +
               "grade_id=@grade_id, " +
               "house_id=@house_id, " +
               "medium=@medium, " +
               "date_of_birth=@date_of_birth, " +
               "family_id=@family_id, " +
               "gender=@gender, " +
               "admission_number=@admission_number, " +
               "nic_number=@nic_number, " +
               "tele_number=@tele_number " +
               "WHERE id=@id", conn);

                cmd.Parameters.AddWithValue("@first_name", txt_fname.Text);
                cmd.Parameters.AddWithValue("@last_name", txt_lname.Text);
                cmd.Parameters.AddWithValue("@per_address", txt_address.Text);

                //---------------Grade ComboBox--------------------------------
                cmd.Parameters.AddWithValue("@grade_id", cmb_grade.SelectedValue);

                //---------------House ComboBox--------------------------------
                cmd.Parameters.AddWithValue("@house_id", cmbhouse.SelectedValue);

                //---------------Medium ComboBox--------------------------------
                cmd.Parameters.AddWithValue("@medium", cmb_medium.Text);

                //---------------date of birth--------------------------------
                cmd.Parameters.AddWithValue("@date_of_birth", dtp_dob.Value.ToString("yyyy-MM-dd"));

                cmd.Parameters.AddWithValue("@gender", rdoMale.Checked ? "M" : "F");
                cmd.Parameters.AddWithValue("@admission_number", txtaddmission.Text);
                cmd.Parameters.AddWithValue("@nic_number", txt_nic.Text);
                cmd.Parameters.AddWithValue("@family_id", txt_Family.Text);

                cmd.Parameters.AddWithValue("@tele_number", txt_phone.Text);
                cmd.Parameters.AddWithValue("@id", this.studentId);

                string affectedRow = cmd.ExecuteNonQuery().ToString();
                MessageBox.Show("Updated successfully. Rows Affected: " + affectedRow, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (MySqlException ex)
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
