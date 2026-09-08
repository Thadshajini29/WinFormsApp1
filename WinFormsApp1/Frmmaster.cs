using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Grade_CRUD;

namespace WinFormsApp1
{
    public partial class Frmmaster : Form
    {
        public Frmmaster()
        {
            InitializeComponent();
        }

        private void btnfullname_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

            this.Hide();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            Frm_calculate frmcalculate = new Frm_calculate();
            frmcalculate.Show();

            this.Hide();
        }

        private void btn_combobox_Click(object sender, EventArgs e)
        {
            Frm_combobox frmcombobox = new Frm_combobox();
            frmcombobox.Show();

            this.Hide();
        }

        private void btn_filldata_Click(object sender, EventArgs e)
        {
            FrmStudent frmstudent = new FrmStudent();
            frmstudent.Show();

            this.Hide();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Frm_connect frmconnect = new Frm_connect();
            frmconnect.Show();

            this.Hide();
        }

        private void btn_dbshow_Click(object sender, EventArgs e)
        {
            Frm_connect frmconnect = new Frm_connect();
            frmconnect.Show();

            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Frmindex frmindex = new Frmindex();
            frmindex.Show();
            this.Hide();
        }
    }
}
