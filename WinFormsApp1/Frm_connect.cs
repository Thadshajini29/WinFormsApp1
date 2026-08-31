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
            string connectionString = "Server=localhost;Database=test_db;Uid=root;Pwd=root;";
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
            string connectionString = "Server=localhost;Database=test_db;Uid=root;Pwd=root;";
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
    }
}
