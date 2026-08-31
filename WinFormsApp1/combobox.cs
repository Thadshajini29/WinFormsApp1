using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Frm_combobox : Form
    {
        public Frm_combobox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    MessageBox.Show(cmb_subject.SelectedItem.ToString());
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Please select a subject from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //---------Use SelectedItem to combo box and assign to another combo box-----------------
            //string selectSubject = cmb_subject.SelectedItem?.ToString();

            //cmb_selectedsubject.SelectedItem = selectSubject;

            //MessageBox.Show(cmb_subject.SelectedItem.ToString());


            //----------------Use SelectedIndex to combo box and assign to another combo box-----------------
            string selectSubject = cmb_subject.SelectedIndex.ToString();

            if (cmb_subject.SelectedIndex != -1)
            {
                cmb_selectedsubject.SelectedIndex = int.Parse(selectSubject);
                MessageBox.Show(cmb_subject.SelectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("Please select a subject from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

    }
}
