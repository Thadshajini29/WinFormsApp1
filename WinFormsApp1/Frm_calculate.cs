using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Frm_calculate : Form

    {
        double number1;
        double number2;
        double result;
        public Frm_calculate()
        {
            InitializeComponent();
            txt_results.ReadOnly = true;
            lbl_error.Text = "";
            timer1.Interval = 3000;
        }


        private void btn_addition_Click(object sender, EventArgs e)
        {

            try
            {
                lbl_error.Text = "";
                txt_results.Clear();

                if (string.IsNullOrEmpty(txt_number1.Text))
                {
                    lbl_error.Text = "Please enter Number1";
                    txt_number1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txt_number2.Text))
                {
                    lbl_error.Text = "Please enter Number2";
                    txt_number2.Focus();
                    timer1.Start();
                    return;
                }

                number1 = Convert.ToDouble(txt_number1.Text);
                number2 = Convert.ToDouble(txt_number2.Text);


                result = number1 + number2;
                txt_results.Text = result.ToString();

            }
            catch (FormatException)
            {
                lbl_error.Text = "Please enter valid numbers";
                timer1.Start();
            }

            catch (Exception ex)
            {
                lbl_error.Text = "An error occurred: " + ex.Message;
                timer1.Start();
            }


        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Text = "";
                txt_results.Clear();

                if (string.IsNullOrEmpty(txt_number1.Text))
                {
                    lbl_error.Text = "Please enter Number1";
                    txt_number1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txt_number2.Text))
                {
                    lbl_error.Text = "Please enter Number2";
                    txt_number2.Focus();
                    timer1.Start();
                    return;
                }

                if (!double.TryParse(txt_number1.Text, out number1))
                {
                    lbl_error.Text = "Number1 must be a valid number.";
                    txt_number1.Focus();
                    timer1.Start();
                    txt_number1.SelectAll();
                    return;
                }

                if (!double.TryParse(txt_number2.Text, out number2))
                {
                    lbl_error.Text = "Number2 must be a valid number.";
                    txt_number2.Focus();
                    timer1.Start();
                    txt_number2.SelectAll();
                    return;
                }

                result = number1 - number2;
                txt_results.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lbl_error.Text = "An error occurred: " + ex.Message;
            }
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Text = "";
                txt_results.Clear();

                if (string.IsNullOrEmpty(txt_number1.Text))
                {
                    lbl_error.Text = "Please enter Number1";
                    txt_number1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txt_number2.Text))
                {
                    lbl_error.Text = "Please enter Number2";
                    txt_number2.Focus();
                    timer1.Start();
                    return;
                }

                if (!double.TryParse(txt_number1.Text, out number1))
                {
                    lbl_error.Text = "Number1 must be a valid number.";
                    txt_number1.Focus();
                    timer1.Start();
                    txt_number1.SelectAll();
                    return;
                }

                if (!double.TryParse(txt_number2.Text, out number2))
                {
                    lbl_error.Text = "Number2 must be a valid number.";
                    txt_number2.Focus();
                    timer1.Start();
                    txt_number2.SelectAll();
                    return;
                }

                result = number1 * number2;
                txt_results.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lbl_error.Text = "An error occurred: " + ex.Message;
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Text = "";
                txt_results.Clear();

                if (string.IsNullOrEmpty(txt_number1.Text))
                {
                    lbl_error.Text = "Please enter Number1";
                    txt_number1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txt_number2.Text))
                {
                    lbl_error.Text = "Please enter Number2";
                    txt_number2.Focus();
                    timer1.Start();
                    return;
                }

                if (!double.TryParse(txt_number1.Text, out number1))
                {
                    lbl_error.Text = "Number1 must be a valid number.";
                    txt_number1.Focus();
                    timer1.Start();
                    txt_number1.SelectAll();
                    return;
                }

                if (!double.TryParse(txt_number2.Text, out number2))
                {
                    lbl_error.Text = "Number2 must be a valid number.";
                    txt_number2.Focus();
                    timer1.Start();
                    txt_number2.SelectAll();
                    return;
                }

                if (number2 == 0)
                {
                    lbl_error.Text = "zero is not allowed";
                    txt_number2.Focus();
                    timer1.Start();
                    txt_number2.SelectAll();
                    return;
                }

                result = number1 / number2;
                txt_results.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lbl_error.Text = "An error occurred: " + ex.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            timer1.Stop();
        }
    }
}
