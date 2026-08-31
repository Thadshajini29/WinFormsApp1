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
        public FrmShowStudent(string firstname, string lastname, string address, string gender)
        {
            InitializeComponent();
            this.fname = firstname;
            this.lname = lastname;
            this.address = address;
            this.gender = gender;
        }

        private void FrmShowStudent_Load(object sender, EventArgs e)
        {
            txt_fname.Text = fname;
            txt_lname.Text = lname;
            txt_address.Text = address;
            rdoMale.Checked = gender == "M";
            rdoFemale.Checked = gender == "F";
        }
    }
}
