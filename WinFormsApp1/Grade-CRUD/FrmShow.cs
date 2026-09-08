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
    public partial class FrmShow : Form
    {
        string gradeId;
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public FrmShow(string? id)
        {
            InitializeComponent();
            this.gradeId = id;
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {

            //string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;Port=3306";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", gradeId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow dr = dt.Rows[0];

                txt_gradeName.Text = dr["grade_name"].ToString();
                txt_gradegroup.Text = dr["grade_group"].ToString();
                txt_gradeorder.Text = dr["grade_order"].ToString();
                txt_colour.Text = dr["colour"].ToString();
                pnl_colour.BackColor = ColorTranslator.FromHtml(txt_colour.Text);

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
