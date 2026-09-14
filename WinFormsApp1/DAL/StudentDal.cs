using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace WinFormsApp1.DAL
{
    public class StudentDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        //----------------Show all student details in the form-----------------
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while fetching student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;  
            }
            finally
            {
                conn.Close();
            }
        }

        //----------------Show student details in the form based on the student ID-----------------
        public DataTable GetByID(string id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM students WHERE id = {id}", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
                return dt;
            }
        }
    }
}
