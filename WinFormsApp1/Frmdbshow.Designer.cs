namespace WinFormsApp1
{
    partial class Frmdbshow
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
            cmb_medium = new ComboBox();
            cmb_familyid = new ComboBox();
            cmbhouse = new ComboBox();
            dtp_dob = new DateTimePicker();
            cmb_grade = new ComboBox();
            lbl_addmission = new Label();
            lbl_dob = new Label();
            lblgrade = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblgender = new Label();
            txtaddmission = new TextBox();
            txt_address = new TextBox();
            txt_lname = new TextBox();
            txt_phone = new TextBox();
            txt_nic = new TextBox();
            txt_fname = new TextBox();
            lbl_address = new Label();
            lbl_familyid = new Label();
            lblmedium = new Label();
            lbl_house = new Label();
            lbl_phone = new Label();
            lbl_lastname = new Label();
            lblnic = new Label();
            lbl_firstname = new Label();
            SuspendLayout();
            // 
            // cmb_medium
            // 
            cmb_medium.FormattingEnabled = true;
            cmb_medium.Items.AddRange(new object[] { "Tamil", "English" });
            cmb_medium.Location = new Point(682, 200);
            cmb_medium.Name = "cmb_medium";
            cmb_medium.Size = new Size(182, 33);
            cmb_medium.TabIndex = 45;
            // 
            // cmb_familyid
            // 
            cmb_familyid.FormattingEnabled = true;
            cmb_familyid.Location = new Point(685, 255);
            cmb_familyid.Name = "cmb_familyid";
            cmb_familyid.Size = new Size(182, 33);
            cmb_familyid.TabIndex = 44;
            // 
            // cmbhouse
            // 
            cmbhouse.FormattingEnabled = true;
            cmbhouse.Location = new Point(682, 141);
            cmbhouse.Name = "cmbhouse";
            cmbhouse.Size = new Size(182, 33);
            cmbhouse.TabIndex = 43;
            // 
            // dtp_dob
            // 
            dtp_dob.Location = new Point(174, 314);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(193, 31);
            dtp_dob.TabIndex = 42;
            // 
            // cmb_grade
            // 
            cmb_grade.FormattingEnabled = true;
            cmb_grade.Location = new Point(174, 263);
            cmb_grade.Name = "cmb_grade";
            cmb_grade.Size = new Size(193, 33);
            cmb_grade.TabIndex = 41;
            // 
            // lbl_addmission
            // 
            lbl_addmission.AutoSize = true;
            lbl_addmission.Location = new Point(484, 320);
            lbl_addmission.Name = "lbl_addmission";
            lbl_addmission.Size = new Size(177, 25);
            lbl_addmission.TabIndex = 40;
            lbl_addmission.Text = "Addmission Number";
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Location = new Point(36, 320);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(112, 25);
            lbl_dob.TabIndex = 39;
            lbl_dob.Text = "Date of Birth";
            // 
            // lblgrade
            // 
            lblgrade.AutoSize = true;
            lblgrade.Location = new Point(36, 266);
            lblgrade.Name = "lblgrade";
            lblgrade.Size = new Size(59, 25);
            lblgrade.TabIndex = 38;
            lblgrade.Text = "Grade";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(274, 208);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 37;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(174, 208);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 36;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(36, 210);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(69, 25);
            lblgender.TabIndex = 35;
            lblgender.Text = "Gender";
            // 
            // txtaddmission
            // 
            txtaddmission.Location = new Point(685, 320);
            txtaddmission.Name = "txtaddmission";
            txtaddmission.Size = new Size(193, 31);
            txtaddmission.TabIndex = 29;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(174, 149);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(193, 31);
            txt_address.TabIndex = 30;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(174, 94);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(193, 31);
            txt_lname.TabIndex = 31;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(671, 88);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(193, 31);
            txt_phone.TabIndex = 32;
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(662, 24);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(193, 31);
            txt_nic.TabIndex = 33;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(174, 40);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(193, 31);
            txt_fname.TabIndex = 34;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(36, 155);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(77, 25);
            lbl_address.TabIndex = 21;
            lbl_address.Text = "Address";
            // 
            // lbl_familyid
            // 
            lbl_familyid.AutoSize = true;
            lbl_familyid.Location = new Point(484, 263);
            lbl_familyid.Name = "lbl_familyid";
            lbl_familyid.Size = new Size(83, 25);
            lbl_familyid.TabIndex = 26;
            lbl_familyid.Text = "Family Id";
            // 
            // lblmedium
            // 
            lblmedium.AutoSize = true;
            lblmedium.Location = new Point(484, 208);
            lblmedium.Name = "lblmedium";
            lblmedium.Size = new Size(78, 25);
            lblmedium.TabIndex = 25;
            lblmedium.Text = "Medium";
            // 
            // lbl_house
            // 
            lbl_house.AutoSize = true;
            lbl_house.Location = new Point(479, 149);
            lbl_house.Name = "lbl_house";
            lbl_house.Size = new Size(83, 25);
            lbl_house.TabIndex = 24;
            lbl_house.Text = "House id";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(459, 94);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(132, 25);
            lbl_phone.TabIndex = 23;
            lbl_phone.Text = "Phone Number";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Location = new Point(36, 100);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(95, 25);
            lbl_lastname.TabIndex = 22;
            lbl_lastname.Text = "Last Name";
            // 
            // lblnic
            // 
            lblnic.AutoSize = true;
            lblnic.Location = new Point(460, 30);
            lblnic.Name = "lblnic";
            lblnic.Size = new Size(107, 25);
            lblnic.TabIndex = 28;
            lblnic.Text = "Nic Number";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(36, 46);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(97, 25);
            lbl_firstname.TabIndex = 27;
            lbl_firstname.Text = "First Name";
            // 
            // Frmdbshow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 404);
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
            Name = "Frmdbshow";
            Text = "Frmdbshow";
            Load += Frmdbshow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_medium;
        private ComboBox cmb_familyid;
        private ComboBox cmbhouse;
        private DateTimePicker dtp_dob;
        private ComboBox cmb_grade;
        private Label lbl_addmission;
        private Label lbl_dob;
        private Label lblgrade;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblgender;
        private TextBox txtaddmission;
        private TextBox txt_address;
        private TextBox txt_lname;
        private TextBox txt_phone;
        private TextBox txt_nic;
        private TextBox txt_fname;
        private Label lbl_address;
        private Label lbl_familyid;
        private Label lblmedium;
        private Label lbl_house;
        private Label lbl_phone;
        private Label lbl_lastname;
        private Label lblnic;
        private Label lbl_firstname;
    }
}