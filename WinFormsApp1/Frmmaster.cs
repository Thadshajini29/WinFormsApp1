using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
