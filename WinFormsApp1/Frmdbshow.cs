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
    public partial class Frmdbshow : Form
    {
        string studentId;
        public Frmdbshow(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void Frmdbshow_Load(object sender, EventArgs e)
        {
            //txt_fname.Text = studentId;



            string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                //--------------------------Load grades into ComboBox-------------------------------
                string gradeQuery = "SELECT id, grade_name FROM grades";
                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);

                cmb_grade.DataSource = gradeTable;
                cmb_grade.DisplayMember = "grade_name";
                cmb_grade.ValueMember = "id";

                //-------------------------------Load Houses into ComboBox----------------------------
                string houseQuery = "SELECT id, house_name FROM houses";

                MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                DataTable houseTable = new DataTable();
                houseAdapter.Fill(houseTable);

                cmbhouse.DataSource = houseTable;
                cmbhouse.DisplayMember = "house_name";
                cmbhouse.ValueMember = "id";

                //-------------------------------Load Families into ComboBox----------------------------

                string familyQuery = "SELECT id FROM families";

                MySqlDataAdapter familyAdapter =
                    new MySqlDataAdapter(familyQuery, conn);

                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                cmb_familyid.DataSource = familyTable;
                cmb_familyid.DisplayMember = "id";
                cmb_familyid.ValueMember = "id";


                //-------------------------------Load Student Data into Form Controls--------------------------------
                MySqlCommand cmd = new MySqlCommand($"select * from students where id={this.studentId}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow dr = dt.Rows[0];

                //-------------------------------Load Student Data into TextBoxes--------------------------------
                txt_fname.Text = dr["first_name"].ToString();
                txt_lname.Text = dr["last_name"].ToString();
                txt_address.Text = dr["per_address"].ToString();
                txtaddmission.Text = dr["admission_number"].ToString();
                txt_nic.Text = dr["nic_number"].ToString();
                txt_phone.Text = dr["tele_number"].ToString();

                //-------------------------------Load Gender---------------------------------
                string gender = dr["gender"].ToString();

                rdoMale.Checked = gender == "M";
                rdoFemale.Checked = gender == "F";

                //-------------------------------Load Grade into ComboBoxes--------------------------------
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmb_grade.SelectedValue = dr["grade_id"];
                }
                else
                {
                    cmb_grade.SelectedIndex = -1;
                    cmb_grade.Text = "N/A";
                }

                //-------------------------------Load Date of Birth into DateTimePicker--------------------------------
                if (dr["date_of_birth"] != DBNull.Value)

                {
                    dtp_dob.Value =
                        Convert.ToDateTime(dr["date_of_birth"]);
                }

                else
                {
                    dtp_dob.Value = DateTime.Now;
                }


                //--------------------------------Load House into ComboBoxes--------------------------------
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

                //-------------------------------Load Medium into ComboBoxes--------------------------------        
                if (dr["medium"] != DBNull.Value)
                {
                    cmb_medium.Text =
                        dr["medium"].ToString();
                }
                else
                {
                    cmb_medium.Text = "N/A";
                }

                //---------------------Family ID-------------------------------------

                if (dr["family_id"] != DBNull.Value)
                {
                    cmb_familyid.SelectedValue = dr["family_id"].ToString();
                }
                else
                {
                    cmb_familyid.SelectedIndex = -1;
                    cmb_familyid.Text = "N/A";
                }


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

        private void lbl_familyid_Click(object sender, EventArgs e)
        {

        }

        private void cmbhouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
