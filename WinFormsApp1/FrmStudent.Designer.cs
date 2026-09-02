namespace WinFormsApp1
{
    partial class FrmStudent
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
            lbl_firstname = new Label();
            lbl_lastname = new Label();
            lbl_dob = new Label();
            lbl_address = new Label();
            lbl_phonenumber = new Label();
            lbl_gender = new Label();
            lbl_nic = new Label();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            txt_address = new TextBox();
            date_dob = new DateTimePicker();
            txt_telephonenumber = new TextBox();
            btn_male = new RadioButton();
            btn_female = new RadioButton();
            txt_nic = new TextBox();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            date_dateofbirth = new DateTimePicker();
            txt_textarea = new TextBox();
            txt_phone = new TextBox();
            btn_malee = new RadioButton();
            btn_femalee = new RadioButton();
            txt_nicnumber = new TextBox();
            btn_filldata = new Button();
            lbl_information = new Label();
            lbl_error = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Back = new Button();
            SuspendLayout();
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(12, 71);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(97, 25);
            lbl_firstname.TabIndex = 0;
            lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Location = new Point(12, 122);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(95, 25);
            lbl_lastname.TabIndex = 0;
            lbl_lastname.Text = "Last Name";
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Location = new Point(12, 182);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(49, 25);
            lbl_dob.TabIndex = 0;
            lbl_dob.Text = "DOB";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(12, 240);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(77, 25);
            lbl_address.TabIndex = 0;
            lbl_address.Text = "Address";
            // 
            // lbl_phonenumber
            // 
            lbl_phonenumber.AutoSize = true;
            lbl_phonenumber.Location = new Point(12, 296);
            lbl_phonenumber.Name = "lbl_phonenumber";
            lbl_phonenumber.Size = new Size(92, 25);
            lbl_phonenumber.TabIndex = 0;
            lbl_phonenumber.Text = "Telephone";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Location = new Point(12, 347);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(69, 25);
            lbl_gender.TabIndex = 0;
            lbl_gender.Text = "Gender";
            // 
            // lbl_nic
            // 
            lbl_nic.AutoSize = true;
            lbl_nic.Location = new Point(12, 401);
            lbl_nic.Name = "lbl_nic";
            lbl_nic.RightToLeft = RightToLeft.No;
            lbl_nic.Size = new Size(41, 25);
            lbl_nic.TabIndex = 0;
            lbl_nic.Text = "NIC";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(132, 65);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(219, 31);
            txt_firstname.TabIndex = 1;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(132, 122);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(219, 31);
            txt_lastname.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(132, 234);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(219, 31);
            txt_address.TabIndex = 1;
            // 
            // date_dob
            // 
            date_dob.Location = new Point(132, 177);
            date_dob.Name = "date_dob";
            date_dob.Size = new Size(219, 31);
            date_dob.TabIndex = 2;
            // 
            // txt_telephonenumber
            // 
            txt_telephonenumber.Location = new Point(132, 293);
            txt_telephonenumber.Name = "txt_telephonenumber";
            txt_telephonenumber.Size = new Size(219, 31);
            txt_telephonenumber.TabIndex = 1;
            // 
            // btn_male
            // 
            btn_male.AutoSize = true;
            btn_male.Location = new Point(132, 347);
            btn_male.Name = "btn_male";
            btn_male.Size = new Size(75, 29);
            btn_male.TabIndex = 3;
            btn_male.TabStop = true;
            btn_male.Text = "Male";
            btn_male.UseVisualStyleBackColor = true;
            // 
            // btn_female
            // 
            btn_female.AutoSize = true;
            btn_female.Location = new Point(258, 343);
            btn_female.Name = "btn_female";
            btn_female.Size = new Size(93, 29);
            btn_female.TabIndex = 4;
            btn_female.TabStop = true;
            btn_female.Text = "Female";
            btn_female.UseVisualStyleBackColor = true;
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(132, 401);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(219, 31);
            txt_nic.TabIndex = 1;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(388, 68);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(219, 31);
            txt_fname.TabIndex = 1;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(388, 116);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(219, 31);
            txt_lname.TabIndex = 1;
            // 
            // date_dateofbirth
            // 
            date_dateofbirth.Location = new Point(388, 177);
            date_dateofbirth.Name = "date_dateofbirth";
            date_dateofbirth.Size = new Size(219, 31);
            date_dateofbirth.TabIndex = 2;
            // 
            // txt_textarea
            // 
            txt_textarea.Location = new Point(388, 234);
            txt_textarea.Name = "txt_textarea";
            txt_textarea.Size = new Size(219, 31);
            txt_textarea.TabIndex = 1;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(388, 293);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(219, 31);
            txt_phone.TabIndex = 1;
            // 
            // btn_malee
            // 
            btn_malee.AutoSize = true;
            btn_malee.Location = new Point(388, 343);
            btn_malee.Name = "btn_malee";
            btn_malee.Size = new Size(75, 29);
            btn_malee.TabIndex = 3;
            btn_malee.TabStop = true;
            btn_malee.Text = "Male";
            btn_malee.UseVisualStyleBackColor = true;
            // 
            // btn_femalee
            // 
            btn_femalee.AutoSize = true;
            btn_femalee.Location = new Point(514, 347);
            btn_femalee.Name = "btn_femalee";
            btn_femalee.Size = new Size(93, 29);
            btn_femalee.TabIndex = 4;
            btn_femalee.TabStop = true;
            btn_femalee.Text = "Female";
            btn_femalee.UseVisualStyleBackColor = true;
            // 
            // txt_nicnumber
            // 
            txt_nicnumber.Location = new Point(388, 401);
            txt_nicnumber.Name = "txt_nicnumber";
            txt_nicnumber.Size = new Size(219, 31);
            txt_nicnumber.TabIndex = 1;
            // 
            // btn_filldata
            // 
            btn_filldata.BackColor = Color.FromArgb(25, 118, 210);
            btn_filldata.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_filldata.ForeColor = Color.White;
            btn_filldata.Location = new Point(132, 465);
            btn_filldata.Name = "btn_filldata";
            btn_filldata.Size = new Size(176, 43);
            btn_filldata.TabIndex = 5;
            btn_filldata.Text = "Fill Data";
            btn_filldata.UseVisualStyleBackColor = false;
            btn_filldata.Click += btn_filldata_Click;
            // 
            // lbl_information
            // 
            lbl_information.BackColor = Color.FromArgb(25, 118, 210);
            lbl_information.Dock = DockStyle.Top;
            lbl_information.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_information.ForeColor = Color.White;
            lbl_information.Location = new Point(0, 0);
            lbl_information.Name = "lbl_information";
            lbl_information.Size = new Size(646, 51);
            lbl_information.TabIndex = 0;
            lbl_information.Text = "Information";
            lbl_information.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(300, 447);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 25);
            lbl_error.TabIndex = 6;
            lbl_error.Click += lbl_error_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick_1;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.FromArgb(25, 118, 210);
            btn_Back.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(370, 465);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(237, 43);
            btn_Back.TabIndex = 5;
            btn_Back.Text = "Back to Master";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(646, 541);
            Controls.Add(lbl_error);
            Controls.Add(btn_Back);
            Controls.Add(btn_filldata);
            Controls.Add(btn_femalee);
            Controls.Add(btn_female);
            Controls.Add(btn_malee);
            Controls.Add(btn_male);
            Controls.Add(date_dateofbirth);
            Controls.Add(date_dob);
            Controls.Add(txt_nicnumber);
            Controls.Add(txt_nic);
            Controls.Add(txt_phone);
            Controls.Add(txt_telephonenumber);
            Controls.Add(txt_textarea);
            Controls.Add(txt_address);
            Controls.Add(txt_lname);
            Controls.Add(txt_lastname);
            Controls.Add(txt_fname);
            Controls.Add(txt_firstname);
            Controls.Add(lbl_nic);
            Controls.Add(lbl_gender);
            Controls.Add(lbl_phonenumber);
            Controls.Add(lbl_address);
            Controls.Add(lbl_dob);
            Controls.Add(lbl_lastname);
            Controls.Add(lbl_information);
            Controls.Add(lbl_firstname);
            Name = "FrmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_firstname;
        private Label lbl_lastname;
        private Label lbl_dob;
        private Label lbl_address;
        private Label lbl_phonenumber;
        private Label lbl_gender;
        private Label lbl_nic;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private TextBox txt_address;
        private DateTimePicker date_dob;
        private TextBox txt_telephonenumber;
        private RadioButton btn_male;
        private RadioButton btn_female;
        private TextBox txt_nic;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private DateTimePicker date_dateofbirth;
        private TextBox txt_textarea;
        private TextBox txt_phone;
        private RadioButton btn_malee;
        private RadioButton btn_femalee;
        private TextBox txt_nicnumber;
        private Button btn_filldata;
        private Label lbl_information;
        private Label lbl_error;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Back;
    }
}
