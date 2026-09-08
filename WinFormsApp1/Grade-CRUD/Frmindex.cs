using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1.Grade_CRUD
{
    public partial class Frmindex : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public Frmindex()
        {
            InitializeComponent();
        }

        private void Frmindex_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            FrmCreateGrade form = new FrmCreateGrade();
            form.ShowDialog();

            if (form.GradeSaved)
            {
                LoadGrades();
            }
        }

        private void btn_grades_Click(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void LoadGrades()
        {
            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;Port=3306";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                string query = "SELECT id, grade_name, grade_group, grade_order, colour FROM grades ORDER BY grade_order, id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgv_Grades.DataSource = null;
                dgv_Grades.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally

            {
                conn.Close();
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataGridViewRow? selectedRow = dgv_Grades.CurrentRow;
            if (selectedRow == null || selectedRow.Cells["id"].Value == null)
            {
                MessageBox.Show("Please select a grade from the table first.");
                return;
            }

            string gradeName = selectedRow.Cells["grade_name"].Value?.ToString();
            string gradeGroup = selectedRow.Cells["grade_group"].Value?.ToString();
            string gradeOrder = selectedRow.Cells["grade_order"].Value?.ToString() ;
            string colour = selectedRow.Cells["colour"].Value?.ToString();

            string id = selectedRow.Cells["id"].Value.ToString() ?? "";
            FrmShow form = new FrmShow(id);
            form.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow? selectedRow = dgv_Grades.CurrentRow;
            if (selectedRow == null || selectedRow.Cells["id"].Value == null)
            {
                MessageBox.Show("Please select a grade from the table first.");
                return;
            }

            string id = selectedRow.Cells["id"].Value.ToString();
            FrmEditGrade form = new FrmEditGrade(id);
            form.ShowDialog();
            LoadGrades();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow? selectedRow = dgv_Grades.CurrentRow;
            if (selectedRow == null || selectedRow.Cells["id"].Value == null)
            {
                MessageBox.Show("Please select a grade from the table first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this grade?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                string id = selectedRow.Cells["id"].Value.ToString() ?? "";
                MySqlCommand cmd = new MySqlCommand("DELETE FROM grades WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Grade deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrades();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error deleting grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
