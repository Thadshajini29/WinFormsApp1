using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
            timer1.Interval = 3000;

        }

        private void btn_filldata_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            if (string.IsNullOrEmpty(txt_firstname.Text))
            {

                lbl_error.Text = "Please enter the first name.";
                txt_firstname.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }

            if (string.IsNullOrEmpty(txt_lastname.Text))
            {

                lbl_error.Text = "Please enter the last name.";
                txt_lastname.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }

            if (date_dob.Value.Date >= DateTime.Today)
            {

                lbl_error.Text = "Please select a valid date of birth.";
                date_dob.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }

            if (string.IsNullOrEmpty(txt_address.Text))
            {

                lbl_error.Text = "Please enter the address.";
                txt_address.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }

            if (string.IsNullOrEmpty(txt_telephonenumber.Text))
            {

                lbl_error.Text = "Please enter the telephone number.";
                txt_telephonenumber.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }

            //if (!long.TryParse(txt_telephonenumber.Text, out _))
            //{
            //    MessageBox.Show(
            //        "Telephone number must contain only numbers.",
            //        "Validation Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //    );

            //    txt_telephonenumber.Focus();
            //    return;
            //}

            if (!btn_male.Checked && !btn_female.Checked)
            {

                lbl_error.Text = "Please select a gender";
                txt_telephonenumber.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }

            if (string.IsNullOrEmpty(txt_nic.Text))
            {

                lbl_error.Text = "Please enter the NIC number.";
                txt_nic.Focus();
                timer1.Start();
                //timer1.Stop();
                return;
            }


            string fname = txt_firstname.Text.Trim();
            string lname = txt_lastname.Text.Trim();
            DateTime DoB = date_dob.Value;
            string address = txt_address.Text.Trim();
            string telephone = txt_telephonenumber.Text.Trim();
            string gender = btn_male.Checked ? "Male" : "Female";
            string nic = txt_nic.Text.Trim();


            txt_fname.Text = fname;
            txt_lname.Text = lname;
            date_dateofbirth.Value = DoB;
            txt_textarea.Text = address;
            txt_phone.Text = telephone;

            btn_malee.Checked = btn_male.Checked;
            btn_femalee.Checked = btn_female.Checked;

            txt_nicnumber.Text = nic;

            lbl_error.Text = "";
            timer1.Stop();

            //MessageBox.Show(
            //    $"First Name: {fname}\n" +
            //    $"Last Name: {lname}\n" +
            //    $"Date of Birth: {DoB.ToShortDateString()}\n" +
            //    $"Address: {address}\n" +
            //    $"Telephone: {telephone}\n" +
            //    $"Gender: {gender}\n" +
            //    $"NIC: {nic}",
            //    "Student Information",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            timer1.Stop();
        }

        private void lbl_error_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frmmaster frmmaster = new Frmmaster();
            frmmaster.Show();

            this.Close();
        }
    }
}
