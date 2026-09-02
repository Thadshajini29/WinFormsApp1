namespace WinFormsApp1
{
    partial class FrmShowStudent
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
            txt_address = new TextBox();
            txt_lname = new TextBox();
            txt_fname = new TextBox();
            lbl_address = new Label();
            lbl_lastname = new Label();
            lbl_firstname = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblgender = new Label();
            cmb_grade = new ComboBox();
            lblgrade = new Label();
            lbl_dob = new Label();
            dtp_dob = new DateTimePicker();
            lbl_addmission = new Label();
            txtaddmission = new TextBox();
            lblnic = new Label();
            txt_nic = new TextBox();
            lbl_phone = new Label();
            txt_phone = new TextBox();
            lbl_house = new Label();
            cmbhouse = new ComboBox();
            lblmedium = new Label();
            lbl_familyid = new Label();
            cmb_familyid = new ComboBox();
            cmb_medium = new ComboBox();
            lbl_studentinformation = new Label();
            SuspendLayout();
            // 
            // txt_address
            // 
            txt_address.Location = new Point(177, 262);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(193, 31);
            txt_address.TabIndex = 9;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(177, 207);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(193, 31);
            txt_lname.TabIndex = 10;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(177, 153);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(193, 31);
            txt_fname.TabIndex = 11;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(39, 268);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(77, 25);
            lbl_address.TabIndex = 6;
            lbl_address.Text = "Address";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Location = new Point(39, 213);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(95, 25);
            lbl_lastname.TabIndex = 7;
            lbl_lastname.Text = "Last Name";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(39, 159);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(97, 25);
            lbl_firstname.TabIndex = 8;
            lbl_firstname.Text = "First Name";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(277, 321);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 14;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(177, 321);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 13;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += rdoMale_CheckedChanged;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(39, 323);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(69, 25);
            lblgender.TabIndex = 12;
            lblgender.Text = "Gender";
            lblgender.Click += lblgender_Click;
            // 
            // cmb_grade
            // 
            cmb_grade.FormattingEnabled = true;
            cmb_grade.Location = new Point(177, 376);
            cmb_grade.Name = "cmb_grade";
            cmb_grade.Size = new Size(193, 33);
            cmb_grade.TabIndex = 16;
            cmb_grade.SelectedIndexChanged += cmb_grade_SelectedIndexChanged;
            // 
            // lblgrade
            // 
            lblgrade.AutoSize = true;
            lblgrade.Location = new Point(39, 379);
            lblgrade.Name = "lblgrade";
            lblgrade.Size = new Size(59, 25);
            lblgrade.TabIndex = 15;
            lblgrade.Text = "Grade";
            lblgrade.Click += lblgrade_Click;
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Location = new Point(39, 433);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(112, 25);
            lbl_dob.TabIndex = 15;
            lbl_dob.Text = "Date of Birth";
            lbl_dob.Click += label1_Click;
            // 
            // dtp_dob
            // 
            dtp_dob.Location = new Point(177, 427);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(193, 31);
            dtp_dob.TabIndex = 17;
            // 
            // lbl_addmission
            // 
            lbl_addmission.AutoSize = true;
            lbl_addmission.Location = new Point(487, 433);
            lbl_addmission.Name = "lbl_addmission";
            lbl_addmission.Size = new Size(177, 25);
            lbl_addmission.TabIndex = 15;
            lbl_addmission.Text = "Addmission Number";
            lbl_addmission.Click += label1_Click;
            // 
            // txtaddmission
            // 
            txtaddmission.Location = new Point(688, 433);
            txtaddmission.Name = "txtaddmission";
            txtaddmission.Size = new Size(193, 31);
            txtaddmission.TabIndex = 9;
            // 
            // lblnic
            // 
            lblnic.AutoSize = true;
            lblnic.Location = new Point(463, 143);
            lblnic.Name = "lblnic";
            lblnic.Size = new Size(107, 25);
            lblnic.TabIndex = 8;
            lblnic.Text = "Nic Number";
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(677, 137);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(193, 31);
            txt_nic.TabIndex = 11;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(462, 207);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(132, 25);
            lbl_phone.TabIndex = 7;
            lbl_phone.Text = "Phone Number";
            lbl_phone.Click += lbl_phone_Click;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(674, 201);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(193, 31);
            txt_phone.TabIndex = 11;
            // 
            // lbl_house
            // 
            lbl_house.AutoSize = true;
            lbl_house.Location = new Point(482, 262);
            lbl_house.Name = "lbl_house";
            lbl_house.Size = new Size(83, 25);
            lbl_house.TabIndex = 7;
            lbl_house.Text = "House id";
            lbl_house.Click += lbl_phone_Click;
            // 
            // cmbhouse
            // 
            cmbhouse.FormattingEnabled = true;
            cmbhouse.Location = new Point(685, 254);
            cmbhouse.Name = "cmbhouse";
            cmbhouse.Size = new Size(182, 33);
            cmbhouse.TabIndex = 18;
            // 
            // lblmedium
            // 
            lblmedium.AutoSize = true;
            lblmedium.Location = new Point(487, 321);
            lblmedium.Name = "lblmedium";
            lblmedium.Size = new Size(78, 25);
            lblmedium.TabIndex = 7;
            lblmedium.Text = "Medium";
            lblmedium.Click += lbl_phone_Click;
            // 
            // lbl_familyid
            // 
            lbl_familyid.AutoSize = true;
            lbl_familyid.Location = new Point(487, 376);
            lbl_familyid.Name = "lbl_familyid";
            lbl_familyid.Size = new Size(83, 25);
            lbl_familyid.TabIndex = 7;
            lbl_familyid.Text = "Family Id";
            lbl_familyid.Click += lbl_phone_Click;
            // 
            // cmb_familyid
            // 
            cmb_familyid.FormattingEnabled = true;
            cmb_familyid.Location = new Point(688, 368);
            cmb_familyid.Name = "cmb_familyid";
            cmb_familyid.Size = new Size(182, 33);
            cmb_familyid.TabIndex = 19;
            // 
            // cmb_medium
            // 
            cmb_medium.FormattingEnabled = true;
            cmb_medium.Items.AddRange(new object[] { "Tamil", "English" });
            cmb_medium.Location = new Point(685, 313);
            cmb_medium.Name = "cmb_medium";
            cmb_medium.Size = new Size(182, 33);
            cmb_medium.TabIndex = 20;
            cmb_medium.SelectedIndexChanged += cmb_medium_SelectedIndexChanged;
            // 
            // lbl_studentinformation
            // 
            lbl_studentinformation.BackColor = SystemColors.ScrollBar;
            lbl_studentinformation.Dock = DockStyle.Top;
            lbl_studentinformation.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_studentinformation.ForeColor = SystemColors.Highlight;
            lbl_studentinformation.Location = new Point(0, 0);
            lbl_studentinformation.Name = "lbl_studentinformation";
            lbl_studentinformation.Size = new Size(921, 89);
            lbl_studentinformation.TabIndex = 21;
            lbl_studentinformation.Text = "Student Information Page";
            lbl_studentinformation.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmShowStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 503);
            Controls.Add(lbl_studentinformation);
            Controls.Add(cmb_medium);
            Controls.Add(cmb_familyid);
            Controls.Add(cmbhouse);
            Controls.Add(dtp_dob);
            Controls.Add(cmb_grade);
            Controls.Add(lbl_addmission);
            Controls.Add(lbl_dob);
            Controls.Add(lblgrade);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(lblgender);
            Controls.Add(txtaddmission);
            Controls.Add(txt_address);
            Controls.Add(txt_lname);
            Controls.Add(txt_phone);
            Controls.Add(txt_nic);
            Controls.Add(txt_fname);
            Controls.Add(lbl_address);
            Controls.Add(lbl_familyid);
            Controls.Add(lblmedium);
            Controls.Add(lbl_house);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_lastname);
            Controls.Add(lblnic);
            Controls.Add(lbl_firstname);
            Name = "FrmShowStudent";
            Text = "FrmShowStudent";
            Load += FrmShowStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_address;
        private TextBox txt_lname;
        private TextBox txt_fname;
        private Label lbl_address;
        private Label lbl_lastname;
        private Label lbl_firstname;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblgender;
        private ComboBox cmb_grade;
        private Label lblgrade;
        private Label lbl_dob;
        private DateTimePicker dtp_dob;
        private Label lbl_addmission;
        private TextBox txtaddmission;
        private Label lblnic;
        private TextBox txt_nic;
        private Label lbl_phone;
        private TextBox txt_phone;
        private Label lbl_house;
        private ComboBox cmbhouse;
        private Label lblmedium;
        private Label lbl_familyid;
        private ComboBox cmb_familyid;
        private ComboBox cmb_medium;
        private Label lbl_studentinformation;
    }
}