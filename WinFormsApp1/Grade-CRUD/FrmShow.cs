using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Grade_CRUD
{
    public partial class FrmShow : Form
    {
        public FrmShow(string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            InitializeComponent();
            txt_gradeName.Text = gradeName;
            txt_gradegroup.Text = gradeGroup;
            txt_gradeorder.Text = gradeOrder;
            txt_colour.Text = colour;

            if (colour != "")
            {
                pnl_colour.BackColor = ColorTranslator.FromHtml(colour);
            }
        }
    }
}
