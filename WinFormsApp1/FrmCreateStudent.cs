using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class FrmCreateStudent : Form
    {
        public FrmCreateStudent()
        {
            InitializeComponent();
        }

        private void FrmCreateStudent_Load(object sender, EventArgs e)
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading student details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the first name.");
                return;
            }

            if (txt_lname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the last name.");
                return;
            }

            if (txt_address.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the address.");
                return;
            }

            if (txtaddmission.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the admission number.");
                return;
            }

            if (txt_nic.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the NIC number.");
                return;
            }

            if (txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the phone number.");
                return;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (cmb_grade.SelectedValue == null)
            {
                MessageBox.Show("Please select a grade.");
                return;
            }

            if (cmbhouse.SelectedValue == null)
            {
                MessageBox.Show("Please select a house.");
                return;
            }

            if (cmb_medium.Text == "")
            {
                MessageBox.Show("Please select a medium.");
                return;
            }

            if (txt_familyid.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the family ID.");
                return;
            }

            if (dtp_dob.Value > DateTime.Today)
            {
                MessageBox.Show("Please select a valid date of birth.");
                return;
            }

            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO students " +
                    "(first_name," +
                    "last_name," +
                    "per_address," +
                    "grade_id," +
                    "house_id," +
                    "medium," +
                    "date_of_birth," +
                    "family_id, gender," +
                    "admission_number," +
                    "nic_number," +
                    "tele_number) " +
                    "VALUES (" +
                    "@first_name," +
                    "@last_name," +
                    "@per_address," +
                    "@grade_id," +
                    "@house_id," +
                    "@medium," +
                    "@date_of_birth," +
                    "@family_id, @gender," +
                    "@admission_number," +
                    "@nic_number," +
                    "@tele_number)",
                    conn
                    );

                cmd.Parameters.AddWithValue("@first_name", txt_fname.Text);
                cmd.Parameters.AddWithValue("@last_name", txt_lname.Text);
                cmd.Parameters.AddWithValue("@per_address", txt_address.Text);
                cmd.Parameters.AddWithValue("@grade_id", cmb_grade.SelectedValue);
                cmd.Parameters.AddWithValue("@house_id", cmbhouse.SelectedValue);
                cmd.Parameters.AddWithValue("@medium", cmb_medium.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", dtp_dob.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@family_id", txt_familyid.Text);
                cmd.Parameters.AddWithValue("@gender", rdoMale.Checked ? "M" : "F");
                cmd.Parameters.AddWithValue("@admission_number", txtaddmission.Text);
                cmd.Parameters.AddWithValue("@nic_number", txt_nic.Text);
                cmd.Parameters.AddWithValue("@tele_number", txt_phone.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while creating the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbhouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
