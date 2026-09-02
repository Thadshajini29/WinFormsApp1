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
    public partial class FrmShowStudent : Form
    {
        string fname;
        string lname;
        string address;
        string gender;
        string grade;
        string medium;
        string house;
        DateTime DOB;
        string phone;
        string Nic;
        string addmission;
        string family;
        public FrmShowStudent(
            string firstname,
            string lastname,
            string address,
            string gender,
            string grade,
            string medium,
            string house,
            DateTime dob,
            string phone,
            string nic,
            string addmission,
            string family




            )
        {
            InitializeComponent();
            this.fname = firstname;
            this.lname = lastname;
            this.address = address;
            this.gender = gender;
            this.grade = grade;
            this.medium = medium;
            this.house = house;
            this.DOB = dob;
            this.phone = phone;
            this.Nic = nic;
            this.addmission = addmission;
            this.family = family;
        }

        private void FrmShowStudent_Load(object sender, EventArgs e)
        {
            txt_fname.Text = fname;
            txt_lname.Text = lname;
            txt_address.Text = address;
            rdoMale.Checked = gender == "M";
            rdoFemale.Checked = gender == "F";


            cmb_grade.Text = grade;
            cmb_medium.Text = medium;
            cmbhouse.Text = house;
            dtp_dob.Value = DOB;
            txt_phone.Text = phone;
            txt_nic.Text = Nic;
            txtaddmission.Text = addmission;
            cmb_familyid.Text = family;

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
    }
}
