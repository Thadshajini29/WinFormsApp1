namespace WinFormsApp1
{
    partial class Frm_calculate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_number1 = new Label();
            lbl_number2 = new Label();
            txt_number1 = new TextBox();
            txt_number2 = new TextBox();
            btn_addition = new Button();
            btn_subtraction = new Button();
            btn_multiplication = new Button();
            btn_division = new Button();
            lbl_results = new Label();
            txt_results = new TextBox();
            lbl_error = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_back = new Button();
            SuspendLayout();
            // 
            // lbl_number1
            // 
            lbl_number1.AutoSize = true;
            lbl_number1.Location = new Point(28, 74);
            lbl_number1.Name = "lbl_number1";
            lbl_number1.Size = new Size(87, 25);
            lbl_number1.TabIndex = 0;
            lbl_number1.Text = "Number1";
            // 
            // lbl_number2
            // 
            lbl_number2.AutoSize = true;
            lbl_number2.Location = new Point(28, 136);
            lbl_number2.Name = "lbl_number2";
            lbl_number2.Size = new Size(87, 25);
            lbl_number2.TabIndex = 0;
            lbl_number2.Text = "Number2";
            // 
            // txt_number1
            // 
            txt_number1.Location = new Point(181, 79);
            txt_number1.Name = "txt_number1";
            txt_number1.Size = new Size(198, 31);
            txt_number1.TabIndex = 2;
            // 
            // txt_number2
            // 
            txt_number2.Location = new Point(181, 133);
            txt_number2.Name = "txt_number2";
            txt_number2.Size = new Size(198, 31);
            txt_number2.TabIndex = 2;
            // 
            // btn_addition
            // 
            btn_addition.Location = new Point(132, 210);
            btn_addition.Name = "btn_addition";
            btn_addition.Size = new Size(71, 75);
            btn_addition.TabIndex = 3;
            btn_addition.Text = "+";
            btn_addition.UseVisualStyleBackColor = true;
            btn_addition.Click += btn_addition_Click;
            // 
            // btn_subtraction
            // 
            btn_subtraction.Location = new Point(28, 210);
            btn_subtraction.Name = "btn_subtraction";
            btn_subtraction.Size = new Size(71, 75);
            btn_subtraction.TabIndex = 3;
            btn_subtraction.Text = "-";
            btn_subtraction.UseVisualStyleBackColor = true;
            btn_subtraction.Click += btn_subtraction_Click;
            // 
            // btn_multiplication
            // 
            btn_multiplication.Location = new Point(225, 210);
            btn_multiplication.Name = "btn_multiplication";
            btn_multiplication.Size = new Size(71, 75);
            btn_multiplication.TabIndex = 3;
            btn_multiplication.Text = "*";
            btn_multiplication.UseVisualStyleBackColor = true;
            btn_multiplication.Click += btn_multiplication_Click;
            // 
            // btn_division
            // 
            btn_division.Location = new Point(326, 210);
            btn_division.Name = "btn_division";
            btn_division.Size = new Size(71, 75);
            btn_division.TabIndex = 3;
            btn_division.Text = "/";
            btn_division.UseVisualStyleBackColor = true;
            btn_division.Click += btn_division_Click;
            // 
            // lbl_results
            // 
            lbl_results.AutoSize = true;
            lbl_results.Location = new Point(28, 336);
            lbl_results.Name = "lbl_results";
            lbl_results.Size = new Size(67, 25);
            lbl_results.TabIndex = 0;
            lbl_results.Text = "Results";
            // 
            // txt_results
            // 
            txt_results.Location = new Point(181, 336);
            txt_results.Name = "txt_results";
            txt_results.Size = new Size(198, 31);
            txt_results.TabIndex = 2;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(132, 386);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 25);
            lbl_error.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(280, 397);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(162, 34);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back to Master";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // Frm_calculate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_addition);
            Controls.Add(btn_subtraction);
            Controls.Add(btn_division);
            Controls.Add(btn_multiplication);
            Controls.Add(txt_results);
            Controls.Add(txt_number2);
            Controls.Add(txt_number1);
            Controls.Add(lbl_error);
            Controls.Add(lbl_results);
            Controls.Add(lbl_number2);
            Controls.Add(lbl_number1);
            Name = "Frm_calculate";
            Text = "Frm_calculate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_number1;
        private Label lbl_number2;
        private TextBox txt_number1;
        private TextBox txt_number2;
        private Button btn_addition;
        private Button btn_subtraction;
        private Button btn_multiplication;
        private Button btn_division;
        private Label lbl_results;
        private TextBox txt_results;
        private Label lbl_error;
        private System.Windows.Forms.Timer timer1;
        private Button btn_back;
    }
}
