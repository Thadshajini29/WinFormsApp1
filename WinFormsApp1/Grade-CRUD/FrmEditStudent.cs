using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Grade_CRUD
{
    public partial class FrmEditGrade : Form
    {
        string gradeId;
        string gradeColour = "";

        public FrmEditGrade(string id)
        {
            InitializeComponent();
            gradeId = id;
        }

        private void FrmEditGrade_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", gradeId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_gradeName.Text = reader["grade_name"].ToString();
                    txt_gradegroup.Text = reader["grade_group"].ToString();
                    txt_gradeorder.Text = reader["grade_order"].ToString();
                    gradeColour = reader["colour"].ToString() ?? "";

                    if (gradeColour != "")
                    {
                        btn_colour.BackColor = ColorTranslator.FromHtml(gradeColour);
                    }
                }
                else
                {
                    MessageBox.Show("Grade not found.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grade: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_colour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gradeColour = ColorTranslator.ToHtml(colorDialog1.Color);
                btn_colour.BackColor = colorDialog1.Color;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_gradeName.Text.Trim() == "" || txt_gradegroup.Text.Trim() == "" || txt_gradeorder.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all grade details.");
                return;
            }

            if (!int.TryParse(txt_gradeorder.Text.Trim(), out int gradeOrder))
            {
                MessageBox.Show("Grade order must be a number.");
                return;
            }

            if (gradeColour == "")
            {
                MessageBox.Show("Please select a colour.");
                return;
            }

            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE grades SET grade_name = @grade_name, grade_group = @grade_group, grade_order = @grade_order, colour = @colour WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@grade_name", txt_gradeName.Text.Trim());
                cmd.Parameters.AddWithValue("@grade_group", txt_gradegroup.Text.Trim());
                cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                cmd.Parameters.AddWithValue("@colour", gradeColour);
                cmd.Parameters.AddWithValue("@id", gradeId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Grade updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
