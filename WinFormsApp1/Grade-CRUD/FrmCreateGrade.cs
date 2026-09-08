using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Grade_CRUD
{
    public partial class FrmCreateGrade : Form
    {
        string gradeColour = "";
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public bool GradeSaved = false;

        public FrmCreateGrade()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_gradeName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the grade name.");
                return;
            }

            if (txt_gradegroup.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the grade group.");
                return;
            }

            if (txt_gradeorder.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the grade order.");
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

            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;Port=3306";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO grades " +
                    "(" +
                    "grade_name," +
                    "grade_group," +
                    "grade_order," +
                    "colour) " +

                    "VALUES " +
                    "(@grade_name," +
                    "@grade_group," +
                    "@grade_order," +
                    "@colour" +
                    ")" , conn
                 );
                cmd.Parameters.AddWithValue("@grade_name", txt_gradeName.Text.Trim());
                cmd.Parameters.AddWithValue("@grade_group", txt_gradegroup.Text.Trim());
                cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                cmd.Parameters.AddWithValue("@colour", gradeColour);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Grade was not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GradeSaved = true;
                MessageBox.Show("Grade created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error creating grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
